/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.security.pkcs11.wrapper;

[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_TLS12_KEY_MAT_PARAMS;", "public")]
public partial class CK_TLS12_KEY_MAT_PARAMS
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CK_TLS12_KEY_MAT_PARAMS()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/pkcs11/wrapper/CK_TLS12_KEY_MAT_PARAMS;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ulMacSizeInBits", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ulKeySizeInBits", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ulIVSizeInBits", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bIsExport", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "RandomInfo", "Lsun/security/pkcs11/wrapper/CK_SSL3_RANDOM_DATA;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pReturnedKeyMaterial", "Lsun/security/pkcs11/wrapper/CK_SSL3_KEY_MAT_OUT;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prfHashMechanism", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IIIZLsun/security/pkcs11/wrapper/CK_SSL3_RANDOM_DATA;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("J", "public")]
	public long ulMacSizeInBits_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("J", "public")]
	public long ulKeySizeInBits_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("J", "public")]
	public long ulIVSizeInBits_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("Z", "public")]
	public bool bIsExport_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_SSL3_RANDOM_DATA;", "public")]
	public Dova.JDK.sun.security.pkcs11.wrapper.CK_SSL3_RANDOM_DATA RandomInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_SSL3_RANDOM_DATA>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_SSL3_KEY_MAT_OUT;", "public")]
	public Dova.JDK.sun.security.pkcs11.wrapper.CK_SSL3_KEY_MAT_OUT pReturnedKeyMaterial_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_SSL3_KEY_MAT_OUT>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "public")]
	public long prfHashMechanism_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CK_TLS12_KEY_MAT_PARAMS(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(IIIZLsun/security/pkcs11/wrapper/CK_SSL3_RANDOM_DATA;J)V", "public")]
	public CK_TLS12_KEY_MAT_PARAMS(int arg0, int arg1, int arg2, bool arg3, Dova.JDK.sun.security.pkcs11.wrapper.CK_SSL3_RANDOM_DATA arg4, long arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/pkcs11/wrapper/CK_TLS12_KEY_MAT_PARAMS;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
