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

namespace Dova.JDK.com.sun.tools.jdi;

[JniSignatureAttribute("Lcom/sun/tools/jdi/ValueImpl;", "abstract")]
public partial class ValueImpl
	: Dova.JDK.com.sun.tools.jdi.MirrorImpl
	, Dova.JDK.com.sun.jdi.Value
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ValueImpl()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/jdi/ValueImpl;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ValueImpl", "(Lcom/sun/jdi/VirtualMachine;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "prepareForAssignment", "(Lcom/sun/jdi/Value;Lcom/sun/tools/jdi/ValueContainer;)Lcom/sun/tools/jdi/ValueImpl;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "typeValueKey", "()B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "typeValueKey", "(Lcom/sun/jdi/Value;)B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "prepareForAssignmentTo", "(Lcom/sun/tools/jdi/ValueContainer;)Lcom/sun/tools/jdi/ValueImpl;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ValueImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/VirtualMachine;)V", "")]
	public ValueImpl(Dova.JDK.com.sun.jdi.VirtualMachine arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/ValueImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/jdi/Value;Lcom/sun/tools/jdi/ValueContainer;)Lcom/sun/tools/jdi/ValueImpl;", "static")]
	public static Dova.JDK.com.sun.tools.jdi.ValueImpl prepareForAssignment(Dova.JDK.com.sun.jdi.Value arg0, Dova.JDK.com.sun.tools.jdi.ValueContainer arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ValueImpl>(ret);
	}

	[JniSignatureAttribute("()B", "abstract")]
	public byte typeValueKey()
	{
		var ret = DovaJvm.Vm.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/Value;)B", "static")]
	public static byte typeValueKey(Dova.JDK.com.sun.jdi.Value arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdi/ValueContainer;)Lcom/sun/tools/jdi/ValueImpl;", "abstract")]
	public Dova.JDK.com.sun.tools.jdi.ValueImpl prepareForAssignmentTo(Dova.JDK.com.sun.tools.jdi.ValueContainer arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ValueImpl>(ret);
	}
}
