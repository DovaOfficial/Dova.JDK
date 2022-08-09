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

namespace Dova.JDK.sun.jvmstat.perfdata.monitor;

[JniSignatureAttribute("Lsun/jvmstat/perfdata/monitor/PerfStringMonitor;", "public")]
public partial class PerfStringMonitor
	: Dova.JDK.sun.jvmstat.perfdata.monitor.PerfByteArrayMonitor
	, Dova.JDK.sun.jvmstat.monitor.StringMonitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PerfStringMonitor()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/jvmstat/perfdata/monitor/PerfStringMonitor;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "defaultCharset", "Ljava/nio/charset/Charset;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "PerfStringMonitor", "(Ljava/lang/String;Lsun/jvmstat/monitor/Variability;ZLjava/nio/ByteBuffer;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "PerfStringMonitor", "(Ljava/lang/String;Lsun/jvmstat/monitor/Variability;ZLjava/nio/ByteBuffer;I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getValue", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "stringValue", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Ljava/nio/charset/Charset;", "private static")]
	public static Dova.JDK.java.nio.charset.Charset defaultCharset_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.Charset>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PerfStringMonitor(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lsun/jvmstat/monitor/Variability;ZLjava/nio/ByteBuffer;)V", "public")]
	public PerfStringMonitor(Dova.JDK.java.lang.String arg0, Dova.JDK.sun.jvmstat.monitor.Variability arg1, bool arg2, Dova.JDK.java.nio.ByteBuffer arg3) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lsun/jvmstat/monitor/Variability;ZLjava/nio/ByteBuffer;I)V", "public")]
	public PerfStringMonitor(Dova.JDK.java.lang.String arg0, Dova.JDK.sun.jvmstat.monitor.Variability arg1, bool arg2, Dova.JDK.java.nio.ByteBuffer arg3, int arg4) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/jvmstat/perfdata/monitor/PerfStringMonitor;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getValue()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String stringValue()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
