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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/xs/IDDV;", "public")]
public partial class IDDV
	: Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.TypeValidator
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static IDDV()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/dv/xs/IDDV;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "IDDV", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAllowedFacets", "()S"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "checkExtraRules", "(Ljava/lang/Object;Lcom/sun/org/apache/xerces/internal/impl/dv/ValidationContext;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getActualValue", "(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/dv/ValidationContext;)Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public IDDV(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public IDDV() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/dv/xs/IDDV;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()S", "public")]
	public short getAllowedFacets()
	{
		var ret = DovaJvm.Vm.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Lcom/sun/org/apache/xerces/internal/impl/dv/ValidationContext;)V", "public")]
	public void checkExtraRules(Dova.JDK.java.lang.Object arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.ValidationContext arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/dv/ValidationContext;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getActualValue(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.ValidationContext arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}
}