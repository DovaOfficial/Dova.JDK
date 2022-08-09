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

[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/impl/CursorSupport;", "public")]
public partial class CursorSupport
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CursorSupport()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/org/jline/terminal/impl/CursorSupport;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CursorSupport", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getCursorPosition", "(Ljdk/internal/org/jline/terminal/Terminal;Ljava/util/function/IntConsumer;)Ljdk/internal/org/jline/terminal/Cursor;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CursorSupport(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public CursorSupport() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/terminal/impl/CursorSupport;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Terminal;Ljava/util/function/IntConsumer;)Ljdk/internal/org/jline/terminal/Cursor;", "public static")]
	public static Dova.JDK.jdk.@internal.org.jline.terminal.Cursor getCursorPosition(Dova.JDK.jdk.@internal.org.jline.terminal.Terminal arg0, Dova.JDK.java.util.function.IntConsumer arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Cursor>(ret);
	}
}