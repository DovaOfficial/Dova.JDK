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

namespace Dova.JDK.javax.net.ssl;

[JniSignatureAttribute("Ljavax/net/ssl/KeyManagerFactorySpi;", "public abstract")]
public partial class KeyManagerFactorySpi
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static KeyManagerFactorySpi()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/net/ssl/KeyManagerFactorySpi;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "KeyManagerFactorySpi", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "engineGetKeyManagers", "()[Ljavax/net/ssl/KeyManager;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "engineInit", "(Ljava/security/KeyStore;[C)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "engineInit", "(Ljavax/net/ssl/ManagerFactoryParameters;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public KeyManagerFactorySpi(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public KeyManagerFactorySpi() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/net/ssl/KeyManagerFactorySpi;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Ljavax/net/ssl/KeyManager;", "protected abstract")]
	public JavaArray<Dova.JDK.javax.net.ssl.KeyManager> engineGetKeyManagers()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.net.ssl.KeyManager>>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/KeyStore;[C)V", "protected abstract")]
	public void engineInit(Dova.JDK.java.security.KeyStore arg0, JavaArray<char> arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/ManagerFactoryParameters;)V", "protected abstract")]
	public void engineInit(Dova.JDK.javax.net.ssl.ManagerFactoryParameters arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}
}