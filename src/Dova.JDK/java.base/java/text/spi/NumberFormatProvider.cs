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

namespace Dova.JDK.java.text.spi;

[JniSignatureAttribute("Ljava/text/spi/NumberFormatProvider;", "public abstract")]
public partial class NumberFormatProvider
	: Dova.JDK.java.util.spi.LocaleServiceProvider
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NumberFormatProvider()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/text/spi/NumberFormatProvider;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNumberInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPercentInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCurrencyInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIntegerInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCompactNumberInstance", "(Ljava/util/Locale;Ljava/text/NumberFormat$Style;)Ljava/text/NumberFormat;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public NumberFormatProvider(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public NumberFormatProvider() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/text/spi/NumberFormatProvider;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/util/Locale;)Ljava/text/NumberFormat;", "public abstract")]
	public Dova.JDK.java.text.NumberFormat getNumberInstance(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.NumberFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)Ljava/text/NumberFormat;", "public abstract")]
	public Dova.JDK.java.text.NumberFormat getPercentInstance(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.NumberFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)Ljava/text/NumberFormat;", "public abstract")]
	public Dova.JDK.java.text.NumberFormat getCurrencyInstance(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.NumberFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)Ljava/text/NumberFormat;", "public abstract")]
	public Dova.JDK.java.text.NumberFormat getIntegerInstance(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.NumberFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;Ljava/text/NumberFormat$Style;)Ljava/text/NumberFormat;", "public")]
	public Dova.JDK.java.text.NumberFormat getCompactNumberInstance(Dova.JDK.java.util.Locale arg0, Dova.JDK.java.text.NumberFormat.Style arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.NumberFormat>(ret);
	}
}
