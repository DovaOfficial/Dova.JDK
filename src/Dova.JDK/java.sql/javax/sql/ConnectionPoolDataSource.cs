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

[JniSignatureAttribute("Ljavax/sql/ConnectionPoolDataSource;", "public abstract interface")]
public partial interface ConnectionPoolDataSource
	: IJavaObject
	, Dova.JDK.javax.sql.CommonDataSource
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ConnectionPoolDataSource()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/sql/ConnectionPoolDataSource;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPooledConnection", "()Ljavax/sql/PooledConnection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPooledConnection", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/sql/PooledConnection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createPooledConnectionBuilder", "()Ljavax/sql/PooledConnectionBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLogWriter", "()Ljava/io/PrintWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLogWriter", "(Ljava/io/PrintWriter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLoginTimeout", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLoginTimeout", "()I"));
	}

	[JniSignatureAttribute("()Ljavax/sql/PooledConnection;", "public abstract")]
	Dova.JDK.javax.sql.PooledConnection getPooledConnection()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.PooledConnection>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljavax/sql/PooledConnection;", "public abstract")]
	Dova.JDK.javax.sql.PooledConnection getPooledConnection(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.PooledConnection>(ret);
	}

	[JniSignatureAttribute("()Ljavax/sql/PooledConnectionBuilder;", "public")]
	Dova.JDK.javax.sql.PooledConnectionBuilder createPooledConnectionBuilder()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.PooledConnectionBuilder>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/PrintWriter;", "public abstract")]
	Dova.JDK.java.io.PrintWriter getLogWriter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintWriter>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/PrintWriter;)V", "public abstract")]
	void setLogWriter(Dova.JDK.java.io.PrintWriter arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(I)V", "public abstract")]
	void setLoginTimeout(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getLoginTimeout()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}
}
