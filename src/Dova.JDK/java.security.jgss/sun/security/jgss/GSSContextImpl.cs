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

namespace Dova.JDK.sun.security.jgss;

[JniSignatureAttribute("Lsun/security/jgss/GSSContextImpl;", "public")]
public partial class GSSContextImpl
	: Dova.JDK.java.lang.Object
	, Dova.JDK.org.ietf.jgss.GSSContext
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GSSContextImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/jgss/GSSContextImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "gssManager", "Lsun/security/jgss/GSSManagerImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "initiator", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRE_INIT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IN_PROGRESS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "READY", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DELETED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentState", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mechCtxt", "Lsun/security/jgss/spi/GSSContextSpi;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mechOid", "Lorg/ietf/jgss/Oid;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "objId", "Lsun/security/util/ObjectIdentifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "myCred", "Lsun/security/jgss/GSSCredentialImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "srcName", "Lsun/security/jgss/GSSNameImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targName", "Lsun/security/jgss/GSSNameImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reqLifetime", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "channelBindings", "Lorg/ietf/jgss/ChannelBinding;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reqConfState", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reqIntegState", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reqMutualAuthState", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reqReplayDetState", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reqSequenceDetState", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reqCredDelegState", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reqAnonState", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reqDelegPolicyState", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/jgss/GSSManagerImpl;[B)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/jgss/GSSManagerImpl;Lorg/ietf/jgss/GSSCredential;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/jgss/GSSManagerImpl;Lorg/ietf/jgss/GSSName;Lorg/ietf/jgss/Oid;Lorg/ietf/jgss/GSSCredential;I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/jgss/GSSContextImpl;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "([BIILorg/ietf/jgss/MessageProp;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Ljava/io/InputStream;Ljava/io/OutputStream;Lorg/ietf/jgss/MessageProp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unwrap", "(Ljava/io/InputStream;Ljava/io/OutputStream;Lorg/ietf/jgss/MessageProp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unwrap", "([BIILorg/ietf/jgss/MessageProp;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "export", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inquireSecContext", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestCredDeleg", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestSequenceDet", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestMutualAuth", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setChannelBinding", "(Lorg/ietf/jgss/ChannelBinding;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestConf", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestInteg", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initSecContext", "(Ljava/io/InputStream;Ljava/io/OutputStream;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initSecContext", "([BII)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEstablished", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWrapSizeLimit", "(IZI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptSecContext", "([BII)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptSecContext", "(Ljava/io/InputStream;Ljava/io/OutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSrcName", "()Lorg/ietf/jgss/GSSName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTargName", "()Lorg/ietf/jgss/GSSName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSequenceDetState", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMIC", "([BIILorg/ietf/jgss/MessageProp;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMIC", "(Ljava/io/InputStream;Ljava/io/OutputStream;Lorg/ietf/jgss/MessageProp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "verifyMIC", "([BII[BIILorg/ietf/jgss/MessageProp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "verifyMIC", "(Ljava/io/InputStream;Ljava/io/InputStream;Lorg/ietf/jgss/MessageProp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestReplayDet", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestAnonymity", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestLifetime", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCredDelegState", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMutualAuthState", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReplayDetState", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnonymityState", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTransferable", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isProtReady", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConfState", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIntegState", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLifetime", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMech", "()Lorg/ietf/jgss/Oid;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDelegCred", "()Lorg/ietf/jgss/GSSCredential;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInitiator", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDelegPolicyState", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestDelegPolicy", "(Z)V"));
	}

	[JniSignatureAttribute("Lsun/security/jgss/GSSManagerImpl;", "private")]
	public Dova.JDK.sun.security.jgss.GSSManagerImpl gssManager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.GSSManagerImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool initiator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int PRE_INIT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int IN_PROGRESS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int READY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DELETED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int currentState_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("Lsun/security/jgss/spi/GSSContextSpi;", "private")]
	public Dova.JDK.sun.security.jgss.spi.GSSContextSpi mechCtxt_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.spi.GSSContextSpi>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lorg/ietf/jgss/Oid;", "private")]
	public Dova.JDK.org.ietf.jgss.Oid mechOid_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.Oid>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/util/ObjectIdentifier;", "private")]
	public Dova.JDK.sun.security.util.ObjectIdentifier objId_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.ObjectIdentifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/jgss/GSSCredentialImpl;", "private")]
	public Dova.JDK.sun.security.jgss.GSSCredentialImpl myCred_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.GSSCredentialImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/jgss/GSSNameImpl;", "private")]
	public Dova.JDK.sun.security.jgss.GSSNameImpl srcName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.GSSNameImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/jgss/GSSNameImpl;", "private")]
	public Dova.JDK.sun.security.jgss.GSSNameImpl targName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.GSSNameImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int reqLifetime_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("Lorg/ietf/jgss/ChannelBinding;", "private")]
	public Dova.JDK.org.ietf.jgss.ChannelBinding channelBindings_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.ChannelBinding>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool reqConfState_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool reqIntegState_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool reqMutualAuthState_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool reqReplayDetState_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool reqSequenceDetState_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool reqCredDelegState_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool reqAnonState_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool reqDelegPolicyState_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public GSSContextImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/jgss/GSSManagerImpl;[B)V", "public")]
	public GSSContextImpl(Dova.JDK.sun.security.jgss.GSSManagerImpl arg0, JavaArray<byte> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lsun/security/jgss/GSSManagerImpl;Lorg/ietf/jgss/GSSCredential;)V", "public")]
	public GSSContextImpl(Dova.JDK.sun.security.jgss.GSSManagerImpl arg0, Dova.JDK.org.ietf.jgss.GSSCredential arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lsun/security/jgss/GSSManagerImpl;Lorg/ietf/jgss/GSSName;Lorg/ietf/jgss/Oid;Lorg/ietf/jgss/GSSCredential;I)V", "public")]
	public GSSContextImpl(Dova.JDK.sun.security.jgss.GSSManagerImpl arg0, Dova.JDK.org.ietf.jgss.GSSName arg1, Dova.JDK.org.ietf.jgss.Oid arg2, Dova.JDK.org.ietf.jgss.GSSCredential arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(Lsun/security/jgss/GSSContextImpl;)V", "protected")]
	public GSSContextImpl(Dova.JDK.sun.security.jgss.GSSContextImpl arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public GSSContextImpl() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/jgss/GSSContextImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([BIILorg/ietf/jgss/MessageProp;)[B", "public")]
	public JavaArray<byte> wrap(JavaArray<byte> arg0, int arg1, int arg2, Dova.JDK.org.ietf.jgss.MessageProp arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/io/OutputStream;Lorg/ietf/jgss/MessageProp;)V", "public")]
	public void wrap(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.io.OutputStream arg1, Dova.JDK.org.ietf.jgss.MessageProp arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/io/OutputStream;Lorg/ietf/jgss/MessageProp;)V", "public")]
	public void unwrap(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.io.OutputStream arg1, Dova.JDK.org.ietf.jgss.MessageProp arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([BIILorg/ietf/jgss/MessageProp;)[B", "public")]
	public JavaArray<byte> unwrap(JavaArray<byte> arg0, int arg1, int arg2, Dova.JDK.org.ietf.jgss.MessageProp arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()[B", "public")]
	public JavaArray<byte> export()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void dispose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object inquireSecContext(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void requestCredDeleg(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void requestSequenceDet(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void requestMutualAuth(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Lorg/ietf/jgss/ChannelBinding;)V", "public")]
	public void setChannelBinding(Dova.JDK.org.ietf.jgss.ChannelBinding arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void requestConf(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void requestInteg(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/io/OutputStream;)I", "public")]
	public int initSecContext(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.io.OutputStream arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([BII)[B", "public")]
	public JavaArray<byte> initSecContext(JavaArray<byte> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isEstablished()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("(IZI)I", "public")]
	public int getWrapSizeLimit(int arg0, bool arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("([BII)[B", "public")]
	public JavaArray<byte> acceptSecContext(JavaArray<byte> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/io/OutputStream;)V", "public")]
	public void acceptSecContext(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.io.OutputStream arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
	}

	[JniSignatureAttribute("()Lorg/ietf/jgss/GSSName;", "public")]
	public Dova.JDK.org.ietf.jgss.GSSName getSrcName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.GSSName>(ret);
	}

	[JniSignatureAttribute("()Lorg/ietf/jgss/GSSName;", "public")]
	public Dova.JDK.org.ietf.jgss.GSSName getTargName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.GSSName>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getSequenceDetState()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("([BIILorg/ietf/jgss/MessageProp;)[B", "public")]
	public JavaArray<byte> getMIC(JavaArray<byte> arg0, int arg1, int arg2, Dova.JDK.org.ietf.jgss.MessageProp arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/io/OutputStream;Lorg/ietf/jgss/MessageProp;)V", "public")]
	public void getMIC(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.io.OutputStream arg1, Dova.JDK.org.ietf.jgss.MessageProp arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([BII[BIILorg/ietf/jgss/MessageProp;)V", "public")]
	public void verifyMIC(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4, int arg5, Dova.JDK.org.ietf.jgss.MessageProp arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/io/InputStream;Lorg/ietf/jgss/MessageProp;)V", "public")]
	public void verifyMIC(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.io.InputStream arg1, Dova.JDK.org.ietf.jgss.MessageProp arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void requestReplayDet(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void requestAnonymity(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void requestLifetime(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getCredDelegState()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[29]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getMutualAuthState()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[30]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getReplayDetState()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[31]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getAnonymityState()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[32]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isTransferable()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[33]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isProtReady()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[34]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getConfState()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[35]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getIntegState()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[36]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getLifetime()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[37]);
		return ret;
	}

	[JniSignatureAttribute("()Lorg/ietf/jgss/Oid;", "public")]
	public Dova.JDK.org.ietf.jgss.Oid getMech()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.Oid>(ret);
	}

	[JniSignatureAttribute("()Lorg/ietf/jgss/GSSCredential;", "public")]
	public Dova.JDK.org.ietf.jgss.GSSCredential getDelegCred()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.GSSCredential>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isInitiator()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[40]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getDelegPolicyState()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[41]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void requestDelegPolicy(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
	}
}
