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

namespace Dova.JDK.com.sun.rowset.@internal;

[JniSignatureAttribute("Lcom/sun/rowset/internal/CachedRowSetWriter;", "public")]
public partial class CachedRowSetWriter
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.sql.rowset.spi.TransactionalWriter
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CachedRowSetWriter()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/rowset/internal/CachedRowSetWriter;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "con", "Ljava/sql/Connection;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "selectCmd", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "updateCmd", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "updateWhere", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "deleteCmd", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "deleteWhere", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "insertCmd", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "keyCols", "[I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "params", "[Ljava/lang/Object;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "reader", "Lcom/sun/rowset/internal/CachedRowSetReader;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "callerMd", "Ljava/sql/ResultSetMetaData;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "callerColumnCount", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "crsResolve", "Lcom/sun/rowset/CachedRowSetImpl;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "status", "Ljava/util/ArrayList;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "iChangedValsInDbAndCRS", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "iChangedValsinDbOnly", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "resBundle", "Lcom/sun/rowset/JdbcRowSetResourceBundle;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CachedRowSetWriter", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "commit", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "commit", "(Lcom/sun/rowset/CachedRowSetImpl;Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "updateResolvedConflictToDB", "(Ljavax/sql/rowset/CachedRowSet;Ljava/sql/Connection;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getReader", "()Lcom/sun/rowset/internal/CachedRowSetReader;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setReader", "(Lcom/sun/rowset/internal/CachedRowSetReader;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "buildTableName", "(Ljava/sql/DatabaseMetaData;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "rollback", "(Ljava/sql/Savepoint;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "rollback", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "writeData", "(Ljavax/sql/RowSetInternal;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "buildWhereClause", "(Ljava/lang/String;Ljava/sql/ResultSet;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isPKNameValid", "(Ljava/lang/String;Ljava/sql/ResultSetMetaData;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "buildKeyDesc", "(Ljavax/sql/rowset/CachedRowSet;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "initSQLStatements", "(Ljavax/sql/rowset/CachedRowSet;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "deleteOriginalRow", "(Ljavax/sql/rowset/CachedRowSet;Lcom/sun/rowset/CachedRowSetImpl;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "insertNewRow", "(Ljavax/sql/rowset/CachedRowSet;Ljava/sql/PreparedStatement;Lcom/sun/rowset/CachedRowSetImpl;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "updateOriginalRow", "(Ljavax/sql/rowset/CachedRowSet;)Z"));
	}

	[JniSignatureAttribute("Ljava/sql/Connection;", "private transient")]
	public Dova.JDK.java.sql.Connection con_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Connection>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String selectCmd_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String updateCmd_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String updateWhere_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String deleteCmd_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String deleteWhere_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String insertCmd_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> keyCols_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljava/lang/Object;", "private")]
	public JavaArray<Dova.JDK.java.lang.Object> @params_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/rowset/internal/CachedRowSetReader;", "private")]
	public Dova.JDK.com.sun.rowset.@internal.CachedRowSetReader reader_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.rowset.@internal.CachedRowSetReader>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/sql/ResultSetMetaData;", "private")]
	public Dova.JDK.java.sql.ResultSetMetaData callerMd_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.sql.ResultSetMetaData>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int callerColumnCount_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[11], value);
	}

	[JniSignatureAttribute("Lcom/sun/rowset/CachedRowSetImpl;", "private")]
	public Dova.JDK.com.sun.rowset.CachedRowSetImpl crsResolve_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.rowset.CachedRowSetImpl>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/ArrayList;", "private")]
	public Dova.JDK.java.util.ArrayList status_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int iChangedValsInDbAndCRS_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[14]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[14], value);
	}

	[JniSignatureAttribute("I", "private")]
	public int iChangedValsinDbOnly_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[15]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[15], value);
	}

	[JniSignatureAttribute("Lcom/sun/rowset/JdbcRowSetResourceBundle;", "private")]
	public Dova.JDK.com.sun.rowset.JdbcRowSetResourceBundle resBundle_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.rowset.JdbcRowSetResourceBundle>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("J", "static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[17]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[17], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CachedRowSetWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public CachedRowSetWriter() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/rowset/internal/CachedRowSetWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void commit()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(Lcom/sun/rowset/CachedRowSetImpl;Z)V", "public")]
	public void commit(Dova.JDK.com.sun.rowset.CachedRowSetImpl arg0, bool arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/sql/rowset/CachedRowSet;Ljava/sql/Connection;)V", "")]
	public void updateResolvedConflictToDB(Dova.JDK.javax.sql.rowset.CachedRowSet arg0, Dova.JDK.java.sql.Connection arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("()Lcom/sun/rowset/internal/CachedRowSetReader;", "public")]
	public Dova.JDK.com.sun.rowset.@internal.CachedRowSetReader getReader()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.rowset.@internal.CachedRowSetReader>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/rowset/internal/CachedRowSetReader;)V", "public")]
	public void setReader(Dova.JDK.com.sun.rowset.@internal.CachedRowSetReader arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/sql/DatabaseMetaData;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String buildTableName(Dova.JDK.java.sql.DatabaseMetaData arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/sql/Savepoint;)V", "public")]
	public void rollback(Dova.JDK.java.sql.Savepoint arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void rollback()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("(Ljavax/sql/RowSetInternal;)Z", "public")]
	public bool writeData(Dova.JDK.javax.sql.RowSetInternal arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/ResultSet;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String buildWhereClause(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.ResultSet arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/ResultSetMetaData;)Z", "private")]
	public bool isPKNameValid(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.ResultSetMetaData arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/sql/rowset/CachedRowSet;)V", "private")]
	public void buildKeyDesc(Dova.JDK.javax.sql.rowset.CachedRowSet arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Ljavax/sql/rowset/CachedRowSet;)V", "private")]
	public void initSQLStatements(Dova.JDK.javax.sql.rowset.CachedRowSet arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Ljavax/sql/rowset/CachedRowSet;Lcom/sun/rowset/CachedRowSetImpl;)Z", "private")]
	public bool deleteOriginalRow(Dova.JDK.javax.sql.rowset.CachedRowSet arg0, Dova.JDK.com.sun.rowset.CachedRowSetImpl arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/sql/rowset/CachedRowSet;Ljava/sql/PreparedStatement;Lcom/sun/rowset/CachedRowSetImpl;)Z", "private")]
	public bool insertNewRow(Dova.JDK.javax.sql.rowset.CachedRowSet arg0, Dova.JDK.java.sql.PreparedStatement arg1, Dova.JDK.com.sun.rowset.CachedRowSetImpl arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/sql/rowset/CachedRowSet;)Z", "private")]
	public bool updateOriginalRow(Dova.JDK.javax.sql.rowset.CachedRowSet arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return ret;
	}
}