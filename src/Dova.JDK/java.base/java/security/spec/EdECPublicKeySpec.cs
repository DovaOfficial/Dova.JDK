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

namespace Dova.JDK.java.security.spec;

[JniSignatureAttribute("Ljava/security/spec/EdECPublicKeySpec;", "public final")]
public partial class EdECPublicKeySpec
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.security.spec.KeySpec
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static EdECPublicKeySpec()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/security/spec/EdECPublicKeySpec;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "params", "Ljava/security/spec/NamedParameterSpec;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "point", "Ljava/security/spec/EdECPoint;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "EdECPublicKeySpec", "(Ljava/security/spec/NamedParameterSpec;Ljava/security/spec/EdECPoint;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getParams", "()Ljava/security/spec/NamedParameterSpec;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getPoint", "()Ljava/security/spec/EdECPoint;"));
	}

	[JniSignatureAttribute("Ljava/security/spec/NamedParameterSpec;", "private final")]
	public Dova.JDK.java.security.spec.NamedParameterSpec @params_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.NamedParameterSpec>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/security/spec/EdECPoint;", "private final")]
	public Dova.JDK.java.security.spec.EdECPoint point_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.EdECPoint>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public EdECPublicKeySpec(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/security/spec/NamedParameterSpec;Ljava/security/spec/EdECPoint;)V", "public")]
	public EdECPublicKeySpec(Dova.JDK.java.security.spec.NamedParameterSpec arg0, Dova.JDK.java.security.spec.EdECPoint arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/security/spec/EdECPublicKeySpec;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/security/spec/NamedParameterSpec;", "public")]
	public Dova.JDK.java.security.spec.NamedParameterSpec getParams()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.NamedParameterSpec>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/spec/EdECPoint;", "public")]
	public Dova.JDK.java.security.spec.EdECPoint getPoint()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.EdECPoint>(ret);
	}
}
