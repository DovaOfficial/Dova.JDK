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

namespace Dova.JDK.java.rmi.registry;

[JniSignatureAttribute("Ljava/rmi/registry/Registry;", "public abstract interface")]
public partial interface Registry
	: IJavaObject
	, Dova.JDK.java.rmi.Remote
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Registry()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/rmi/registry/Registry;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REGISTRY_PORT", "I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "list", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookup", "(Ljava/lang/String;)Ljava/rmi/Remote;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rebind", "(Ljava/lang/String;Ljava/rmi/Remote;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Ljava/lang/String;Ljava/rmi/Remote;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unbind", "(Ljava/lang/String;)V"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int REGISTRY_PORT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "public abstract")]
	JavaArray<Dova.JDK.java.lang.String> list()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/rmi/Remote;", "public abstract")]
	Dova.JDK.java.rmi.Remote lookup(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.Remote>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/rmi/Remote;)V", "public abstract")]
	void rebind(Dova.JDK.java.lang.String arg0, Dova.JDK.java.rmi.Remote arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/rmi/Remote;)V", "public abstract")]
	void bind(Dova.JDK.java.lang.String arg0, Dova.JDK.java.rmi.Remote arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public abstract")]
	void unbind(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}
}
