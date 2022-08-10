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

namespace Dova.JDK.com.sun.jndi.ldap.pool;

[JniSignatureAttribute("Lcom/sun/jndi/ldap/pool/PooledConnectionFactory;", "public abstract interface")]
public partial interface PooledConnectionFactory
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PooledConnectionFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jndi/ldap/pool/PooledConnectionFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createPooledConnection", "(Lcom/sun/jndi/ldap/pool/PoolCallback;)Lcom/sun/jndi/ldap/pool/PooledConnection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createPooledConnection", "(Lcom/sun/jndi/ldap/pool/PoolCallback;J)Lcom/sun/jndi/ldap/pool/PooledConnection;"));
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/ldap/pool/PoolCallback;)Lcom/sun/jndi/ldap/pool/PooledConnection;", "public abstract")]
	Dova.JDK.com.sun.jndi.ldap.pool.PooledConnection createPooledConnection(Dova.JDK.com.sun.jndi.ldap.pool.PoolCallback arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.ldap.pool.PooledConnection>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/ldap/pool/PoolCallback;J)Lcom/sun/jndi/ldap/pool/PooledConnection;", "public abstract")]
	Dova.JDK.com.sun.jndi.ldap.pool.PooledConnection createPooledConnection(Dova.JDK.com.sun.jndi.ldap.pool.PoolCallback arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.ldap.pool.PooledConnection>(ret);
	}
}
