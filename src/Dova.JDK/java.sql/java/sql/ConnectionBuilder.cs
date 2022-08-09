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

namespace Dova.JDK.java.sql;

[JniSignatureAttribute("Ljava/sql/ConnectionBuilder;", "public abstract interface")]
public partial interface ConnectionBuilder
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ConnectionBuilder()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/sql/ConnectionBuilder;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "build", "()Ljava/sql/Connection;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "user", "(Ljava/lang/String;)Ljava/sql/ConnectionBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "password", "(Ljava/lang/String;)Ljava/sql/ConnectionBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "shardingKey", "(Ljava/sql/ShardingKey;)Ljava/sql/ConnectionBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "superShardingKey", "(Ljava/sql/ShardingKey;)Ljava/sql/ConnectionBuilder;"));
	}

	[JniSignatureAttribute("()Ljava/sql/Connection;", "public abstract")]
	Dova.JDK.java.sql.Connection build()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Connection>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/sql/ConnectionBuilder;", "public abstract")]
	Dova.JDK.java.sql.ConnectionBuilder user(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.ConnectionBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/sql/ConnectionBuilder;", "public abstract")]
	Dova.JDK.java.sql.ConnectionBuilder password(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.ConnectionBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/sql/ShardingKey;)Ljava/sql/ConnectionBuilder;", "public abstract")]
	Dova.JDK.java.sql.ConnectionBuilder shardingKey(Dova.JDK.java.sql.ShardingKey arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.ConnectionBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/sql/ShardingKey;)Ljava/sql/ConnectionBuilder;", "public abstract")]
	Dova.JDK.java.sql.ConnectionBuilder superShardingKey(Dova.JDK.java.sql.ShardingKey arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.ConnectionBuilder>(ret);
	}
}