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

namespace Dova.JDK.java.sql;

[JniSignatureAttribute("Ljava/sql/ShardingKeyBuilder;", "public abstract interface")]
public partial interface ShardingKeyBuilder
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ShardingKeyBuilder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/sql/ShardingKeyBuilder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "build", "()Ljava/sql/ShardingKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "subkey", "(Ljava/lang/Object;Ljava/sql/SQLType;)Ljava/sql/ShardingKeyBuilder;"));
	}

	[JniSignatureAttribute("()Ljava/sql/ShardingKey;", "public abstract")]
	Dova.JDK.java.sql.ShardingKey build()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.ShardingKey>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/sql/SQLType;)Ljava/sql/ShardingKeyBuilder;", "public abstract")]
	Dova.JDK.java.sql.ShardingKeyBuilder subkey(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.sql.SQLType arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.ShardingKeyBuilder>(ret);
	}
}
