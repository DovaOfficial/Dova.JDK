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

namespace Dova.JDK.sun.net.www.protocol.http.ntlm;

[JniSignatureAttribute("Lsun/net/www/protocol/http/ntlm/NTLMAuthenticationCallback;", "public abstract")]
public partial class NTLMAuthenticationCallback
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NTLMAuthenticationCallback()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/net/www/protocol/http/ntlm/NTLMAuthenticationCallback;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "callback", "Lsun/net/www/protocol/http/ntlm/NTLMAuthenticationCallback;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "NTLMAuthenticationCallback", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setNTLMAuthenticationCallback", "(Lsun/net/www/protocol/http/ntlm/NTLMAuthenticationCallback;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getNTLMAuthenticationCallback", "()Lsun/net/www/protocol/http/ntlm/NTLMAuthenticationCallback;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isTrustedSite", "(Ljava/net/URL;)Z"));
	}

	[JniSignatureAttribute("Lsun/net/www/protocol/http/ntlm/NTLMAuthenticationCallback;", "private static volatile")]
	public static Dova.JDK.sun.net.www.protocol.http.ntlm.NTLMAuthenticationCallback callback_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.protocol.http.ntlm.NTLMAuthenticationCallback>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public NTLMAuthenticationCallback(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public NTLMAuthenticationCallback() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/net/www/protocol/http/ntlm/NTLMAuthenticationCallback;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/net/www/protocol/http/ntlm/NTLMAuthenticationCallback;)V", "public static")]
	public static void setNTLMAuthenticationCallback(Dova.JDK.sun.net.www.protocol.http.ntlm.NTLMAuthenticationCallback arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()Lsun/net/www/protocol/http/ntlm/NTLMAuthenticationCallback;", "public static")]
	public static Dova.JDK.sun.net.www.protocol.http.ntlm.NTLMAuthenticationCallback getNTLMAuthenticationCallback()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.protocol.http.ntlm.NTLMAuthenticationCallback>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;)Z", "public abstract")]
	public bool isTrustedSite(Dova.JDK.java.net.URL arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}
}
