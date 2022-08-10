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

namespace Dova.JDK.sun.net.www.protocol.http;

[JniSignatureAttribute("Lsun/net/www/protocol/http/AuthCache;", "public abstract interface")]
public partial interface AuthCache
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AuthCache()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/net/www/protocol/http/AuthCache;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "remove", "(Ljava/lang/String;Lsun/net/www/protocol/http/AuthCacheValue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "get", "(Ljava/lang/String;Ljava/lang/String;)Lsun/net/www/protocol/http/AuthCacheValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "put", "(Ljava/lang/String;Lsun/net/www/protocol/http/AuthCacheValue;)V"));
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lsun/net/www/protocol/http/AuthCacheValue;)V", "public abstract")]
	void remove(Dova.JDK.java.lang.String arg0, Dova.JDK.sun.net.www.protocol.http.AuthCacheValue arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lsun/net/www/protocol/http/AuthCacheValue;", "public abstract")]
	Dova.JDK.sun.net.www.protocol.http.AuthCacheValue get(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.protocol.http.AuthCacheValue>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lsun/net/www/protocol/http/AuthCacheValue;)V", "public abstract")]
	void put(Dova.JDK.java.lang.String arg0, Dova.JDK.sun.net.www.protocol.http.AuthCacheValue arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}
}
