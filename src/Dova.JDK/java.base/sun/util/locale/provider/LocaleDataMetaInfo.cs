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

[JniSignatureAttribute("Lsun/util/locale/provider/LocaleDataMetaInfo;", "public abstract interface")]
public partial interface LocaleDataMetaInfo
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LocaleDataMetaInfo()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/util/locale/provider/LocaleDataMetaInfo;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lsun/util/locale/provider/LocaleProviderAdapter$Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "availableLanguageTags", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLanguageAliasMap", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tzCanonicalIDs", "()Ljava/util/Map;"));
	}

	[JniSignatureAttribute("()Lsun/util/locale/provider/LocaleProviderAdapter$Type;", "public abstract")]
	Dova.JDK.sun.util.locale.provider.LocaleProviderAdapter.Type getType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.locale.provider.LocaleProviderAdapter.Type>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String availableLanguageTags(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "public")]
	Dova.JDK.java.util.Map getLanguageAliasMap()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "public")]
	Dova.JDK.java.util.Map tzCanonicalIDs()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}
}
