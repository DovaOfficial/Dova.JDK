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

namespace Dova.JDK.sun.security.jgss.wrapper;

[JniSignatureAttribute("Lsun/security/jgss/wrapper/NativeGSSFactory;", "public final")]
public partial class NativeGSSFactory
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.security.jgss.spi.MechanismFactory
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NativeGSSFactory()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/jgss/wrapper/NativeGSSFactory;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "cStub", "Lsun/security/jgss/wrapper/GSSLibStub;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "caller", "Lsun/security/jgss/GSSCaller;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "NativeGSSFactory", "(Lsun/security/jgss/GSSCaller;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getProvider", "()Ljava/security/Provider;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setMech", "(Lorg/ietf/jgss/Oid;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getMechanismOid", "()Lorg/ietf/jgss/Oid;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCredFromSubject", "(Lsun/security/jgss/wrapper/GSSNameElement;Z)Lsun/security/jgss/wrapper/GSSCredElement;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCredentialElement", "(Lsun/security/jgss/spi/GSSNameSpi;III)Lsun/security/jgss/spi/GSSCredentialSpi;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getNameTypes", "()[Lorg/ietf/jgss/Oid;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getNameElement", "([BLorg/ietf/jgss/Oid;)Lsun/security/jgss/spi/GSSNameSpi;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getNameElement", "(Ljava/lang/String;Lorg/ietf/jgss/Oid;)Lsun/security/jgss/spi/GSSNameSpi;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getMechanismContext", "(Lsun/security/jgss/spi/GSSNameSpi;Lsun/security/jgss/spi/GSSCredentialSpi;I)Lsun/security/jgss/spi/GSSContextSpi;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getMechanismContext", "(Lsun/security/jgss/spi/GSSCredentialSpi;)Lsun/security/jgss/spi/GSSContextSpi;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getMechanismContext", "([B)Lsun/security/jgss/spi/GSSContextSpi;"));
	}

	[JniSignatureAttribute("Lsun/security/jgss/wrapper/GSSLibStub;", "")]
	public Dova.JDK.sun.security.jgss.wrapper.GSSLibStub cStub_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.wrapper.GSSLibStub>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/jgss/GSSCaller;", "private final")]
	public Dova.JDK.sun.security.jgss.GSSCaller caller_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.GSSCaller>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public NativeGSSFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/jgss/GSSCaller;)V", "public")]
	public NativeGSSFactory(Dova.JDK.sun.security.jgss.GSSCaller arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/jgss/wrapper/NativeGSSFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/security/Provider;", "public")]
	public Dova.JDK.java.security.Provider getProvider()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.Provider>(ret);
	}

	[JniSignatureAttribute("(Lorg/ietf/jgss/Oid;)V", "public")]
	public void setMech(Dova.JDK.org.ietf.jgss.Oid arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()Lorg/ietf/jgss/Oid;", "public final")]
	public Dova.JDK.org.ietf.jgss.Oid getMechanismOid()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.Oid>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/jgss/wrapper/GSSNameElement;Z)Lsun/security/jgss/wrapper/GSSCredElement;", "private")]
	public Dova.JDK.sun.security.jgss.wrapper.GSSCredElement getCredFromSubject(Dova.JDK.sun.security.jgss.wrapper.GSSNameElement arg0, bool arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.wrapper.GSSCredElement>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/jgss/spi/GSSNameSpi;III)Lsun/security/jgss/spi/GSSCredentialSpi;", "public")]
	public Dova.JDK.sun.security.jgss.spi.GSSCredentialSpi getCredentialElement(Dova.JDK.sun.security.jgss.spi.GSSNameSpi arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.spi.GSSCredentialSpi>(ret);
	}

	[JniSignatureAttribute("()[Lorg/ietf/jgss/Oid;", "public")]
	public JavaArray<Dova.JDK.org.ietf.jgss.Oid> getNameTypes()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.org.ietf.jgss.Oid>>(ret);
	}

	[JniSignatureAttribute("([BLorg/ietf/jgss/Oid;)Lsun/security/jgss/spi/GSSNameSpi;", "public")]
	public Dova.JDK.sun.security.jgss.spi.GSSNameSpi getNameElement(JavaArray<byte> arg0, Dova.JDK.org.ietf.jgss.Oid arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.spi.GSSNameSpi>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lorg/ietf/jgss/Oid;)Lsun/security/jgss/spi/GSSNameSpi;", "public")]
	public Dova.JDK.sun.security.jgss.spi.GSSNameSpi getNameElement(Dova.JDK.java.lang.String arg0, Dova.JDK.org.ietf.jgss.Oid arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.spi.GSSNameSpi>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/jgss/spi/GSSNameSpi;Lsun/security/jgss/spi/GSSCredentialSpi;I)Lsun/security/jgss/spi/GSSContextSpi;", "public")]
	public Dova.JDK.sun.security.jgss.spi.GSSContextSpi getMechanismContext(Dova.JDK.sun.security.jgss.spi.GSSNameSpi arg0, Dova.JDK.sun.security.jgss.spi.GSSCredentialSpi arg1, int arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.spi.GSSContextSpi>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/jgss/spi/GSSCredentialSpi;)Lsun/security/jgss/spi/GSSContextSpi;", "public")]
	public Dova.JDK.sun.security.jgss.spi.GSSContextSpi getMechanismContext(Dova.JDK.sun.security.jgss.spi.GSSCredentialSpi arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.spi.GSSContextSpi>(ret);
	}

	[JniSignatureAttribute("([B)Lsun/security/jgss/spi/GSSContextSpi;", "public")]
	public Dova.JDK.sun.security.jgss.spi.GSSContextSpi getMechanismContext(JavaArray<byte> arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.spi.GSSContextSpi>(ret);
	}
}
