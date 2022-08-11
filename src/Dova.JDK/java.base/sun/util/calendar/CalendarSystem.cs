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

[JniSignatureAttribute("Lsun/util/calendar/CalendarSystem;", "public abstract")]
public partial class CalendarSystem
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CalendarSystem()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/util/calendar/CalendarSystem;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "initialized", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "names", "Ljava/util/concurrent/ConcurrentMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "calendars", "Ljava/util/concurrent/ConcurrentMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PACKAGE_NAME", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "namePairs", "[Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forName", "(Ljava/lang/String;)Lsun/util/calendar/CalendarSystem;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validate", "(Lsun/util/calendar/CalendarDate;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "normalize", "(Lsun/util/calendar/CalendarDate;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEras", "()[Lsun/util/calendar/Era;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTime", "(Lsun/util/calendar/CalendarDate;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEra", "(Ljava/lang/String;)Lsun/util/calendar/Era;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTimeOfDay", "(Lsun/util/calendar/CalendarDate;I)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newCalendarDate", "()Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newCalendarDate", "(Ljava/util/TimeZone;)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCalendarDate", "(JLsun/util/calendar/CalendarDate;)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCalendarDate", "(JLjava/util/TimeZone;)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCalendarDate", "(J)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCalendarDate", "()Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getGregorianCalendar", "()Lsun/util/calendar/Gregorian;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMonthLength", "(Lsun/util/calendar/CalendarDate;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getYearLength", "(Lsun/util/calendar/CalendarDate;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEra", "(Lsun/util/calendar/CalendarDate;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWeekLength", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNthDayOfWeek", "(IILsun/util/calendar/CalendarDate;)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initNames", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getYearLengthInMonths", "(Lsun/util/calendar/CalendarDate;)I"));
	}

	[JniSignatureAttribute("Z", "private static volatile")]
	public static bool initialized_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentMap;", "private static")]
	public static Dova.JDK.java.util.concurrent.ConcurrentMap names_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentMap;", "private static")]
	public static Dova.JDK.java.util.concurrent.ConcurrentMap calendars_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String PACKAGE_NAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> namePairs_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CalendarSystem(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public CalendarSystem() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/util/calendar/CalendarSystem;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/util/calendar/CalendarSystem;", "public static")]
	public static Dova.JDK.sun.util.calendar.CalendarSystem forName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarSystem>(ret);
	}

	[JniSignatureAttribute("(Lsun/util/calendar/CalendarDate;)Z", "public abstract")]
	public bool validate(Dova.JDK.sun.util.calendar.CalendarDate arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/util/calendar/CalendarDate;)Z", "public abstract")]
	public bool normalize(Dova.JDK.sun.util.calendar.CalendarDate arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("()[Lsun/util/calendar/Era;", "public abstract")]
	public JavaArray<Dova.JDK.sun.util.calendar.Era> getEras()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.util.calendar.Era>>(ret);
	}

	[JniSignatureAttribute("(Lsun/util/calendar/CalendarDate;)J", "public abstract")]
	public long getTime(Dova.JDK.sun.util.calendar.CalendarDate arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/util/calendar/Era;", "public abstract")]
	public Dova.JDK.sun.util.calendar.Era getEra(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.Era>(ret);
	}

	[JniSignatureAttribute("(Lsun/util/calendar/CalendarDate;I)Lsun/util/calendar/CalendarDate;", "public abstract")]
	public Dova.JDK.sun.util.calendar.CalendarDate setTimeOfDay(Dova.JDK.sun.util.calendar.CalendarDate arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("()Lsun/util/calendar/CalendarDate;", "public abstract")]
	public Dova.JDK.sun.util.calendar.CalendarDate newCalendarDate()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/TimeZone;)Lsun/util/calendar/CalendarDate;", "public abstract")]
	public Dova.JDK.sun.util.calendar.CalendarDate newCalendarDate(Dova.JDK.java.util.TimeZone arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(JLsun/util/calendar/CalendarDate;)Lsun/util/calendar/CalendarDate;", "public abstract")]
	public Dova.JDK.sun.util.calendar.CalendarDate getCalendarDate(long arg0, Dova.JDK.sun.util.calendar.CalendarDate arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(JLjava/util/TimeZone;)Lsun/util/calendar/CalendarDate;", "public abstract")]
	public Dova.JDK.sun.util.calendar.CalendarDate getCalendarDate(long arg0, Dova.JDK.java.util.TimeZone arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(J)Lsun/util/calendar/CalendarDate;", "public abstract")]
	public Dova.JDK.sun.util.calendar.CalendarDate getCalendarDate(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("()Lsun/util/calendar/CalendarDate;", "public abstract")]
	public Dova.JDK.sun.util.calendar.CalendarDate getCalendarDate()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("()Lsun/util/calendar/Gregorian;", "public static")]
	public static Dova.JDK.sun.util.calendar.Gregorian getGregorianCalendar()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.Gregorian>(ret);
	}

	[JniSignatureAttribute("(Lsun/util/calendar/CalendarDate;)I", "public abstract")]
	public int getMonthLength(Dova.JDK.sun.util.calendar.CalendarDate arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/util/calendar/CalendarDate;)I", "public abstract")]
	public int getYearLength(Dova.JDK.sun.util.calendar.CalendarDate arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/util/calendar/CalendarDate;Ljava/lang/String;)V", "public abstract")]
	public void setEra(Dova.JDK.sun.util.calendar.CalendarDate arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	public int getWeekLength()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("(IILsun/util/calendar/CalendarDate;)Lsun/util/calendar/CalendarDate;", "public abstract")]
	public Dova.JDK.sun.util.calendar.CalendarDate getNthDayOfWeek(int arg0, int arg1, Dova.JDK.sun.util.calendar.CalendarDate arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("()V", "private static")]
	public static void initNames()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[20]);
	}

	[JniSignatureAttribute("(Lsun/util/calendar/CalendarDate;)I", "public abstract")]
	public int getYearLengthInMonths(Dova.JDK.sun.util.calendar.CalendarDate arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("Lsun/util/calendar/CalendarSystem$GregorianHolder;", "private static final")]
	public partial class GregorianHolder
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static GregorianHolder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/util/calendar/CalendarSystem$GregorianHolder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GREGORIAN_INSTANCE", "Lsun/util/calendar/Gregorian;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("Lsun/util/calendar/Gregorian;", "private static final")]
		public static Dova.JDK.sun.util.calendar.Gregorian GREGORIAN_INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.Gregorian>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public GregorianHolder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public GregorianHolder() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/util/calendar/CalendarSystem$GregorianHolder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
