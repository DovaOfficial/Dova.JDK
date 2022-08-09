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

namespace Dova.JDK.sun.security.krb5;

[JniSignatureAttribute("Lsun/security/krb5/KrbApReq;", "public")]
public partial class KrbApReq
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static KrbApReq()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/krb5/KrbApReq;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "obuf", "[B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "ctime", "Lsun/security/krb5/internal/KerberosTime;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "cusec", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "authenticator", "Lsun/security/krb5/internal/Authenticator;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "creds", "Lsun/security/krb5/Credentials;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "apReqMessg", "Lsun/security/krb5/internal/APReq;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "rcache", "Lsun/security/krb5/internal/ReplayCache;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DEBUG", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "hexConst", "[C"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "KrbApReq", "(Lsun/security/krb5/internal/APOptions;Lsun/security/krb5/internal/Ticket;Lsun/security/krb5/EncryptionKey;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/Checksum;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/EncryptionKey;Lsun/security/krb5/internal/SeqNumber;Lsun/security/krb5/internal/AuthorizationData;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "KrbApReq", "([BLsun/security/jgss/krb5/Krb5AcceptCredential;Ljava/net/InetAddress;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "KrbApReq", "(Lsun/security/krb5/Credentials;ZZZLsun/security/krb5/Checksum;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "decode", "(Lsun/security/util/DerValue;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "decode", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getMessage", "()[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "init", "(Lsun/security/krb5/internal/APOptions;Lsun/security/krb5/Credentials;Lsun/security/krb5/Checksum;Lsun/security/krb5/EncryptionKey;Lsun/security/krb5/internal/SeqNumber;Lsun/security/krb5/internal/AuthorizationData;I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "init", "(Lsun/security/krb5/internal/APOptions;Lsun/security/krb5/internal/Ticket;Lsun/security/krb5/EncryptionKey;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/Checksum;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/EncryptionKey;Lsun/security/krb5/internal/SeqNumber;Lsun/security/krb5/internal/AuthorizationData;I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getClient", "()Lsun/security/krb5/PrincipalName;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "authenticate", "(Lsun/security/jgss/krb5/Krb5AcceptCredential;Ljava/net/InetAddress;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCreds", "()Lsun/security/krb5/Credentials;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCtime", "()Lsun/security/krb5/internal/KerberosTime;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "cusec", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createMessage", "(Lsun/security/krb5/internal/APOptions;Lsun/security/krb5/internal/Ticket;Lsun/security/krb5/EncryptionKey;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/Checksum;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/EncryptionKey;Lsun/security/krb5/internal/SeqNumber;Lsun/security/krb5/internal/AuthorizationData;I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getSubKey", "()Lsun/security/krb5/EncryptionKey;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getSeqNumber", "()Ljava/lang/Integer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "checkPermittedEType", "(I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getChecksum", "()Lsun/security/krb5/Checksum;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAPOptions", "()Lsun/security/krb5/internal/APOptions;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getMutualAuthRequired", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "useSessionKey", "()Z"));
	}

	[JniSignatureAttribute("[B", "private")]
	public JavaArray<byte> obuf_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/KerberosTime;", "private")]
	public Dova.JDK.sun.security.krb5.@internal.KerberosTime ctime_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.KerberosTime>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int cusec_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/Authenticator;", "private")]
	public Dova.JDK.sun.security.krb5.@internal.Authenticator authenticator_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.Authenticator>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/krb5/Credentials;", "private")]
	public Dova.JDK.sun.security.krb5.Credentials creds_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.Credentials>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/APReq;", "private")]
	public Dova.JDK.sun.security.krb5.@internal.APReq apReqMessg_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.APReq>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/ReplayCache;", "private static")]
	public static Dova.JDK.sun.security.krb5.@internal.ReplayCache rcache_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ReplayCache>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private static")]
	public static bool DEBUG_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[7], value);
	}

	[JniSignatureAttribute("[C", "private static final")]
	public static JavaArray<char> hexConst_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public KrbApReq(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/krb5/internal/APOptions;Lsun/security/krb5/internal/Ticket;Lsun/security/krb5/EncryptionKey;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/Checksum;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/EncryptionKey;Lsun/security/krb5/internal/SeqNumber;Lsun/security/krb5/internal/AuthorizationData;)V", "")]
	public KrbApReq(Dova.JDK.sun.security.krb5.@internal.APOptions arg0, Dova.JDK.sun.security.krb5.@internal.Ticket arg1, Dova.JDK.sun.security.krb5.EncryptionKey arg2, Dova.JDK.sun.security.krb5.PrincipalName arg3, Dova.JDK.sun.security.krb5.Checksum arg4, Dova.JDK.sun.security.krb5.@internal.KerberosTime arg5, Dova.JDK.sun.security.krb5.EncryptionKey arg6, Dova.JDK.sun.security.krb5.@internal.SeqNumber arg7, Dova.JDK.sun.security.krb5.@internal.AuthorizationData arg8) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8))
	{
	}

	[JniSignatureAttribute("([BLsun/security/jgss/krb5/Krb5AcceptCredential;Ljava/net/InetAddress;)V", "public")]
	public KrbApReq(JavaArray<byte> arg0, Dova.JDK.sun.security.jgss.krb5.Krb5AcceptCredential arg1, Dova.JDK.java.net.InetAddress arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Lsun/security/krb5/Credentials;ZZZLsun/security/krb5/Checksum;)V", "public")]
	public KrbApReq(Dova.JDK.sun.security.krb5.Credentials arg0, bool arg1, bool arg2, bool arg3, Dova.JDK.sun.security.krb5.Checksum arg4) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/krb5/KrbApReq;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/security/util/DerValue;)V", "")]
	public void decode(Dova.JDK.sun.security.util.DerValue arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()V", "")]
	public void decode()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("()[B", "public")]
	public JavaArray<byte> getMessage()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/internal/APOptions;Lsun/security/krb5/Credentials;Lsun/security/krb5/Checksum;Lsun/security/krb5/EncryptionKey;Lsun/security/krb5/internal/SeqNumber;Lsun/security/krb5/internal/AuthorizationData;I)V", "private")]
	public void init(Dova.JDK.sun.security.krb5.@internal.APOptions arg0, Dova.JDK.sun.security.krb5.Credentials arg1, Dova.JDK.sun.security.krb5.Checksum arg2, Dova.JDK.sun.security.krb5.EncryptionKey arg3, Dova.JDK.sun.security.krb5.@internal.SeqNumber arg4, Dova.JDK.sun.security.krb5.@internal.AuthorizationData arg5, int arg6)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/internal/APOptions;Lsun/security/krb5/internal/Ticket;Lsun/security/krb5/EncryptionKey;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/Checksum;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/EncryptionKey;Lsun/security/krb5/internal/SeqNumber;Lsun/security/krb5/internal/AuthorizationData;I)V", "private")]
	public void init(Dova.JDK.sun.security.krb5.@internal.APOptions arg0, Dova.JDK.sun.security.krb5.@internal.Ticket arg1, Dova.JDK.sun.security.krb5.EncryptionKey arg2, Dova.JDK.sun.security.krb5.PrincipalName arg3, Dova.JDK.sun.security.krb5.Checksum arg4, Dova.JDK.sun.security.krb5.@internal.KerberosTime arg5, Dova.JDK.sun.security.krb5.EncryptionKey arg6, Dova.JDK.sun.security.krb5.@internal.SeqNumber arg7, Dova.JDK.sun.security.krb5.@internal.AuthorizationData arg8, int arg9)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/PrincipalName;", "public")]
	public Dova.JDK.sun.security.krb5.PrincipalName getClient()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.PrincipalName>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/jgss/krb5/Krb5AcceptCredential;Ljava/net/InetAddress;)V", "private")]
	public void authenticate(Dova.JDK.sun.security.jgss.krb5.Krb5AcceptCredential arg0, Dova.JDK.java.net.InetAddress arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/Credentials;", "public")]
	public Dova.JDK.sun.security.krb5.Credentials getCreds()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.Credentials>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/internal/KerberosTime;", "")]
	public Dova.JDK.sun.security.krb5.@internal.KerberosTime getCtime()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.KerberosTime>(ret);
	}

	[JniSignatureAttribute("()I", "")]
	public int cusec()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/security/krb5/internal/APOptions;Lsun/security/krb5/internal/Ticket;Lsun/security/krb5/EncryptionKey;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/Checksum;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/EncryptionKey;Lsun/security/krb5/internal/SeqNumber;Lsun/security/krb5/internal/AuthorizationData;I)V", "private")]
	public void createMessage(Dova.JDK.sun.security.krb5.@internal.APOptions arg0, Dova.JDK.sun.security.krb5.@internal.Ticket arg1, Dova.JDK.sun.security.krb5.EncryptionKey arg2, Dova.JDK.sun.security.krb5.PrincipalName arg3, Dova.JDK.sun.security.krb5.Checksum arg4, Dova.JDK.sun.security.krb5.@internal.KerberosTime arg5, Dova.JDK.sun.security.krb5.EncryptionKey arg6, Dova.JDK.sun.security.krb5.@internal.SeqNumber arg7, Dova.JDK.sun.security.krb5.@internal.AuthorizationData arg8, int arg9)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/EncryptionKey;", "public")]
	public Dova.JDK.sun.security.krb5.EncryptionKey getSubKey()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.EncryptionKey>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Integer;", "public")]
	public Dova.JDK.java.lang.Integer getSeqNumber()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
	}

	[JniSignatureAttribute("(I)V", "private static")]
	public static void checkPermittedEType(int arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/Checksum;", "public")]
	public Dova.JDK.sun.security.krb5.Checksum getChecksum()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.Checksum>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/internal/APOptions;", "")]
	public Dova.JDK.sun.security.krb5.@internal.APOptions getAPOptions()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.APOptions>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getMutualAuthRequired()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "")]
	public bool useSessionKey()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17]);
		return ret;
	}
}