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

namespace Dova.JDK.javax.net.ssl;

[JniSignatureAttribute("Ljavax/net/ssl/TrustManagerFactorySpi;", "public abstract")]
public partial class TrustManagerFactorySpi
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TrustManagerFactorySpi()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/net/ssl/TrustManagerFactorySpi;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetTrustManagers", "()[Ljavax/net/ssl/TrustManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineInit", "(Ljava/security/KeyStore;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineInit", "(Ljavax/net/ssl/ManagerFactoryParameters;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TrustManagerFactorySpi(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public TrustManagerFactorySpi() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/net/ssl/TrustManagerFactorySpi;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Ljavax/net/ssl/TrustManager;", "protected abstract")]
	public JavaArray<Dova.JDK.javax.net.ssl.TrustManager> engineGetTrustManagers()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.net.ssl.TrustManager>>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/KeyStore;)V", "protected abstract")]
	public void engineInit(Dova.JDK.java.security.KeyStore arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/ManagerFactoryParameters;)V", "protected abstract")]
	public void engineInit(Dova.JDK.javax.net.ssl.ManagerFactoryParameters arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}
}
