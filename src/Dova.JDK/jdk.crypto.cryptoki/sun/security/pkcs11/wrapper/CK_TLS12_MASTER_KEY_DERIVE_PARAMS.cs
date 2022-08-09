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

namespace Dova.JDK.sun.security.pkcs11.wrapper;

[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_TLS12_MASTER_KEY_DERIVE_PARAMS;", "public")]
public partial class CK_TLS12_MASTER_KEY_DERIVE_PARAMS
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CK_TLS12_MASTER_KEY_DERIVE_PARAMS()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/pkcs11/wrapper/CK_TLS12_MASTER_KEY_DERIVE_PARAMS;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "RandomInfo", "Lsun/security/pkcs11/wrapper/CK_SSL3_RANDOM_DATA;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "pVersion", "Lsun/security/pkcs11/wrapper/CK_VERSION;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "prfHashMechanism", "J"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CK_TLS12_MASTER_KEY_DERIVE_PARAMS", "(Lsun/security/pkcs11/wrapper/CK_SSL3_RANDOM_DATA;Lsun/security/pkcs11/wrapper/CK_VERSION;J)V"));
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_SSL3_RANDOM_DATA;", "public")]
	public Dova.JDK.sun.security.pkcs11.wrapper.CK_SSL3_RANDOM_DATA RandomInfo_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_SSL3_RANDOM_DATA>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_VERSION;", "public")]
	public Dova.JDK.sun.security.pkcs11.wrapper.CK_VERSION pVersion_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_VERSION>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("J", "public")]
	public long prfHashMechanism_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CK_TLS12_MASTER_KEY_DERIVE_PARAMS(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/wrapper/CK_SSL3_RANDOM_DATA;Lsun/security/pkcs11/wrapper/CK_VERSION;J)V", "public")]
	public CK_TLS12_MASTER_KEY_DERIVE_PARAMS(Dova.JDK.sun.security.pkcs11.wrapper.CK_SSL3_RANDOM_DATA arg0, Dova.JDK.sun.security.pkcs11.wrapper.CK_VERSION arg1, long arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/pkcs11/wrapper/CK_TLS12_MASTER_KEY_DERIVE_PARAMS;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
}