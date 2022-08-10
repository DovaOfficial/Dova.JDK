/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
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

[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_GCM_PARAMS;", "public")]
public partial class CK_GCM_PARAMS
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CK_GCM_PARAMS()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/pkcs11/wrapper/CK_GCM_PARAMS;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "iv", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "aad", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "tagBits", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CK_GCM_PARAMS", "(I[B[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("[B", "private final")]
	public JavaArray<byte> iv_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[B", "private final")]
	public JavaArray<byte> aad_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("J", "private final")]
	public long tagBits_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CK_GCM_PARAMS(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(I[B[B)V", "public")]
	public CK_GCM_PARAMS(int arg0, JavaArray<byte> arg1, JavaArray<byte> arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/pkcs11/wrapper/CK_GCM_PARAMS;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
