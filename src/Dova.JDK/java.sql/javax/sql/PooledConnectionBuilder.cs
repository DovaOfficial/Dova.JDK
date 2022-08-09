/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.javax.sql;

[JniSignatureAttribute("Ljavax/sql/PooledConnectionBuilder;", "public abstract interface")]
public partial interface PooledConnectionBuilder
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PooledConnectionBuilder()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/sql/PooledConnectionBuilder;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "build", "()Ljavax/sql/PooledConnection;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "user", "(Ljava/lang/String;)Ljavax/sql/PooledConnectionBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "password", "(Ljava/lang/String;)Ljavax/sql/PooledConnectionBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "shardingKey", "(Ljava/sql/ShardingKey;)Ljavax/sql/PooledConnectionBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "superShardingKey", "(Ljava/sql/ShardingKey;)Ljavax/sql/PooledConnectionBuilder;"));
	}

	[JniSignatureAttribute("()Ljavax/sql/PooledConnection;", "public abstract")]
	Dova.JDK.javax.sql.PooledConnection build()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.PooledConnection>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/sql/PooledConnectionBuilder;", "public abstract")]
	Dova.JDK.javax.sql.PooledConnectionBuilder user(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.PooledConnectionBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/sql/PooledConnectionBuilder;", "public abstract")]
	Dova.JDK.javax.sql.PooledConnectionBuilder password(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.PooledConnectionBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/sql/ShardingKey;)Ljavax/sql/PooledConnectionBuilder;", "public abstract")]
	Dova.JDK.javax.sql.PooledConnectionBuilder shardingKey(Dova.JDK.java.sql.ShardingKey arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.PooledConnectionBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/sql/ShardingKey;)Ljavax/sql/PooledConnectionBuilder;", "public abstract")]
	Dova.JDK.javax.sql.PooledConnectionBuilder superShardingKey(Dova.JDK.java.sql.ShardingKey arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.PooledConnectionBuilder>(ret);
	}
}
