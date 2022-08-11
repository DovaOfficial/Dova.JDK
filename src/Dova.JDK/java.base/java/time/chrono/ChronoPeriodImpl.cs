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

namespace Dova.JDK.java.time.chrono;

[JniSignatureAttribute("Ljava/time/chrono/ChronoPeriodImpl;", "final")]
public partial class ChronoPeriodImpl
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.time.chrono.ChronoPeriod
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ChronoPeriodImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/chrono/ChronoPeriodImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUPPORTED_UNITS", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "chrono", "Ljava/time/chrono/Chronology;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "years", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "months", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "days", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/chrono/Chronology;III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(Ljava/time/temporal/TemporalUnit;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeReplace", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "normalized", "()Ljava/time/chrono/ChronoPeriod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isZero", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNegative", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoPeriod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoPeriod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUnits", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "multipliedBy", "(I)Ljava/time/chrono/ChronoPeriod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addTo", "(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subtractFrom", "(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeExternal", "(Ljava/io/DataOutput;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readExternal", "(Ljava/io/DataInput;)Ljava/time/chrono/ChronoPeriodImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChronology", "()Ljava/time/chrono/Chronology;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validateChrono", "(Ljava/time/temporal/TemporalAccessor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validateAmount", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoPeriodImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "monthRange", "()J"));
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private static final")]
	public static Dova.JDK.java.util.List SUPPORTED_UNITS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/chrono/Chronology;", "private final")]
	public Dova.JDK.java.time.chrono.Chronology chrono_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.Chronology>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "final")]
	public int years_Property
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

	[JniSignatureAttribute("I", "final")]
	public int months_Property
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

	[JniSignatureAttribute("I", "final")]
	public int days_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ChronoPeriodImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/time/chrono/Chronology;III)V", "")]
	public ChronoPeriodImpl(Dova.JDK.java.time.chrono.Chronology arg0, int arg1, int arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/time/chrono/ChronoPeriodImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalUnit;)J", "public")]
	public long get(Dova.JDK.java.time.temporal.TemporalUnit arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "protected")]
	public Dova.JDK.java.lang.Object writeReplace()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/chrono/ChronoPeriod;", "public")]
	public Dova.JDK.java.time.chrono.ChronoPeriod normalized()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoPeriod>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isZero()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isNegative()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoPeriod;", "public")]
	public Dova.JDK.java.time.chrono.ChronoPeriod minus(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoPeriod>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoPeriod;", "public")]
	public Dova.JDK.java.time.chrono.ChronoPeriod plus(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoPeriod>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getUnits()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/time/chrono/ChronoPeriod;", "public")]
	public Dova.JDK.java.time.chrono.ChronoPeriod multipliedBy(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoPeriod>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;", "public")]
	public Dova.JDK.java.time.temporal.Temporal addTo(Dova.JDK.java.time.temporal.Temporal arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;", "public")]
	public Dova.JDK.java.time.temporal.Temporal subtractFrom(Dova.JDK.java.time.temporal.Temporal arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/DataOutput;)V", "")]
	public void writeExternal(Dova.JDK.java.io.DataOutput arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/DataInput;)Ljava/time/chrono/ChronoPeriodImpl;", "static")]
	public static Dova.JDK.java.time.chrono.ChronoPeriodImpl readExternal(Dova.JDK.java.io.DataInput arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoPeriodImpl>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/chrono/Chronology;", "public")]
	public Dova.JDK.java.time.chrono.Chronology getChronology()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.Chronology>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)V", "private")]
	public void validateChrono(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoPeriodImpl;", "private")]
	public Dova.JDK.java.time.chrono.ChronoPeriodImpl validateAmount(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoPeriodImpl>(ret);
	}

	[JniSignatureAttribute("()J", "private")]
	public long monthRange()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[20]);
		return ret;
	}
}
