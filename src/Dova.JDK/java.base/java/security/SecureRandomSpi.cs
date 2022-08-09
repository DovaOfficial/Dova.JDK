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

namespace Dova.JDK.java.security;

[JniSignatureAttribute("Ljava/security/SecureRandomSpi;", "public abstract")]
public partial class SecureRandomSpi
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SecureRandomSpi()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/security/SecureRandomSpi;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "SecureRandomSpi", "()V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "SecureRandomSpi", "(Ljava/security/SecureRandomParameters;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "engineSetSeed", "([B)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "engineGetParameters", "()Ljava/security/SecureRandomParameters;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "engineNextBytes", "([BLjava/security/SecureRandomParameters;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "engineNextBytes", "([B)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "engineGenerateSeed", "(I)[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "engineReseed", "(Ljava/security/SecureRandomParameters;)V"));
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SecureRandomSpi(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SecureRandomSpi() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljava/security/SecureRandomParameters;)V", "protected")]
	public SecureRandomSpi(Dova.JDK.java.security.SecureRandomParameters arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/security/SecureRandomSpi;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([B)V", "protected abstract")]
	public void engineSetSeed(JavaArray<byte> arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()Ljava/security/SecureRandomParameters;", "protected")]
	public Dova.JDK.java.security.SecureRandomParameters engineGetParameters()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.SecureRandomParameters>(ret);
	}

	[JniSignatureAttribute("([BLjava/security/SecureRandomParameters;)V", "protected")]
	public void engineNextBytes(JavaArray<byte> arg0, Dova.JDK.java.security.SecureRandomParameters arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("([B)V", "protected abstract")]
	public void engineNextBytes(JavaArray<byte> arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(I)[B", "protected abstract")]
	public JavaArray<byte> engineGenerateSeed(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/SecureRandomParameters;)V", "protected")]
	public void engineReseed(Dova.JDK.java.security.SecureRandomParameters arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}
}