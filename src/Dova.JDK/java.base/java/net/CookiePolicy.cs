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

namespace Dova.JDK.java.net;

[JniSignatureAttribute("Ljava/net/CookiePolicy;", "public abstract interface")]
public partial interface CookiePolicy
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CookiePolicy()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/net/CookiePolicy;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCEPT_ALL", "Ljava/net/CookiePolicy;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCEPT_NONE", "Ljava/net/CookiePolicy;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCEPT_ORIGINAL_SERVER", "Ljava/net/CookiePolicy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shouldAccept", "(Ljava/net/URI;Ljava/net/HttpCookie;)Z"));
	}

	[JniSignatureAttribute("Ljava/net/CookiePolicy;", "public static final")]
	public static Dova.JDK.java.net.CookiePolicy ACCEPT_ALL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.CookiePolicy>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/CookiePolicy;", "public static final")]
	public static Dova.JDK.java.net.CookiePolicy ACCEPT_NONE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.CookiePolicy>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/CookiePolicy;", "public static final")]
	public static Dova.JDK.java.net.CookiePolicy ACCEPT_ORIGINAL_SERVER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.CookiePolicy>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(Ljava/net/URI;Ljava/net/HttpCookie;)Z", "public abstract")]
	bool shouldAccept(Dova.JDK.java.net.URI arg0, Dova.JDK.java.net.HttpCookie arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}
}
