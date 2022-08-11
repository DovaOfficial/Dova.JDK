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

namespace Dova.JDK.javax.naming.directory;

[JniSignatureAttribute("Ljavax/naming/directory/Attributes;", "public abstract interface")]
public partial interface Attributes
	: IJavaObject
	, Dova.JDK.java.lang.Cloneable
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Attributes()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/naming/directory/Attributes;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "(Ljava/lang/String;)Ljavax/naming/directory/Attribute;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(Ljava/lang/String;)Ljavax/naming/directory/Attribute;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "(Ljava/lang/String;Ljava/lang/Object;)Ljavax/naming/directory/Attribute;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "(Ljavax/naming/directory/Attribute;)Ljavax/naming/directory/Attribute;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAll", "()Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCaseIgnored", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIDs", "()Ljavax/naming/NamingEnumeration;"));
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/naming/directory/Attribute;", "public abstract")]
	Dova.JDK.javax.naming.directory.Attribute remove(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.Attribute>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/naming/directory/Attribute;", "public abstract")]
	Dova.JDK.javax.naming.directory.Attribute get(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.Attribute>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)Ljavax/naming/directory/Attribute;", "public abstract")]
	Dova.JDK.javax.naming.directory.Attribute put(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.Attribute>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/directory/Attribute;)Ljavax/naming/directory/Attribute;", "public abstract")]
	Dova.JDK.javax.naming.directory.Attribute put(Dova.JDK.javax.naming.directory.Attribute arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.Attribute>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object clone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int size()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/naming/NamingEnumeration;", "public abstract")]
	Dova.JDK.javax.naming.NamingEnumeration getAll()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isCaseIgnored()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/naming/NamingEnumeration;", "public abstract")]
	Dova.JDK.javax.naming.NamingEnumeration getIDs()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}
}
