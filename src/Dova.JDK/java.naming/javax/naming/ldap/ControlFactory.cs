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

namespace Dova.JDK.javax.naming.ldap;

[JniSignatureAttribute("Ljavax/naming/ldap/ControlFactory;", "public abstract")]
public partial class ControlFactory
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ControlFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/naming/ldap/ControlFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ControlFactory", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getControlInstance", "(Ljavax/naming/ldap/Control;)Ljavax/naming/ldap/Control;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getControlInstance", "(Ljavax/naming/ldap/Control;Ljavax/naming/Context;Ljava/util/Hashtable;)Ljavax/naming/ldap/Control;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ControlFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public ControlFactory() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/naming/ldap/ControlFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/naming/ldap/Control;)Ljavax/naming/ldap/Control;", "public abstract")]
	public Dova.JDK.javax.naming.ldap.Control getControlInstance(Dova.JDK.javax.naming.ldap.Control arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.ldap.Control>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/ldap/Control;Ljavax/naming/Context;Ljava/util/Hashtable;)Ljavax/naming/ldap/Control;", "public static")]
	public static Dova.JDK.javax.naming.ldap.Control getControlInstance(Dova.JDK.javax.naming.ldap.Control arg0, Dova.JDK.javax.naming.Context arg1, Dova.JDK.java.util.Hashtable arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.ldap.Control>(ret);
	}
}
