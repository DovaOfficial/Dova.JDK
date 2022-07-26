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

namespace Dova.JDK.sun.util.calendar;

[JniSignatureAttribute("Lsun/util/calendar/ZoneInfoFile;", "public final")]
public partial class ZoneInfoFile
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ZoneInfoFile()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/util/calendar/ZoneInfoFile;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "versionId", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "zones", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "aliases", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ruleArray", "[[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "regions", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "indices", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "USE_OLDMAPPING", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "oldMappings", "[[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UTC1900", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UTC2037", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LDT2037", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CURRT", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECONDS_PER_DAY", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DAYS_PER_CYCLE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DAYS_0000_TO_1970", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "toCalendarDOW", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "toSTZTime", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OFFSET_MASK", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DST_MASK", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DST_NSHIFT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRANSITION_NSHIFT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LASTYEAR", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "indexOf", "([IIII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "load", "(Ljava/io/DataInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getYear", "(JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toCustomID", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getStandardOffset", "([J[IJ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readEpochSec", "(Ljava/io/DataInput;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readOffset", "(Ljava/io/DataInput;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "useOldMapping", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getZoneInfo", "(Ljava/lang/String;)Lsun/util/calendar/ZoneInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getZoneInfo", "(Ljava/io/DataInput;Ljava/lang/String;)Lsun/util/calendar/ZoneInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getZoneInfo", "(Ljava/lang/String;[J[I[J[I[Lsun/util/calendar/ZoneInfoFile$ZoneOffsetTransitionRule;)Lsun/util/calendar/ZoneInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCustomTimeZone", "(Ljava/lang/String;I)Lsun/util/calendar/ZoneInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getVersion", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getZoneIds", "(I)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getZoneIds", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAliasMap", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getZoneInfo0", "(Ljava/lang/String;)Lsun/util/calendar/ZoneInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addOldMapping", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addTrans", "([JI[IIJII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loadTZDB", "()V"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String versionId_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map zones_Property
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

	[JniSignatureAttribute("Ljava/util/Map;", "private static")]
	public static Dova.JDK.java.util.Map aliases_Property
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

	[JniSignatureAttribute("[[B", "private static")]
	public static JavaArray<JavaArray<byte>> ruleArray_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<byte>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static")]
	public static JavaArray<Dova.JDK.java.lang.String> regions_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "private static")]
	public static JavaArray<int> indices_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool USE_OLDMAPPING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("[[Ljava/lang/String;", "private static")]
	public static JavaArray<JavaArray<Dova.JDK.java.lang.String>> oldMappings_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.java.lang.String>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long UTC1900_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long UTC2037_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long LDT2037_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long CURRT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int SECONDS_PER_DAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int DAYS_PER_CYCLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long DAYS_0000_TO_1970_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("[I", "private static final")]
	public static JavaArray<int> toCalendarDOW_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "private static final")]
	public static JavaArray<int> toSTZTime_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long OFFSET_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long DST_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DST_NSHIFT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int TRANSITION_NSHIFT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int LASTYEAR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ZoneInfoFile(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public ZoneInfoFile() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/util/calendar/ZoneInfoFile;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([IIII)I", "private static")]
	public static int indexOf(JavaArray<int> arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/DataInputStream;)V", "private static")]
	public static void load(Dova.JDK.java.io.DataInputStream arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(JI)I", "private static")]
	public static int getYear(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String toCustomID(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([J[IJ)I", "private static")]
	public static int getStandardOffset(JavaArray<long> arg0, JavaArray<int> arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/DataInput;)J", "static")]
	public static long readEpochSec(Dova.JDK.java.io.DataInput arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/DataInput;)I", "public static")]
	public static int readOffset(Dova.JDK.java.io.DataInput arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool useOldMapping()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/util/calendar/ZoneInfo;", "public static")]
	public static Dova.JDK.sun.util.calendar.ZoneInfo getZoneInfo(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.ZoneInfo>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/DataInput;Ljava/lang/String;)Lsun/util/calendar/ZoneInfo;", "public static")]
	public static Dova.JDK.sun.util.calendar.ZoneInfo getZoneInfo(Dova.JDK.java.io.DataInput arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.ZoneInfo>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[J[I[J[I[Lsun/util/calendar/ZoneInfoFile$ZoneOffsetTransitionRule;)Lsun/util/calendar/ZoneInfo;", "private static")]
	public static Dova.JDK.sun.util.calendar.ZoneInfo getZoneInfo(Dova.JDK.java.lang.String arg0, JavaArray<long> arg1, JavaArray<int> arg2, JavaArray<long> arg3, JavaArray<int> arg4, JavaArray<Dova.JDK.sun.util.calendar.ZoneInfoFile.ZoneOffsetTransitionRule> arg5)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.ZoneInfo>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Lsun/util/calendar/ZoneInfo;", "public static")]
	public static Dova.JDK.sun.util.calendar.ZoneInfo getCustomTimeZone(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.ZoneInfo>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getVersion()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)[Ljava/lang/String;", "public static")]
	public static JavaArray<Dova.JDK.java.lang.String> getZoneIds(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "public static")]
	public static JavaArray<Dova.JDK.java.lang.String> getZoneIds()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "public static")]
	public static Dova.JDK.java.util.Map getAliasMap()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/util/calendar/ZoneInfo;", "private static")]
	public static Dova.JDK.sun.util.calendar.ZoneInfo getZoneInfo0(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.ZoneInfo>(ret);
	}

	[JniSignatureAttribute("()V", "private static")]
	public static void addOldMapping()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[17]);
	}

	[JniSignatureAttribute("([JI[IIJII)I", "private static")]
	public static int addTrans(JavaArray<long> arg0, int arg1, JavaArray<int> arg2, int arg3, long arg4, int arg5, int arg6)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("()V", "private static")]
	public static void loadTZDB()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[19]);
	}

	[JniSignatureAttribute("Lsun/util/calendar/ZoneInfoFile$ZoneOffsetTransitionRule;", "private static")]
	public partial class ZoneOffsetTransitionRule
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ZoneOffsetTransitionRule()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/util/calendar/ZoneInfoFile$ZoneOffsetTransitionRule;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "month", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dom", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dow", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "secondOfDay", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "timeDefinition", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "standardOffset", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offsetBefore", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offsetAfter", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/DataInput;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isLeapYear", "(I)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lengthOfMonth", "(II)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toEpochDay", "(III)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "adjust", "(JII)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nextOrSame", "(JI)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "previousOrSame", "(JI)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransitionEpochSecond", "(I)J"));
		}

		[JniSignatureAttribute("I", "private final")]
		public int month_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("B", "private final")]
		public byte dom_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int dow_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int secondOfDay_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int timeDefinition_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int standardOffset_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int offsetBefore_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int offsetAfter_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ZoneOffsetTransitionRule(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/io/DataInput;)V", "")]
		public ZoneOffsetTransitionRule(Dova.JDK.java.io.DataInput arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/util/calendar/ZoneInfoFile$ZoneOffsetTransitionRule;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Z", "static final")]
		public static bool isLeapYear(int arg0)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(II)I", "static final")]
		public static int lengthOfMonth(int arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(III)J", "static final")]
		public static long toEpochDay(int arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(JII)J", "static final")]
		public static long adjust(long arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(JI)J", "static final")]
		public static long nextOrSame(long arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(JI)J", "static final")]
		public static long previousOrSame(long arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(I)J", "")]
		public long getTransitionEpochSecond(int arg0)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/util/calendar/ZoneInfoFile$Checksum;", "private static")]
	public partial class Checksum
		: Dova.JDK.java.util.zip.CRC32
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Checksum()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/util/calendar/ZoneInfoFile$Checksum;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "update", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "update", "(J)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Checksum(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Checksum() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/util/calendar/ZoneInfoFile$Checksum;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)V", "public")]
		public void update(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(J)V", "")]
		public void update(long arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}
	}
}
