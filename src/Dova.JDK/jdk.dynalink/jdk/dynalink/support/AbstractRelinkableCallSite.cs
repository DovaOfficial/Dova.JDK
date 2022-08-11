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
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/dynalink/support/AbstractRelinkableCallSite;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descriptor", "Ljdk/dynalink/CallSiteDescriptor;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/dynalink/CallSiteDescriptor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescriptor", "()Ljdk/dynalink/CallSiteDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Ljava/lang/invoke/MethodHandle;)V"));
	}

	[JniSignatureAttribute("Ljdk/dynalink/CallSiteDescriptor;", "private final")]
	public Dova.JDK.jdk.dynalink.CallSiteDescriptor descriptor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.CallSiteDescriptor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AbstractRelinkableCallSite(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/dynalink/CallSiteDescriptor;)V", "protected")]
	public AbstractRelinkableCallSite(Dova.JDK.jdk.dynalink.CallSiteDescriptor arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/dynalink/support/AbstractRelinkableCallSite;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljdk/dynalink/CallSiteDescriptor;", "public")]
	public Dova.JDK.jdk.dynalink.CallSiteDescriptor getDescriptor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.CallSiteDescriptor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;)V", "public")]
	public void initialize(Dova.JDK.java.lang.invoke.MethodHandle arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}
}
