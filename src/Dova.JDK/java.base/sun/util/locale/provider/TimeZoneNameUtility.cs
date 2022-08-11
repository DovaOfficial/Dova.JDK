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

[JniSignatureAttribute("Lsun/util/locale/provider/TimeZoneNameUtility;", "public final")]
public partial class TimeZoneNameUtility
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TimeZoneNameUtility()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/util/locale/provider/TimeZoneNameUtility;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "cachedZoneData", "Ljava/util/concurrent/ConcurrentHashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "cachedDisplayNames", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getZoneStrings", "(Ljava/util/Locale;)[[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "retrieveDisplayName", "(Ljava/lang/String;ZILjava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "convertLDMLShortID", "(Ljava/lang/String;)Ljava/util/Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "retrieveGenericDisplayName", "(Ljava/lang/String;ILjava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "retrieveDisplayNames", "(Ljava/lang/String;Ljava/util/Locale;)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "canonicalTZID", "(Ljava/lang/String;)Ljava/util/Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loadZoneStrings", "(Ljava/util/Locale;)[[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "retrieveDisplayNamesImpl", "(Ljava/lang/String;Ljava/util/Locale;)[Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentHashMap;", "private static final")]
	public static Dova.JDK.java.util.concurrent.ConcurrentHashMap cachedZoneData_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentHashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map cachedDisplayNames_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TimeZoneNameUtility(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public TimeZoneNameUtility() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/util/locale/provider/TimeZoneNameUtility;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/util/Locale;)[[Ljava/lang/String;", "public static")]
	public static JavaArray<JavaArray<Dova.JDK.java.lang.String>> getZoneStrings(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.java.lang.String>>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;ZILjava/util/Locale;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String retrieveDisplayName(Dova.JDK.java.lang.String arg0, bool arg1, int arg2, Dova.JDK.java.util.Locale arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Optional;", "public static")]
	public static Dova.JDK.java.util.Optional convertLDMLShortID(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/util/Locale;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String retrieveGenericDisplayName(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.util.Locale arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Locale;)[Ljava/lang/String;", "public static")]
	public static JavaArray<Dova.JDK.java.lang.String> retrieveDisplayNames(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Optional;", "public static")]
	public static Dova.JDK.java.util.Optional canonicalTZID(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)[[Ljava/lang/String;", "private static")]
	public static JavaArray<JavaArray<Dova.JDK.java.lang.String>> loadZoneStrings(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.java.lang.String>>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Locale;)[Ljava/lang/String;", "private static")]
	public static JavaArray<Dova.JDK.java.lang.String> retrieveDisplayNamesImpl(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("Lsun/util/locale/provider/TimeZoneNameUtility$TimeZoneNameGetter;", "private static")]
	public partial class TimeZoneNameGetter
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.util.locale.provider.LocaleServiceProviderPool.LocalizedObjectGetter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TimeZoneNameGetter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/util/locale/provider/TimeZoneNameUtility$TimeZoneNameGetter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lsun/util/locale/provider/TimeZoneNameUtility$TimeZoneNameGetter;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getName", "(Ljava/util/spi/TimeZoneNameProvider;Ljava/util/Locale;Ljava/lang/String;ILjava/lang/String;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObject", "(Ljava/util/spi/LocaleServiceProvider;Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObject", "(Ljava/util/spi/TimeZoneNameProvider;Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "examineAliases", "(Ljava/util/spi/TimeZoneNameProvider;Ljava/util/Locale;Ljava/lang/String;Ljava/lang/String;ILjava/util/Map;)Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Lsun/util/locale/provider/TimeZoneNameUtility$TimeZoneNameGetter;", "private static final")]
		public static Dova.JDK.sun.util.locale.provider.TimeZoneNameUtility.TimeZoneNameGetter INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.util.locale.provider.TimeZoneNameUtility.TimeZoneNameGetter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TimeZoneNameGetter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public TimeZoneNameGetter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/util/locale/provider/TimeZoneNameUtility$TimeZoneNameGetter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/spi/TimeZoneNameProvider;Ljava/util/Locale;Ljava/lang/String;ILjava/lang/String;)Ljava/lang/String;", "private static")]
		public static Dova.JDK.java.lang.String getName(Dova.JDK.java.util.spi.TimeZoneNameProvider arg0, Dova.JDK.java.util.Locale arg1, Dova.JDK.java.lang.String arg2, int arg3, Dova.JDK.java.lang.String arg4)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/spi/LocaleServiceProvider;Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object getObject(Dova.JDK.java.util.spi.LocaleServiceProvider arg0, Dova.JDK.java.util.Locale arg1, Dova.JDK.java.lang.String arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/spi/TimeZoneNameProvider;Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", "public transient")]
		public Dova.JDK.java.lang.String getObject(Dova.JDK.java.util.spi.TimeZoneNameProvider arg0, Dova.JDK.java.util.Locale arg1, Dova.JDK.java.lang.String arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/spi/TimeZoneNameProvider;Ljava/util/Locale;Ljava/lang/String;Ljava/lang/String;ILjava/util/Map;)Ljava/lang/String;", "private static")]
		public static Dova.JDK.java.lang.String examineAliases(Dova.JDK.java.util.spi.TimeZoneNameProvider arg0, Dova.JDK.java.util.Locale arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, int arg4, Dova.JDK.java.util.Map arg5)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}
}
