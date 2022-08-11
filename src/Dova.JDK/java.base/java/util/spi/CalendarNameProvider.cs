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

namespace Dova.JDK.java.util.spi;

[JniSignatureAttribute("Ljava/util/spi/CalendarNameProvider;", "public abstract")]
public partial class CalendarNameProvider
	: Dova.JDK.java.util.spi.LocaleServiceProvider
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CalendarNameProvider()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/spi/CalendarNameProvider;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDisplayName", "(Ljava/lang/String;IIILjava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDisplayNames", "(Ljava/lang/String;IILjava/util/Locale;)Ljava/util/Map;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CalendarNameProvider(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public CalendarNameProvider() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/spi/CalendarNameProvider;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;IIILjava/util/Locale;)Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String getDisplayName(Dova.JDK.java.lang.String arg0, int arg1, int arg2, int arg3, Dova.JDK.java.util.Locale arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;IILjava/util/Locale;)Ljava/util/Map;", "public abstract")]
	public Dova.JDK.java.util.Map getDisplayNames(Dova.JDK.java.lang.String arg0, int arg1, int arg2, Dova.JDK.java.util.Locale arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}
}
