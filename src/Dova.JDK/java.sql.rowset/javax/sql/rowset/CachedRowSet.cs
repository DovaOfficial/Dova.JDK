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

namespace Dova.JDK.javax.sql.rowset;

[JniSignatureAttribute("Ljavax/sql/rowset/CachedRowSet;", "public abstract interface")]
public partial interface CachedRowSet
	: IJavaObject
	, Dova.JDK.javax.sql.RowSet
	, Dova.JDK.javax.sql.rowset.Joinable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CachedRowSet()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/sql/rowset/CachedRowSet;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMIT_ON_ACCEPT_CHANGES", "Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "execute", "(Ljava/sql/Connection;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "release", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "commit", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toCollection", "(Ljava/lang/String;)Ljava/util/Collection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toCollection", "(I)Ljava/util/Collection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toCollection", "()Ljava/util/Collection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rowSetPopulated", "(Ljavax/sql/RowSetEvent;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rollback", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rollback", "(Ljava/sql/Savepoint;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShowDeleted", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setShowDeleted", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptChanges", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptChanges", "(Ljava/sql/Connection;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "restoreOriginal", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "undoDelete", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "undoInsert", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "undoUpdate", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "columnUpdated", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "columnUpdated", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSyncProvider", "()Ljavax/sql/rowset/spi/SyncProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSyncProvider", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMetaData", "(Ljavax/sql/RowSetMetaData;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOriginal", "()Ljava/sql/ResultSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOriginalRow", "()Ljava/sql/ResultSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOriginalRow", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTableName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTableName", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeyColumns", "()[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setKeyColumns", "([I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createShared", "()Ljavax/sql/RowSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCopy", "()Ljavax/sql/rowset/CachedRowSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCopySchema", "()Ljavax/sql/rowset/CachedRowSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCopyNoConstraints", "()Ljavax/sql/rowset/CachedRowSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowSetWarnings", "()Ljavax/sql/rowset/RowSetWarning;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPageSize", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPageSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextPage", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "previousPage", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "populate", "(Ljava/sql/ResultSet;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "populate", "(Ljava/sql/ResultSet;)V"));
	}

	[JniSignatureAttribute("Z", "public static final")]
	public static bool COMMIT_ON_ACCEPT_CHANGES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int size()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/sql/Connection;)V", "public abstract")]
	void execute(Dova.JDK.java.sql.Connection arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void release()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void commit()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Collection;", "public abstract")]
	Dova.JDK.java.util.Collection toCollection(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/util/Collection;", "public abstract")]
	Dova.JDK.java.util.Collection toCollection(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Collection;", "public abstract")]
	Dova.JDK.java.util.Collection toCollection()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sql/RowSetEvent;I)V", "public abstract")]
	void rowSetPopulated(Dova.JDK.javax.sql.RowSetEvent arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void rollback()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("(Ljava/sql/Savepoint;)V", "public abstract")]
	void rollback(Dova.JDK.java.sql.Savepoint arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool getShowDeleted()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public abstract")]
	void setShowDeleted(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void acceptChanges()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
	}

	[JniSignatureAttribute("(Ljava/sql/Connection;)V", "public abstract")]
	void acceptChanges(Dova.JDK.java.sql.Connection arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void restoreOriginal()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14]);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void undoDelete()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15]);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void undoInsert()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16]);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void undoUpdate()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public abstract")]
	bool columnUpdated(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public abstract")]
	bool columnUpdated(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/sql/rowset/spi/SyncProvider;", "public abstract")]
	Dova.JDK.javax.sql.rowset.spi.SyncProvider getSyncProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.rowset.spi.SyncProvider>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public abstract")]
	void setSyncProvider(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Ljavax/sql/RowSetMetaData;)V", "public abstract")]
	void setMetaData(Dova.JDK.javax.sql.RowSetMetaData arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("()Ljava/sql/ResultSet;", "public abstract")]
	Dova.JDK.java.sql.ResultSet getOriginal()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.ResultSet>(ret);
	}

	[JniSignatureAttribute("()Ljava/sql/ResultSet;", "public abstract")]
	Dova.JDK.java.sql.ResultSet getOriginalRow()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.ResultSet>(ret);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void setOriginalRow()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25]);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getTableName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public abstract")]
	void setTableName(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
	}

	[JniSignatureAttribute("()[I", "public abstract")]
	JavaArray<int> getKeyColumns()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("([I)V", "public abstract")]
	void setKeyColumns(JavaArray<int> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
	}

	[JniSignatureAttribute("()Ljavax/sql/RowSet;", "public abstract")]
	Dova.JDK.javax.sql.RowSet createShared()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.RowSet>(ret);
	}

	[JniSignatureAttribute("()Ljavax/sql/rowset/CachedRowSet;", "public abstract")]
	Dova.JDK.javax.sql.rowset.CachedRowSet createCopy()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.rowset.CachedRowSet>(ret);
	}

	[JniSignatureAttribute("()Ljavax/sql/rowset/CachedRowSet;", "public abstract")]
	Dova.JDK.javax.sql.rowset.CachedRowSet createCopySchema()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.rowset.CachedRowSet>(ret);
	}

	[JniSignatureAttribute("()Ljavax/sql/rowset/CachedRowSet;", "public abstract")]
	Dova.JDK.javax.sql.rowset.CachedRowSet createCopyNoConstraints()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.rowset.CachedRowSet>(ret);
	}

	[JniSignatureAttribute("()Ljavax/sql/rowset/RowSetWarning;", "public abstract")]
	Dova.JDK.javax.sql.rowset.RowSetWarning getRowSetWarnings()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.rowset.RowSetWarning>(ret);
	}

	[JniSignatureAttribute("(I)V", "public abstract")]
	void setPageSize(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getPageSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[36]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool nextPage()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[37]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool previousPage()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[38]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/sql/ResultSet;I)V", "public abstract")]
	void populate(Dova.JDK.java.sql.ResultSet arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/sql/ResultSet;)V", "public abstract")]
	void populate(Dova.JDK.java.sql.ResultSet arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
	}
}
