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

namespace Dova.JDK.java.time.temporal;

[JniSignatureAttribute("Ljava/time/temporal/TemporalAdjusters;", "public final")]
public partial class TemporalAdjusters
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TemporalAdjusters()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/time/temporal/TemporalAdjusters;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "TemporalAdjusters", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "next", "(Ljava/time/DayOfWeek;)Ljava/time/temporal/TemporalAdjuster;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "previous", "(Ljava/time/DayOfWeek;)Ljava/time/temporal/TemporalAdjuster;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "firstDayOfYear", "()Ljava/time/temporal/TemporalAdjuster;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "lastDayOfMonth", "()Ljava/time/temporal/TemporalAdjuster;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "nextOrSame", "(Ljava/time/DayOfWeek;)Ljava/time/temporal/TemporalAdjuster;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "previousOrSame", "(Ljava/time/DayOfWeek;)Ljava/time/temporal/TemporalAdjuster;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "dayOfWeekInMonth", "(ILjava/time/DayOfWeek;)Ljava/time/temporal/TemporalAdjuster;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "ofDateAdjuster", "(Ljava/util/function/UnaryOperator;)Ljava/time/temporal/TemporalAdjuster;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "firstDayOfMonth", "()Ljava/time/temporal/TemporalAdjuster;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "firstDayOfNextMonth", "()Ljava/time/temporal/TemporalAdjuster;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "lastDayOfYear", "()Ljava/time/temporal/TemporalAdjuster;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "firstDayOfNextYear", "()Ljava/time/temporal/TemporalAdjuster;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "firstInMonth", "(Ljava/time/DayOfWeek;)Ljava/time/temporal/TemporalAdjuster;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "lastInMonth", "(Ljava/time/DayOfWeek;)Ljava/time/temporal/TemporalAdjuster;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TemporalAdjusters(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public TemporalAdjusters() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/time/temporal/TemporalAdjusters;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/time/DayOfWeek;)Ljava/time/temporal/TemporalAdjuster;", "public static")]
	public static Dova.JDK.java.time.temporal.TemporalAdjuster next(Dova.JDK.java.time.DayOfWeek arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalAdjuster>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/DayOfWeek;)Ljava/time/temporal/TemporalAdjuster;", "public static")]
	public static Dova.JDK.java.time.temporal.TemporalAdjuster previous(Dova.JDK.java.time.DayOfWeek arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalAdjuster>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/temporal/TemporalAdjuster;", "public static")]
	public static Dova.JDK.java.time.temporal.TemporalAdjuster firstDayOfYear()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalAdjuster>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/temporal/TemporalAdjuster;", "public static")]
	public static Dova.JDK.java.time.temporal.TemporalAdjuster lastDayOfMonth()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalAdjuster>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/DayOfWeek;)Ljava/time/temporal/TemporalAdjuster;", "public static")]
	public static Dova.JDK.java.time.temporal.TemporalAdjuster nextOrSame(Dova.JDK.java.time.DayOfWeek arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalAdjuster>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/DayOfWeek;)Ljava/time/temporal/TemporalAdjuster;", "public static")]
	public static Dova.JDK.java.time.temporal.TemporalAdjuster previousOrSame(Dova.JDK.java.time.DayOfWeek arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalAdjuster>(ret);
	}

	[JniSignatureAttribute("(ILjava/time/DayOfWeek;)Ljava/time/temporal/TemporalAdjuster;", "public static")]
	public static Dova.JDK.java.time.temporal.TemporalAdjuster dayOfWeekInMonth(int arg0, Dova.JDK.java.time.DayOfWeek arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalAdjuster>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/UnaryOperator;)Ljava/time/temporal/TemporalAdjuster;", "public static")]
	public static Dova.JDK.java.time.temporal.TemporalAdjuster ofDateAdjuster(Dova.JDK.java.util.function.UnaryOperator arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalAdjuster>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/temporal/TemporalAdjuster;", "public static")]
	public static Dova.JDK.java.time.temporal.TemporalAdjuster firstDayOfMonth()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalAdjuster>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/temporal/TemporalAdjuster;", "public static")]
	public static Dova.JDK.java.time.temporal.TemporalAdjuster firstDayOfNextMonth()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalAdjuster>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/temporal/TemporalAdjuster;", "public static")]
	public static Dova.JDK.java.time.temporal.TemporalAdjuster lastDayOfYear()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalAdjuster>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/temporal/TemporalAdjuster;", "public static")]
	public static Dova.JDK.java.time.temporal.TemporalAdjuster firstDayOfNextYear()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalAdjuster>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/DayOfWeek;)Ljava/time/temporal/TemporalAdjuster;", "public static")]
	public static Dova.JDK.java.time.temporal.TemporalAdjuster firstInMonth(Dova.JDK.java.time.DayOfWeek arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalAdjuster>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/DayOfWeek;)Ljava/time/temporal/TemporalAdjuster;", "public static")]
	public static Dova.JDK.java.time.temporal.TemporalAdjuster lastInMonth(Dova.JDK.java.time.DayOfWeek arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalAdjuster>(ret);
	}
}
