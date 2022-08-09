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

namespace Dova.JDK.sun.util.calendar;

[JniSignatureAttribute("Lsun/util/calendar/LocalGregorianCalendar;", "public")]
public partial class LocalGregorianCalendar
	: Dova.JDK.sun.util.calendar.BaseCalendar
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LocalGregorianCalendar()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/util/calendar/LocalGregorianCalendar;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JAPANESE_ERAS", "[Lsun/util/calendar/Era;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "name", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "eras", "[Lsun/util/calendar/Era;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "LocalGregorianCalendar", "(Ljava/lang/String;[Lsun/util/calendar/Era;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "validate", "(Lsun/util/calendar/CalendarDate;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "normalize", "(Lsun/util/calendar/CalendarDate;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isLeapYear", "(Lsun/util/calendar/Era;I)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isLeapYear", "(I)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newCalendarDate_0", "()Lsun/util/calendar/LocalGregorianCalendar$Date;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newCalendarDate_1", "()Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newCalendarDate_0", "(Ljava/util/TimeZone;)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newCalendarDate_1", "(Ljava/util/TimeZone;)Lsun/util/calendar/LocalGregorianCalendar$Date;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCalendarDate_0", "()Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCalendarDate_1", "()Lsun/util/calendar/LocalGregorianCalendar$Date;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCalendarDate_0", "(JLjava/util/TimeZone;)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCalendarDate_1", "(JLjava/util/TimeZone;)Lsun/util/calendar/LocalGregorianCalendar$Date;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCalendarDate_0", "(JLsun/util/calendar/CalendarDate;)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCalendarDate_1", "(JLsun/util/calendar/CalendarDate;)Lsun/util/calendar/LocalGregorianCalendar$Date;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCalendarDate_0", "(J)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCalendarDate_1", "(J)Lsun/util/calendar/LocalGregorianCalendar$Date;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCalendarDateFromFixedDate", "(Lsun/util/calendar/CalendarDate;J)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getLocalGregorianCalendar", "(Ljava/lang/String;)Lsun/util/calendar/LocalGregorianCalendar;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "normalizeMonth", "(Lsun/util/calendar/CalendarDate;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "parseEraEntry", "(Ljava/lang/String;)Lsun/util/calendar/Era;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isValidEra", "(Lsun/util/calendar/Era;[Lsun/util/calendar/Era;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "convertUnicodeEscape", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "adjustYear", "(Lsun/util/calendar/LocalGregorianCalendar$Date;JI)Lsun/util/calendar/LocalGregorianCalendar$Date;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "validateEra", "(Lsun/util/calendar/Era;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "normalizeYear", "(Lsun/util/calendar/CalendarDate;)V"));
	}

	[JniSignatureAttribute("[Lsun/util/calendar/Era;", "private static final")]
	public static JavaArray<Dova.JDK.sun.util.calendar.Era> JAPANESE_ERAS_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.util.calendar.Era>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String name_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Lsun/util/calendar/Era;", "private")]
	public JavaArray<Dova.JDK.sun.util.calendar.Era> eras_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.util.calendar.Era>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LocalGregorianCalendar(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Lsun/util/calendar/Era;)V", "private")]
	public LocalGregorianCalendar(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.sun.util.calendar.Era> arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/util/calendar/LocalGregorianCalendar;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getName()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lsun/util/calendar/CalendarDate;)Z", "public")]
	public bool validate(Dova.JDK.sun.util.calendar.CalendarDate arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/util/calendar/CalendarDate;)Z", "public")]
	public bool normalize(Dova.JDK.sun.util.calendar.CalendarDate arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/util/calendar/Era;I)Z", "public")]
	public bool isLeapYear(Dova.JDK.sun.util.calendar.Era arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool isLeapYear(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/util/calendar/LocalGregorianCalendar$Date;", "public")]
	public Dova.JDK.sun.util.calendar.LocalGregorianCalendar.Date newCalendarDate_0()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.LocalGregorianCalendar.Date>(ret);
	}

	[JniSignatureAttribute("()Lsun/util/calendar/CalendarDate;", "public volatile")]
	public Dova.JDK.sun.util.calendar.CalendarDate newCalendarDate_1()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/TimeZone;)Lsun/util/calendar/CalendarDate;", "public volatile")]
	public Dova.JDK.sun.util.calendar.CalendarDate newCalendarDate_0(Dova.JDK.java.util.TimeZone arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/TimeZone;)Lsun/util/calendar/LocalGregorianCalendar$Date;", "public")]
	public Dova.JDK.sun.util.calendar.LocalGregorianCalendar.Date newCalendarDate_1(Dova.JDK.java.util.TimeZone arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.LocalGregorianCalendar.Date>(ret);
	}

	[JniSignatureAttribute("()Lsun/util/calendar/CalendarDate;", "public volatile")]
	public Dova.JDK.sun.util.calendar.CalendarDate getCalendarDate_0()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("()Lsun/util/calendar/LocalGregorianCalendar$Date;", "public")]
	public Dova.JDK.sun.util.calendar.LocalGregorianCalendar.Date getCalendarDate_1()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.LocalGregorianCalendar.Date>(ret);
	}

	[JniSignatureAttribute("(JLjava/util/TimeZone;)Lsun/util/calendar/CalendarDate;", "public volatile")]
	public Dova.JDK.sun.util.calendar.CalendarDate getCalendarDate_0(long arg0, Dova.JDK.java.util.TimeZone arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(JLjava/util/TimeZone;)Lsun/util/calendar/LocalGregorianCalendar$Date;", "public")]
	public Dova.JDK.sun.util.calendar.LocalGregorianCalendar.Date getCalendarDate_1(long arg0, Dova.JDK.java.util.TimeZone arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.LocalGregorianCalendar.Date>(ret);
	}

	[JniSignatureAttribute("(JLsun/util/calendar/CalendarDate;)Lsun/util/calendar/CalendarDate;", "public volatile")]
	public Dova.JDK.sun.util.calendar.CalendarDate getCalendarDate_0(long arg0, Dova.JDK.sun.util.calendar.CalendarDate arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(JLsun/util/calendar/CalendarDate;)Lsun/util/calendar/LocalGregorianCalendar$Date;", "public")]
	public Dova.JDK.sun.util.calendar.LocalGregorianCalendar.Date getCalendarDate_1(long arg0, Dova.JDK.sun.util.calendar.CalendarDate arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.LocalGregorianCalendar.Date>(ret);
	}

	[JniSignatureAttribute("(J)Lsun/util/calendar/CalendarDate;", "public volatile")]
	public Dova.JDK.sun.util.calendar.CalendarDate getCalendarDate_0(long arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(J)Lsun/util/calendar/LocalGregorianCalendar$Date;", "public")]
	public Dova.JDK.sun.util.calendar.LocalGregorianCalendar.Date getCalendarDate_1(long arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.LocalGregorianCalendar.Date>(ret);
	}

	[JniSignatureAttribute("(Lsun/util/calendar/CalendarDate;J)V", "public")]
	public void getCalendarDateFromFixedDate(Dova.JDK.sun.util.calendar.CalendarDate arg0, long arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/util/calendar/LocalGregorianCalendar;", "static")]
	public static Dova.JDK.sun.util.calendar.LocalGregorianCalendar getLocalGregorianCalendar(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.LocalGregorianCalendar>(ret);
	}

	[JniSignatureAttribute("(Lsun/util/calendar/CalendarDate;)V", "")]
	public void normalizeMonth(Dova.JDK.sun.util.calendar.CalendarDate arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/util/calendar/Era;", "private static")]
	public static Dova.JDK.sun.util.calendar.Era parseEraEntry(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.Era>(ret);
	}

	[JniSignatureAttribute("(Lsun/util/calendar/Era;[Lsun/util/calendar/Era;)Z", "private static")]
	public static bool isValidEra(Dova.JDK.sun.util.calendar.Era arg0, JavaArray<Dova.JDK.sun.util.calendar.Era> arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String convertUnicodeEscape(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lsun/util/calendar/LocalGregorianCalendar$Date;JI)Lsun/util/calendar/LocalGregorianCalendar$Date;", "private")]
	public Dova.JDK.sun.util.calendar.LocalGregorianCalendar.Date adjustYear(Dova.JDK.sun.util.calendar.LocalGregorianCalendar.Date arg0, long arg1, int arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.LocalGregorianCalendar.Date>(ret);
	}

	[JniSignatureAttribute("(Lsun/util/calendar/Era;)Z", "private")]
	public bool validateEra(Dova.JDK.sun.util.calendar.Era arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/util/calendar/CalendarDate;)V", "")]
	public void normalizeYear(Dova.JDK.sun.util.calendar.CalendarDate arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("Lsun/util/calendar/LocalGregorianCalendar$Date;", "public static")]
	public partial class Date
		: Dova.JDK.sun.util.calendar.BaseCalendar.Date
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Date()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/util/calendar/LocalGregorianCalendar$Date;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "gregorianYear", "I"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Date", "()V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Date", "(Ljava/util/TimeZone;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addYear_0", "(I)Lsun/util/calendar/LocalGregorianCalendar$Date;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addYear_1", "(I)Lsun/util/calendar/CalendarDate;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setNormalizedYear", "(I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getNormalizedYear", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setYear_0", "(I)Lsun/util/calendar/CalendarDate;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setYear_1", "(I)Lsun/util/calendar/LocalGregorianCalendar$Date;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setEra_0", "(Lsun/util/calendar/Era;)Lsun/util/calendar/CalendarDate;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setEra_1", "(Lsun/util/calendar/Era;)Lsun/util/calendar/LocalGregorianCalendar$Date;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setLocalEra", "(Lsun/util/calendar/Era;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setLocalYear", "(I)V"));
		}

		[JniSignatureAttribute("I", "private")]
		public int gregorianYear_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Date(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "protected")]
		public Date() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Ljava/util/TimeZone;)V", "protected")]
		public Date(Dova.JDK.java.util.TimeZone arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/util/calendar/LocalGregorianCalendar$Date;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(I)Lsun/util/calendar/LocalGregorianCalendar$Date;", "public")]
		public Dova.JDK.sun.util.calendar.LocalGregorianCalendar.Date addYear_0(int arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.LocalGregorianCalendar.Date>(ret);
		}

		[JniSignatureAttribute("(I)Lsun/util/calendar/CalendarDate;", "public volatile")]
		public Dova.JDK.sun.util.calendar.CalendarDate addYear_1(int arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
		}

		[JniSignatureAttribute("(I)V", "public")]
		public void setNormalizedYear(int arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getNormalizedYear()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("(I)Lsun/util/calendar/CalendarDate;", "public volatile")]
		public Dova.JDK.sun.util.calendar.CalendarDate setYear_0(int arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
		}

		[JniSignatureAttribute("(I)Lsun/util/calendar/LocalGregorianCalendar$Date;", "public")]
		public Dova.JDK.sun.util.calendar.LocalGregorianCalendar.Date setYear_1(int arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.LocalGregorianCalendar.Date>(ret);
		}

		[JniSignatureAttribute("(Lsun/util/calendar/Era;)Lsun/util/calendar/CalendarDate;", "public volatile")]
		public Dova.JDK.sun.util.calendar.CalendarDate setEra_0(Dova.JDK.sun.util.calendar.Era arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
		}

		[JniSignatureAttribute("(Lsun/util/calendar/Era;)Lsun/util/calendar/LocalGregorianCalendar$Date;", "public")]
		public Dova.JDK.sun.util.calendar.LocalGregorianCalendar.Date setEra_1(Dova.JDK.sun.util.calendar.Era arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.LocalGregorianCalendar.Date>(ret);
		}

		[JniSignatureAttribute("(Lsun/util/calendar/Era;)V", "")]
		public void setLocalEra(Dova.JDK.sun.util.calendar.Era arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("(I)V", "")]
		public void setLocalYear(int arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		}
	}
}
