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

namespace Dova.JDK.sun.java2d.marlin.stats;

[JniSignatureAttribute("Lsun/java2d/marlin/stats/StatLong;", "public")]
public partial class StatLong
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StatLong()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/java2d/marlin/stats/StatLong;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "name", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "count", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "sum", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "min", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "max", "J"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "StatLong", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "add", "(J)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "add", "(I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "(Ljava/lang/StringBuilder;)Ljava/lang/StringBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "reset", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "trimTo3Digits", "(D)D"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public final")]
	public Dova.JDK.java.lang.String name_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("J", "public")]
	public long count_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("J", "public")]
	public long sum_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("J", "public")]
	public long min_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("J", "public")]
	public long max_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public StatLong(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public StatLong(Dova.JDK.java.lang.String arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/marlin/stats/StatLong;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(J)V", "public")]
	public void add(long arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void add(int arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuilder;)Ljava/lang/StringBuilder;", "public final")]
	public Dova.JDK.java.lang.StringBuilder toString(Dova.JDK.java.lang.StringBuilder arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void reset()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(D)D", "public static")]
	public static double trimTo3Digits(double arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return ret;
	}
}
