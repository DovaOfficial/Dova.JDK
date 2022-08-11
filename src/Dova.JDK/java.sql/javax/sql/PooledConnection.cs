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

namespace Dova.JDK.javax.sql;

[JniSignatureAttribute("Ljavax/sql/PooledConnection;", "public abstract interface")]
public partial interface PooledConnection
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PooledConnection()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/sql/PooledConnection;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConnection", "()Ljava/sql/Connection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConnectionEventListener", "(Ljavax/sql/ConnectionEventListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeConnectionEventListener", "(Ljavax/sql/ConnectionEventListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addStatementEventListener", "(Ljavax/sql/StatementEventListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeStatementEventListener", "(Ljavax/sql/StatementEventListener;)V"));
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()Ljava/sql/Connection;", "public abstract")]
	Dova.JDK.java.sql.Connection getConnection()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Connection>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sql/ConnectionEventListener;)V", "public abstract")]
	void addConnectionEventListener(Dova.JDK.javax.sql.ConnectionEventListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljavax/sql/ConnectionEventListener;)V", "public abstract")]
	void removeConnectionEventListener(Dova.JDK.javax.sql.ConnectionEventListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljavax/sql/StatementEventListener;)V", "public abstract")]
	void addStatementEventListener(Dova.JDK.javax.sql.StatementEventListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljavax/sql/StatementEventListener;)V", "public abstract")]
	void removeStatementEventListener(Dova.JDK.javax.sql.StatementEventListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}
}
