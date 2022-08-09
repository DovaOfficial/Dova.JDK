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

namespace Dova.JDK.jdk.@internal.org.jline.terminal.impl;

[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/impl/MouseSupport;", "public")]
public partial class MouseSupport
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MouseSupport()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/org/jline/terminal/impl/MouseSupport;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "MouseSupport", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "hasMouseSupport", "(Ljdk/internal/org/jline/terminal/Terminal;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "trackMouse", "(Ljdk/internal/org/jline/terminal/Terminal;Ljdk/internal/org/jline/terminal/Terminal$MouseTracking;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "readExt", "(Ljdk/internal/org/jline/terminal/Terminal;)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "readMouse", "(Ljava/util/function/IntSupplier;Ljdk/internal/org/jline/terminal/MouseEvent;)Ljdk/internal/org/jline/terminal/MouseEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "readMouse", "(Ljdk/internal/org/jline/terminal/Terminal;Ljdk/internal/org/jline/terminal/MouseEvent;)Ljdk/internal/org/jline/terminal/MouseEvent;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MouseSupport(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public MouseSupport() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/terminal/impl/MouseSupport;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Terminal;)Z", "public static")]
	public static bool hasMouseSupport(Dova.JDK.jdk.@internal.org.jline.terminal.Terminal arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Terminal;Ljdk/internal/org/jline/terminal/Terminal$MouseTracking;)Z", "public static")]
	public static bool trackMouse(Dova.JDK.jdk.@internal.org.jline.terminal.Terminal arg0, Dova.JDK.jdk.@internal.org.jline.terminal.Terminal.MouseTracking arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Terminal;)I", "private static")]
	public static int readExt(Dova.JDK.jdk.@internal.org.jline.terminal.Terminal arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/function/IntSupplier;Ljdk/internal/org/jline/terminal/MouseEvent;)Ljdk/internal/org/jline/terminal/MouseEvent;", "public static")]
	public static Dova.JDK.jdk.@internal.org.jline.terminal.MouseEvent readMouse(Dova.JDK.java.util.function.IntSupplier arg0, Dova.JDK.jdk.@internal.org.jline.terminal.MouseEvent arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.MouseEvent>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Terminal;Ljdk/internal/org/jline/terminal/MouseEvent;)Ljdk/internal/org/jline/terminal/MouseEvent;", "public static")]
	public static Dova.JDK.jdk.@internal.org.jline.terminal.MouseEvent readMouse(Dova.JDK.jdk.@internal.org.jline.terminal.Terminal arg0, Dova.JDK.jdk.@internal.org.jline.terminal.MouseEvent arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.MouseEvent>(ret);
	}
}
