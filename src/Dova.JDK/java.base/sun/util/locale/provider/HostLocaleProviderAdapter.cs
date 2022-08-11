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

[JniSignatureAttribute("Lsun/util/locale/provider/HostLocaleProviderAdapter;", "public")]
public partial class HostLocaleProviderAdapter
	: Dova.JDK.sun.util.locale.provider.AuxLocaleProviderAdapter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HostLocaleProviderAdapter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/util/locale/provider/HostLocaleProviderAdapter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAdapterType", "()Lsun/util/locale/provider/LocaleProviderAdapter$Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeIntegerFormatter", "(Ljava/text/DecimalFormat;)Ljava/text/DecimalFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findInstalledProvider", "(Ljava/lang/Class;)Ljava/util/spi/LocaleServiceProvider;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HostLocaleProviderAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public HostLocaleProviderAdapter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/util/locale/provider/HostLocaleProviderAdapter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lsun/util/locale/provider/LocaleProviderAdapter$Type;", "public")]
	public Dova.JDK.sun.util.locale.provider.LocaleProviderAdapter.Type getAdapterType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.locale.provider.LocaleProviderAdapter.Type>(ret);
	}

	[JniSignatureAttribute("(Ljava/text/DecimalFormat;)Ljava/text/DecimalFormat;", "static")]
	public static Dova.JDK.java.text.DecimalFormat makeIntegerFormatter(Dova.JDK.java.text.DecimalFormat arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.DecimalFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/util/spi/LocaleServiceProvider;", "protected")]
	public Dova.JDK.java.lang.Object findInstalledProvider(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}
}
