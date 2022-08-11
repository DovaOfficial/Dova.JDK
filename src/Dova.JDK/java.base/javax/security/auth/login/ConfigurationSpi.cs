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

namespace Dova.JDK.javax.security.auth.login;

[JniSignatureAttribute("Ljavax/security/auth/login/ConfigurationSpi;", "public abstract")]
public partial class ConfigurationSpi
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ConfigurationSpi()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/security/auth/login/ConfigurationSpi;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetAppConfigurationEntry", "(Ljava/lang/String;)[Ljavax/security/auth/login/AppConfigurationEntry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineRefresh", "()V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ConfigurationSpi(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ConfigurationSpi() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/security/auth/login/ConfigurationSpi;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)[Ljavax/security/auth/login/AppConfigurationEntry;", "protected abstract")]
	public JavaArray<Dova.JDK.javax.security.auth.login.AppConfigurationEntry> engineGetAppConfigurationEntry(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.security.auth.login.AppConfigurationEntry>>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void engineRefresh()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}
}
