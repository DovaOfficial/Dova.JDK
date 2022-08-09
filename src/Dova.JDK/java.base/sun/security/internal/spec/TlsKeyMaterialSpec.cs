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

namespace Dova.JDK.sun.security.@internal.spec;

[JniSignatureAttribute("Lsun/security/internal/spec/TlsKeyMaterialSpec;", "public")]
public partial class TlsKeyMaterialSpec
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.security.spec.KeySpec
	, Dova.JDK.javax.crypto.SecretKey
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TlsKeyMaterialSpec()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/internal/spec/TlsKeyMaterialSpec;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "clientMacKey", "Ljavax/crypto/SecretKey;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "serverMacKey", "Ljavax/crypto/SecretKey;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "clientCipherKey", "Ljavax/crypto/SecretKey;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "serverCipherKey", "Ljavax/crypto/SecretKey;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "clientIv", "Ljavax/crypto/spec/IvParameterSpec;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "serverIv", "Ljavax/crypto/spec/IvParameterSpec;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "TlsKeyMaterialSpec", "(Ljavax/crypto/SecretKey;Ljavax/crypto/SecretKey;Ljavax/crypto/SecretKey;Ljavax/crypto/spec/IvParameterSpec;Ljavax/crypto/SecretKey;Ljavax/crypto/spec/IvParameterSpec;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "TlsKeyMaterialSpec", "(Ljavax/crypto/SecretKey;Ljavax/crypto/SecretKey;Ljavax/crypto/SecretKey;Ljavax/crypto/SecretKey;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "TlsKeyMaterialSpec", "(Ljavax/crypto/SecretKey;Ljavax/crypto/SecretKey;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getEncoded", "()[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getFormat", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAlgorithm", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getClientMacKey", "()Ljavax/crypto/SecretKey;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getServerMacKey", "()Ljavax/crypto/SecretKey;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getClientCipherKey", "()Ljavax/crypto/SecretKey;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getClientIv", "()Ljavax/crypto/spec/IvParameterSpec;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getServerCipherKey", "()Ljavax/crypto/SecretKey;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getServerIv", "()Ljavax/crypto/spec/IvParameterSpec;"));
	}

	[JniSignatureAttribute("J", "static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("Ljavax/crypto/SecretKey;", "private final")]
	public Dova.JDK.javax.crypto.SecretKey clientMacKey_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/crypto/SecretKey;", "private final")]
	public Dova.JDK.javax.crypto.SecretKey serverMacKey_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/crypto/SecretKey;", "private final")]
	public Dova.JDK.javax.crypto.SecretKey clientCipherKey_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/crypto/SecretKey;", "private final")]
	public Dova.JDK.javax.crypto.SecretKey serverCipherKey_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/crypto/spec/IvParameterSpec;", "private final")]
	public Dova.JDK.javax.crypto.spec.IvParameterSpec clientIv_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.spec.IvParameterSpec>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/crypto/spec/IvParameterSpec;", "private final")]
	public Dova.JDK.javax.crypto.spec.IvParameterSpec serverIv_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.spec.IvParameterSpec>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TlsKeyMaterialSpec(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/crypto/SecretKey;Ljavax/crypto/SecretKey;Ljavax/crypto/SecretKey;Ljavax/crypto/spec/IvParameterSpec;Ljavax/crypto/SecretKey;Ljavax/crypto/spec/IvParameterSpec;)V", "public")]
	public TlsKeyMaterialSpec(Dova.JDK.javax.crypto.SecretKey arg0, Dova.JDK.javax.crypto.SecretKey arg1, Dova.JDK.javax.crypto.SecretKey arg2, Dova.JDK.javax.crypto.spec.IvParameterSpec arg3, Dova.JDK.javax.crypto.SecretKey arg4, Dova.JDK.javax.crypto.spec.IvParameterSpec arg5) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(Ljavax/crypto/SecretKey;Ljavax/crypto/SecretKey;Ljavax/crypto/SecretKey;Ljavax/crypto/SecretKey;)V", "public")]
	public TlsKeyMaterialSpec(Dova.JDK.javax.crypto.SecretKey arg0, Dova.JDK.javax.crypto.SecretKey arg1, Dova.JDK.javax.crypto.SecretKey arg2, Dova.JDK.javax.crypto.SecretKey arg3) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljavax/crypto/SecretKey;Ljavax/crypto/SecretKey;)V", "public")]
	public TlsKeyMaterialSpec(Dova.JDK.javax.crypto.SecretKey arg0, Dova.JDK.javax.crypto.SecretKey arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/internal/spec/TlsKeyMaterialSpec;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[B", "public")]
	public JavaArray<byte> getEncoded()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getFormat()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getAlgorithm()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljavax/crypto/SecretKey;", "public")]
	public Dova.JDK.javax.crypto.SecretKey getClientMacKey()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
	}

	[JniSignatureAttribute("()Ljavax/crypto/SecretKey;", "public")]
	public Dova.JDK.javax.crypto.SecretKey getServerMacKey()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
	}

	[JniSignatureAttribute("()Ljavax/crypto/SecretKey;", "public")]
	public Dova.JDK.javax.crypto.SecretKey getClientCipherKey()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
	}

	[JniSignatureAttribute("()Ljavax/crypto/spec/IvParameterSpec;", "public")]
	public Dova.JDK.javax.crypto.spec.IvParameterSpec getClientIv()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.spec.IvParameterSpec>(ret);
	}

	[JniSignatureAttribute("()Ljavax/crypto/SecretKey;", "public")]
	public Dova.JDK.javax.crypto.SecretKey getServerCipherKey()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
	}

	[JniSignatureAttribute("()Ljavax/crypto/spec/IvParameterSpec;", "public")]
	public Dova.JDK.javax.crypto.spec.IvParameterSpec getServerIv()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.spec.IvParameterSpec>(ret);
	}
}