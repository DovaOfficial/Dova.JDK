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

[JniSignatureAttribute("Lsun/util/locale/provider/LocaleNameProviderImpl;", "public")]
public partial class LocaleNameProviderImpl
	: Dova.JDK.java.util.spi.LocaleNameProvider
	, Dova.JDK.sun.util.locale.provider.AvailableLanguageTags
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LocaleNameProviderImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/util/locale/provider/LocaleNameProviderImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Lsun/util/locale/provider/LocaleProviderAdapter$Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "langtags", "Ljava/util/Set;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/util/locale/provider/LocaleProviderAdapter$Type;Ljava/util/Set;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAvailableLocales", "()[Ljava/util/Locale;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupportedLocale", "(Ljava/util/Locale;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDisplayLanguage", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDisplayString", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDisplayScript", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDisplayCountry", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDisplayVariant", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDisplayUnicodeExtensionKey", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDisplayUnicodeExtensionType", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAvailableLanguageTags", "()Ljava/util/Set;"));
	}

	[JniSignatureAttribute("Lsun/util/locale/provider/LocaleProviderAdapter$Type;", "private final")]
	public Dova.JDK.sun.util.locale.provider.LocaleProviderAdapter.Type type_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.locale.provider.LocaleProviderAdapter.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "private final")]
	public Dova.JDK.java.util.Set langtags_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LocaleNameProviderImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/util/locale/provider/LocaleProviderAdapter$Type;Ljava/util/Set;)V", "public")]
	public LocaleNameProviderImpl(Dova.JDK.sun.util.locale.provider.LocaleProviderAdapter.Type arg0, Dova.JDK.java.util.Set arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/util/locale/provider/LocaleNameProviderImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Ljava/util/Locale;", "public")]
	public JavaArray<Dova.JDK.java.util.Locale> getAvailableLocales()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.Locale>>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)Z", "public")]
	public bool isSupportedLocale(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getDisplayLanguage(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getDisplayString(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getDisplayScript(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getDisplayCountry(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getDisplayVariant(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getDisplayUnicodeExtensionKey(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getDisplayUnicodeExtensionType(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Locale arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set getAvailableLanguageTags()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}
}
