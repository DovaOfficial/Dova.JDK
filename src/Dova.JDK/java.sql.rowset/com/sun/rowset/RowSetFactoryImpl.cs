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

namespace Dova.JDK.com.sun.rowset;

[JniSignatureAttribute("Lcom/sun/rowset/RowSetFactoryImpl;", "public final")]
public partial class RowSetFactoryImpl
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.sql.rowset.RowSetFactory
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RowSetFactoryImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/rowset/RowSetFactoryImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createFilteredRowSet", "()Ljavax/sql/rowset/FilteredRowSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCachedRowSet", "()Ljavax/sql/rowset/CachedRowSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createJdbcRowSet", "()Ljavax/sql/rowset/JdbcRowSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createJoinRowSet", "()Ljavax/sql/rowset/JoinRowSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createWebRowSet", "()Ljavax/sql/rowset/WebRowSet;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RowSetFactoryImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public RowSetFactoryImpl() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/rowset/RowSetFactoryImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljavax/sql/rowset/FilteredRowSet;", "public")]
	public Dova.JDK.javax.sql.rowset.FilteredRowSet createFilteredRowSet()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.rowset.FilteredRowSet>(ret);
	}

	[JniSignatureAttribute("()Ljavax/sql/rowset/CachedRowSet;", "public")]
	public Dova.JDK.javax.sql.rowset.CachedRowSet createCachedRowSet()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.rowset.CachedRowSet>(ret);
	}

	[JniSignatureAttribute("()Ljavax/sql/rowset/JdbcRowSet;", "public")]
	public Dova.JDK.javax.sql.rowset.JdbcRowSet createJdbcRowSet()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.rowset.JdbcRowSet>(ret);
	}

	[JniSignatureAttribute("()Ljavax/sql/rowset/JoinRowSet;", "public")]
	public Dova.JDK.javax.sql.rowset.JoinRowSet createJoinRowSet()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.rowset.JoinRowSet>(ret);
	}

	[JniSignatureAttribute("()Ljavax/sql/rowset/WebRowSet;", "public")]
	public Dova.JDK.javax.sql.rowset.WebRowSet createWebRowSet()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.rowset.WebRowSet>(ret);
	}
}
