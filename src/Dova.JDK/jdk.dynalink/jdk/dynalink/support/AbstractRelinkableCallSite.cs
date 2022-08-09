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

namespace Dova.JDK.jdk.dynalink.support;

[JniSignatureAttribute("Ljdk/dynalink/support/AbstractRelinkableCallSite;", "public abstract")]
public partial class AbstractRelinkableCallSite
	: Dova.JDK.java.lang.invoke.MutableCallSite
	, Dova.JDK.jdk.dynalink.RelinkableCallSite
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AbstractRelinkableCallSite()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/dynalink/support/AbstractRelinkableCallSite;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "descriptor", "Ljdk/dynalink/CallSiteDescriptor;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "AbstractRelinkableCallSite", "(Ljdk/dynalink/CallSiteDescriptor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getDescriptor", "()Ljdk/dynalink/CallSiteDescriptor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "initialize", "(Ljava/lang/invoke/MethodHandle;)V"));
	}

	[JniSignatureAttribute("Ljdk/dynalink/CallSiteDescriptor;", "private final")]
	public Dova.JDK.jdk.dynalink.CallSiteDescriptor descriptor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.CallSiteDescriptor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AbstractRelinkableCallSite(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/dynalink/CallSiteDescriptor;)V", "protected")]
	public AbstractRelinkableCallSite(Dova.JDK.jdk.dynalink.CallSiteDescriptor arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/dynalink/support/AbstractRelinkableCallSite;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljdk/dynalink/CallSiteDescriptor;", "public")]
	public Dova.JDK.jdk.dynalink.CallSiteDescriptor getDescriptor()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.CallSiteDescriptor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;)V", "public")]
	public void initialize(Dova.JDK.java.lang.invoke.MethodHandle arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}
}