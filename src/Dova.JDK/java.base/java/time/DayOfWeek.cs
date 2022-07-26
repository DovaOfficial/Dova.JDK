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

namespace Dova.JDK.java.time;

[JniSignatureAttribute("Ljava/time/DayOfWeek;", "public final")]
public partial class DayOfWeek
	: Dova.JDK.java.lang.Enum
	, Dova.JDK.java.time.temporal.TemporalAccessor
	, Dova.JDK.java.time.temporal.TemporalAdjuster
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DayOfWeek()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/DayOfWeek;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MONDAY", "Ljava/time/DayOfWeek;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TUESDAY", "Ljava/time/DayOfWeek;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WEDNESDAY", "Ljava/time/DayOfWeek;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THURSDAY", "Ljava/time/DayOfWeek;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FRIDAY", "Ljava/time/DayOfWeek;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SATURDAY", "Ljava/time/DayOfWeek;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUNDAY", "Ljava/time/DayOfWeek;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENUMS", "[Ljava/time/DayOfWeek;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljava/time/DayOfWeek;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(Ljava/time/temporal/TemporalField;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljava/time/DayOfWeek;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLong", "(Ljava/time/temporal/TemporalField;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljava/time/DayOfWeek;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(I)Ljava/time/DayOfWeek;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "from", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/DayOfWeek;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupported", "(Ljava/time/temporal/TemporalField;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "query", "(Ljava/time/temporal/TemporalQuery;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "range", "(Ljava/time/temporal/TemporalField;)Ljava/time/temporal/ValueRange;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljava/time/DayOfWeek;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDisplayName", "(Ljava/time/format/TextStyle;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus", "(J)Ljava/time/DayOfWeek;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus", "(J)Ljava/time/DayOfWeek;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "adjustInto", "(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;"));
	}

	[JniSignatureAttribute("Ljava/time/DayOfWeek;", "public static final")]
	public static Dova.JDK.java.time.DayOfWeek MONDAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.DayOfWeek>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/DayOfWeek;", "public static final")]
	public static Dova.JDK.java.time.DayOfWeek TUESDAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.DayOfWeek>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/DayOfWeek;", "public static final")]
	public static Dova.JDK.java.time.DayOfWeek WEDNESDAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.DayOfWeek>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/DayOfWeek;", "public static final")]
	public static Dova.JDK.java.time.DayOfWeek THURSDAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.DayOfWeek>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/DayOfWeek;", "public static final")]
	public static Dova.JDK.java.time.DayOfWeek FRIDAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.DayOfWeek>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/DayOfWeek;", "public static final")]
	public static Dova.JDK.java.time.DayOfWeek SATURDAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.DayOfWeek>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/DayOfWeek;", "public static final")]
	public static Dova.JDK.java.time.DayOfWeek SUNDAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.DayOfWeek>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/time/DayOfWeek;", "private static final")]
	public static JavaArray<Dova.JDK.java.time.DayOfWeek> ENUMS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.time.DayOfWeek>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/time/DayOfWeek;", "private static final")]
	public static JavaArray<Dova.JDK.java.time.DayOfWeek> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.time.DayOfWeek>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DayOfWeek(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
	public DayOfWeek(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/time/DayOfWeek;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;)I", "public")]
	public int get(Dova.JDK.java.time.temporal.TemporalField arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()[Ljava/time/DayOfWeek;", "public static")]
	public static JavaArray<Dova.JDK.java.time.DayOfWeek> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.time.DayOfWeek>>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;)J", "public")]
	public long getLong(Dova.JDK.java.time.temporal.TemporalField arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/time/DayOfWeek;", "public static")]
	public static Dova.JDK.java.time.DayOfWeek valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.DayOfWeek>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getValue()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/time/DayOfWeek;", "public static")]
	public static Dova.JDK.java.time.DayOfWeek of(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.DayOfWeek>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)Ljava/time/DayOfWeek;", "public static")]
	public static Dova.JDK.java.time.DayOfWeek from(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.DayOfWeek>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;)Z", "public")]
	public bool isSupported(Dova.JDK.java.time.temporal.TemporalField arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalQuery;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object query(Dova.JDK.java.time.temporal.TemporalQuery arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;)Ljava/time/temporal/ValueRange;", "public")]
	public Dova.JDK.java.time.temporal.ValueRange range(Dova.JDK.java.time.temporal.TemporalField arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.ValueRange>(ret);
	}

	[JniSignatureAttribute("()[Ljava/time/DayOfWeek;", "private static")]
	public static JavaArray<Dova.JDK.java.time.DayOfWeek> _values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.time.DayOfWeek>>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/format/TextStyle;Ljava/util/Locale;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getDisplayName(Dova.JDK.java.time.format.TextStyle arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/DayOfWeek;", "public")]
	public Dova.JDK.java.time.DayOfWeek minus(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.DayOfWeek>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/DayOfWeek;", "public")]
	public Dova.JDK.java.time.DayOfWeek plus(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.DayOfWeek>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;", "public")]
	public Dova.JDK.java.time.temporal.Temporal adjustInto(Dova.JDK.java.time.temporal.Temporal arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}
}
