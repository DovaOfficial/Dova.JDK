/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
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

[JniSignatureAttribute("Lsun/security/jgss/GSSManagerImpl;", "public")]
public partial class GSSManagerImpl
	: Dova.JDK.org.ietf.jgss.GSSManager
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GSSManagerImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/jgss/GSSManagerImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "USE_NATIVE", "Ljava/lang/Boolean;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "list", "Lsun/security/jgss/ProviderList;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "GSSManagerImpl", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "GSSManagerImpl", "(Lsun/security/jgss/GSSCaller;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "GSSManagerImpl", "(Lsun/security/jgss/GSSCaller;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "wrap", "(Lsun/security/jgss/GSSCredentialImpl;)Lorg/ietf/jgss/GSSCredential;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "wrap", "(Lsun/security/jgss/GSSContextImpl;)Lorg/ietf/jgss/GSSContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addProviderAtEnd", "(Ljava/security/Provider;Lorg/ietf/jgss/Oid;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addProviderAtFront", "(Ljava/security/Provider;Lorg/ietf/jgss/Oid;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getNameElement", "([BLorg/ietf/jgss/Oid;Lorg/ietf/jgss/Oid;)Lsun/security/jgss/spi/GSSNameSpi;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getNameElement", "(Ljava/lang/String;Lorg/ietf/jgss/Oid;Lorg/ietf/jgss/Oid;)Lsun/security/jgss/spi/GSSNameSpi;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMechsForName", "(Lorg/ietf/jgss/Oid;)[Lorg/ietf/jgss/Oid;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getNamesForMech", "(Lorg/ietf/jgss/Oid;)[Lorg/ietf/jgss/Oid;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCredentialElement", "(Lsun/security/jgss/spi/GSSNameSpi;IILorg/ietf/jgss/Oid;I)Lsun/security/jgss/spi/GSSCredentialSpi;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createName", "([BLorg/ietf/jgss/Oid;)Lorg/ietf/jgss/GSSName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createName", "(Ljava/lang/String;Lorg/ietf/jgss/Oid;)Lorg/ietf/jgss/GSSName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createName", "([BLorg/ietf/jgss/Oid;Lorg/ietf/jgss/Oid;)Lorg/ietf/jgss/GSSName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createName", "(Ljava/lang/String;Lorg/ietf/jgss/Oid;Lorg/ietf/jgss/Oid;)Lorg/ietf/jgss/GSSName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createCredential", "(Lorg/ietf/jgss/GSSName;I[Lorg/ietf/jgss/Oid;I)Lorg/ietf/jgss/GSSCredential;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createCredential", "(Lorg/ietf/jgss/GSSName;ILorg/ietf/jgss/Oid;I)Lorg/ietf/jgss/GSSCredential;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createCredential", "(I)Lorg/ietf/jgss/GSSCredential;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createContext", "(Lorg/ietf/jgss/GSSName;Lorg/ietf/jgss/Oid;Lorg/ietf/jgss/GSSCredential;I)Lorg/ietf/jgss/GSSContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createContext", "([B)Lorg/ietf/jgss/GSSContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createContext", "(Lorg/ietf/jgss/GSSCredential;)Lorg/ietf/jgss/GSSContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMechanismContext", "(Lsun/security/jgss/spi/GSSNameSpi;Lsun/security/jgss/spi/GSSCredentialSpi;ILorg/ietf/jgss/Oid;)Lsun/security/jgss/spi/GSSContextSpi;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMechanismContext", "([B)Lsun/security/jgss/spi/GSSContextSpi;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMechanismContext", "(Lsun/security/jgss/spi/GSSCredentialSpi;Lorg/ietf/jgss/Oid;)Lsun/security/jgss/spi/GSSContextSpi;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMechs", "()[Lorg/ietf/jgss/Oid;"));
	}

	[JniSignatureAttribute("Ljava/lang/Boolean;", "private static final")]
	public static Dova.JDK.java.lang.Boolean USE_NATIVE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/jgss/ProviderList;", "private")]
	public Dova.JDK.sun.security.jgss.ProviderList list_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.ProviderList>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public GSSManagerImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public GSSManagerImpl() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Lsun/security/jgss/GSSCaller;)V", "public")]
	public GSSManagerImpl(Dova.JDK.sun.security.jgss.GSSCaller arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("(Lsun/security/jgss/GSSCaller;Z)V", "public")]
	public GSSManagerImpl(Dova.JDK.sun.security.jgss.GSSCaller arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/jgss/GSSManagerImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/security/jgss/GSSCredentialImpl;)Lorg/ietf/jgss/GSSCredential;", "static")]
	public static Dova.JDK.org.ietf.jgss.GSSCredential wrap(Dova.JDK.sun.security.jgss.GSSCredentialImpl arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.GSSCredential>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/jgss/GSSContextImpl;)Lorg/ietf/jgss/GSSContext;", "static")]
	public static Dova.JDK.org.ietf.jgss.GSSContext wrap(Dova.JDK.sun.security.jgss.GSSContextImpl arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.GSSContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/Provider;Lorg/ietf/jgss/Oid;)V", "public")]
	public void addProviderAtEnd(Dova.JDK.java.security.Provider arg0, Dova.JDK.org.ietf.jgss.Oid arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/security/Provider;Lorg/ietf/jgss/Oid;)V", "public")]
	public void addProviderAtFront(Dova.JDK.java.security.Provider arg0, Dova.JDK.org.ietf.jgss.Oid arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("([BLorg/ietf/jgss/Oid;Lorg/ietf/jgss/Oid;)Lsun/security/jgss/spi/GSSNameSpi;", "public")]
	public Dova.JDK.sun.security.jgss.spi.GSSNameSpi getNameElement(JavaArray<byte> arg0, Dova.JDK.org.ietf.jgss.Oid arg1, Dova.JDK.org.ietf.jgss.Oid arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.spi.GSSNameSpi>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lorg/ietf/jgss/Oid;Lorg/ietf/jgss/Oid;)Lsun/security/jgss/spi/GSSNameSpi;", "public")]
	public Dova.JDK.sun.security.jgss.spi.GSSNameSpi getNameElement(Dova.JDK.java.lang.String arg0, Dova.JDK.org.ietf.jgss.Oid arg1, Dova.JDK.org.ietf.jgss.Oid arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.spi.GSSNameSpi>(ret);
	}

	[JniSignatureAttribute("(Lorg/ietf/jgss/Oid;)[Lorg/ietf/jgss/Oid;", "public")]
	public JavaArray<Dova.JDK.org.ietf.jgss.Oid> getMechsForName(Dova.JDK.org.ietf.jgss.Oid arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.org.ietf.jgss.Oid>>(ret);
	}

	[JniSignatureAttribute("(Lorg/ietf/jgss/Oid;)[Lorg/ietf/jgss/Oid;", "public")]
	public JavaArray<Dova.JDK.org.ietf.jgss.Oid> getNamesForMech(Dova.JDK.org.ietf.jgss.Oid arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.org.ietf.jgss.Oid>>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/jgss/spi/GSSNameSpi;IILorg/ietf/jgss/Oid;I)Lsun/security/jgss/spi/GSSCredentialSpi;", "public")]
	public Dova.JDK.sun.security.jgss.spi.GSSCredentialSpi getCredentialElement(Dova.JDK.sun.security.jgss.spi.GSSNameSpi arg0, int arg1, int arg2, Dova.JDK.org.ietf.jgss.Oid arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.spi.GSSCredentialSpi>(ret);
	}

	[JniSignatureAttribute("([BLorg/ietf/jgss/Oid;)Lorg/ietf/jgss/GSSName;", "public")]
	public Dova.JDK.org.ietf.jgss.GSSName createName(JavaArray<byte> arg0, Dova.JDK.org.ietf.jgss.Oid arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.GSSName>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lorg/ietf/jgss/Oid;)Lorg/ietf/jgss/GSSName;", "public")]
	public Dova.JDK.org.ietf.jgss.GSSName createName(Dova.JDK.java.lang.String arg0, Dova.JDK.org.ietf.jgss.Oid arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.GSSName>(ret);
	}

	[JniSignatureAttribute("([BLorg/ietf/jgss/Oid;Lorg/ietf/jgss/Oid;)Lorg/ietf/jgss/GSSName;", "public")]
	public Dova.JDK.org.ietf.jgss.GSSName createName(JavaArray<byte> arg0, Dova.JDK.org.ietf.jgss.Oid arg1, Dova.JDK.org.ietf.jgss.Oid arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.GSSName>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lorg/ietf/jgss/Oid;Lorg/ietf/jgss/Oid;)Lorg/ietf/jgss/GSSName;", "public")]
	public Dova.JDK.org.ietf.jgss.GSSName createName(Dova.JDK.java.lang.String arg0, Dova.JDK.org.ietf.jgss.Oid arg1, Dova.JDK.org.ietf.jgss.Oid arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.GSSName>(ret);
	}

	[JniSignatureAttribute("(Lorg/ietf/jgss/GSSName;I[Lorg/ietf/jgss/Oid;I)Lorg/ietf/jgss/GSSCredential;", "public")]
	public Dova.JDK.org.ietf.jgss.GSSCredential createCredential(Dova.JDK.org.ietf.jgss.GSSName arg0, int arg1, JavaArray<Dova.JDK.org.ietf.jgss.Oid> arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.GSSCredential>(ret);
	}

	[JniSignatureAttribute("(Lorg/ietf/jgss/GSSName;ILorg/ietf/jgss/Oid;I)Lorg/ietf/jgss/GSSCredential;", "public")]
	public Dova.JDK.org.ietf.jgss.GSSCredential createCredential(Dova.JDK.org.ietf.jgss.GSSName arg0, int arg1, Dova.JDK.org.ietf.jgss.Oid arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.GSSCredential>(ret);
	}

	[JniSignatureAttribute("(I)Lorg/ietf/jgss/GSSCredential;", "public")]
	public Dova.JDK.org.ietf.jgss.GSSCredential createCredential(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.GSSCredential>(ret);
	}

	[JniSignatureAttribute("(Lorg/ietf/jgss/GSSName;Lorg/ietf/jgss/Oid;Lorg/ietf/jgss/GSSCredential;I)Lorg/ietf/jgss/GSSContext;", "public")]
	public Dova.JDK.org.ietf.jgss.GSSContext createContext(Dova.JDK.org.ietf.jgss.GSSName arg0, Dova.JDK.org.ietf.jgss.Oid arg1, Dova.JDK.org.ietf.jgss.GSSCredential arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.GSSContext>(ret);
	}

	[JniSignatureAttribute("([B)Lorg/ietf/jgss/GSSContext;", "public")]
	public Dova.JDK.org.ietf.jgss.GSSContext createContext(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.GSSContext>(ret);
	}

	[JniSignatureAttribute("(Lorg/ietf/jgss/GSSCredential;)Lorg/ietf/jgss/GSSContext;", "public")]
	public Dova.JDK.org.ietf.jgss.GSSContext createContext(Dova.JDK.org.ietf.jgss.GSSCredential arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.GSSContext>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/jgss/spi/GSSNameSpi;Lsun/security/jgss/spi/GSSCredentialSpi;ILorg/ietf/jgss/Oid;)Lsun/security/jgss/spi/GSSContextSpi;", "")]
	public Dova.JDK.sun.security.jgss.spi.GSSContextSpi getMechanismContext(Dova.JDK.sun.security.jgss.spi.GSSNameSpi arg0, Dova.JDK.sun.security.jgss.spi.GSSCredentialSpi arg1, int arg2, Dova.JDK.org.ietf.jgss.Oid arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.spi.GSSContextSpi>(ret);
	}

	[JniSignatureAttribute("([B)Lsun/security/jgss/spi/GSSContextSpi;", "")]
	public Dova.JDK.sun.security.jgss.spi.GSSContextSpi getMechanismContext(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.spi.GSSContextSpi>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/jgss/spi/GSSCredentialSpi;Lorg/ietf/jgss/Oid;)Lsun/security/jgss/spi/GSSContextSpi;", "")]
	public Dova.JDK.sun.security.jgss.spi.GSSContextSpi getMechanismContext(Dova.JDK.sun.security.jgss.spi.GSSCredentialSpi arg0, Dova.JDK.org.ietf.jgss.Oid arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.spi.GSSContextSpi>(ret);
	}

	[JniSignatureAttribute("()[Lorg/ietf/jgss/Oid;", "public")]
	public JavaArray<Dova.JDK.org.ietf.jgss.Oid> getMechs()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.org.ietf.jgss.Oid>>(ret);
	}
}
