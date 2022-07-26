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

namespace Dova.JDK.com.sun.jndi.ldap.pool;

[JniSignatureAttribute("Lcom/sun/jndi/ldap/pool/PoolCallback;", "public abstract interface")]
public partial interface PoolCallback
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PoolCallback()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jndi/ldap/pool/PoolCallback;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "releasePooledConnection", "(Lcom/sun/jndi/ldap/pool/PooledConnection;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removePooledConnection", "(Lcom/sun/jndi/ldap/pool/PooledConnection;)Z"));
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/ldap/pool/PooledConnection;)Z", "public abstract")]
	bool releasePooledConnection(Dova.JDK.com.sun.jndi.ldap.pool.PooledConnection arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/ldap/pool/PooledConnection;)Z", "public abstract")]
	bool removePooledConnection(Dova.JDK.com.sun.jndi.ldap.pool.PooledConnection arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}
}
