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

namespace Dova.JDK.sun.security.ssl;

[JniSignatureAttribute("Lsun/security/ssl/ServerHandshakeContext;", "")]
public partial class ServerHandshakeContext
	: Dova.JDK.sun.security.ssl.HandshakeContext
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ServerHandshakeContext()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/ServerHandshakeContext;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "rejectClientInitiatedRenego", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "legacyAlgorithmConstraints", "Ljava/security/AlgorithmConstraints;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interimAuthn", "Lsun/security/ssl/SSLPossession;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stapleParams", "Lsun/security/ssl/StatusResponseManager$StaplingParameters;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentCertEntry", "Lsun/security/ssl/CertificateMessage$CertificateEntry;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_STATUS_RESP_DELAY", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "statusRespTimeout", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/SSLContextImpl;Lsun/security/ssl/TransportContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "kickstart", "()V"));
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool rejectClientInitiatedRenego_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Ljava/security/AlgorithmConstraints;", "static final")]
	public static Dova.JDK.java.security.AlgorithmConstraints legacyAlgorithmConstraints_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.AlgorithmConstraints>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLPossession;", "")]
	public Dova.JDK.sun.security.ssl.SSLPossession interimAuthn_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLPossession>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/StatusResponseManager$StaplingParameters;", "")]
	public Dova.JDK.sun.security.ssl.StatusResponseManager.StaplingParameters stapleParams_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.StatusResponseManager.StaplingParameters>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CertificateMessage$CertificateEntry;", "")]
	public Dova.JDK.sun.security.ssl.CertificateMessage.CertificateEntry currentCertEntry_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CertificateMessage.CertificateEntry>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long DEFAULT_STATUS_RESP_DELAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("J", "final")]
	public long statusRespTimeout_Property
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
	public ServerHandshakeContext(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/ssl/SSLContextImpl;Lsun/security/ssl/TransportContext;)V", "")]
	public ServerHandshakeContext(Dova.JDK.sun.security.ssl.SSLContextImpl arg0, Dova.JDK.sun.security.ssl.TransportContext arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/ServerHandshakeContext;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "")]
	public void kickstart()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}
}
