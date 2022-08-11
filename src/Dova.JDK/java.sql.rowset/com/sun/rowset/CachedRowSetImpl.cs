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

[JniSignatureAttribute("Lcom/sun/rowset/CachedRowSetImpl;", "public")]
public partial class CachedRowSetImpl
	: Dova.JDK.javax.sql.rowset.BaseRowSet
	, Dova.JDK.javax.sql.RowSet
	, Dova.JDK.javax.sql.RowSetInternal
	, Dova.JDK.java.io.Serializable
	, Dova.JDK.java.lang.Cloneable
	, Dova.JDK.javax.sql.rowset.CachedRowSet
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CachedRowSetImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/rowset/CachedRowSetImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "provider", "Ljavax/sql/rowset/spi/SyncProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rowSetReader", "Ljavax/sql/RowSetReader;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rowSetWriter", "Ljavax/sql/RowSetWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "conn", "Ljava/sql/Connection;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "RSMD", "Ljava/sql/ResultSetMetaData;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "RowSetMD", "Ljavax/sql/rowset/RowSetMetaDataImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyCols", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tableName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rvh", "Ljava/util/Vector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cursorPos", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "absolutePos", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "numDeleted", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "numRows", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "insertRow", "Lcom/sun/rowset/internal/InsertRow;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "onInsertRow", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentRow", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastValueNull", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sqlwarn", "Ljava/sql/SQLWarning;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strMatchColumn", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "iMatchColumn", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rowsetWarning", "Ljavax/sql/rowset/RowSetWarning;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "DEFAULT_SYNC_PROVIDER", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dbmslocatorsUpdateCopy", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resultSet", "Ljava/sql/ResultSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "endPos", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prevEndPos", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "startPos", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "startPrev", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pageSize", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxRowsreached", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pagenotend", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "onFirstPage", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "onLastPage", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "populatecallcount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "totalRows", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "callWithCon", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "crsReader", "Lcom/sun/rowset/internal/CachedRowSetReader;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "iMatchColumns", "Ljava/util/Vector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strMatchColumns", "Ljava/util/Vector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tXWriter", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tWriter", "Ljavax/sql/rowset/spi/TransactionalWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resBundle", "Lcom/sun/rowset/JdbcRowSetResourceBundle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "updateOnInsert", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Hashtable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkIndex", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateBytes", "(I[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateBytes", "(Ljava/lang/String;[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBoolean", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBoolean", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByte", "(I)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByte", "(Ljava/lang/String;)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShort", "(I)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShort", "(Ljava/lang/String;)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInt", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInt", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLong", "(I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLong", "(Ljava/lang/String;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFloat", "(I)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFloat", "(Ljava/lang/String;)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDouble", "(I)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDouble", "(Ljava/lang/String;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBytes", "(I)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBytes", "(Ljava/lang/String;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "last", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "first", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initProperties", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "execute", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "execute", "(Ljava/sql/Connection;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBoolean", "(Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setByte", "(Ljava/lang/String;B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setShort", "(Ljava/lang/String;S)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInt", "(Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLong", "(Ljava/lang/String;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFloat", "(Ljava/lang/String;F)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDouble", "(Ljava/lang/String;D)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unwrap", "(Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObject", "(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObject", "(ILjava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObject", "(ILjava/util/Map;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObject", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObject", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObject", "(I)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRef", "(I)Ljava/sql/Ref;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRef", "(Ljava/lang/String;)Ljava/sql/Ref;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "release", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "previous", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getArray", "(Ljava/lang/String;)Ljava/sql/Array;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getArray", "(I)Ljava/sql/Array;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "absolute", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setURL", "(ILjava/net/URL;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTimestamp", "(Ljava/lang/String;)Ljava/sql/Timestamp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTimestamp", "(I)Ljava/sql/Timestamp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTimestamp", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Timestamp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTimestamp", "(ILjava/util/Calendar;)Ljava/sql/Timestamp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "commit", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getString", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getString", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBigDecimal", "(Ljava/lang/String;I)Ljava/math/BigDecimal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBigDecimal", "(II)Ljava/math/BigDecimal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBigDecimal", "(I)Ljava/math/BigDecimal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBigDecimal", "(Ljava/lang/String;)Ljava/math/BigDecimal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTime", "(I)Ljava/sql/Time;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTime", "(Ljava/lang/String;)Ljava/sql/Time;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTime", "(ILjava/util/Calendar;)Ljava/sql/Time;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTime", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Time;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTime", "(Ljava/lang/String;Ljava/sql/Time;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTime", "(Ljava/lang/String;Ljava/sql/Time;Ljava/util/Calendar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateTime", "(ILjava/sql/Time;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateTime", "(Ljava/lang/String;Ljava/sql/Time;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDate", "(Ljava/lang/String;Ljava/sql/Date;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDate", "(Ljava/lang/String;Ljava/sql/Date;Ljava/util/Calendar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDate", "(ILjava/util/Calendar;)Ljava/sql/Date;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDate", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Date;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDate", "(I)Ljava/sql/Date;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDate", "(Ljava/lang/String;)Ljava/sql/Date;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toCollection", "(Ljava/lang/String;)Ljava/util/Collection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toCollection", "(I)Ljava/util/Collection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toCollection", "()Ljava/util/Collection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getURL", "(I)Ljava/net/URL;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getURL", "(Ljava/lang/String;)Ljava/net/URL;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNumeric", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "relative", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initContainer", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkTransactionalWriter", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "establishTransactionalWriter", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildTableName", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTemporal", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "convertBoolean", "(Ljava/lang/Object;II)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "convertNumeric", "(Ljava/lang/Object;II)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "convertTemporal", "(Ljava/lang/Object;II)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeRowOriginal", "(Lcom/sun/rowset/internal/Row;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeCurrentRow", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRowInserted", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkCursor", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCurrentRow", "()Lcom/sun/rowset/internal/BaseRow;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColIdxByName", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLastValueNull", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setConnection", "(Ljava/sql/Connection;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initMetaData", "(Ljavax/sql/rowset/RowSetMetaDataImpl;Ljava/sql/ResultSetMetaData;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rowSetPopulated", "(Ljavax/sql/RowSetEvent;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalNext", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalPrevious", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalFirst", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalLast", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharacterStream", "(I)Ljava/io/Reader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConnection", "()Ljava/sql/Connection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rollback", "(Ljava/sql/Savepoint;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rollback", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isClosed", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isBinary", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isBoolean", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCommand", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNull", "(Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNull", "(Ljava/lang/String;ILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBigDecimal", "(Ljava/lang/String;Ljava/math/BigDecimal;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setString", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBytes", "(Ljava/lang/String;[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;Ljava/util/Calendar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNCharacterStream", "(ILjava/io/Reader;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNCharacterStream", "(ILjava/io/Reader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBlob", "(Ljava/lang/String;Ljava/io/InputStream;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBlob", "(ILjava/io/InputStream;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBlob", "(Ljava/lang/String;Ljava/sql/Blob;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBlob", "(Ljava/lang/String;Ljava/io/InputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBlob", "(ILjava/io/InputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setClob", "(Ljava/lang/String;Ljava/sql/Clob;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setClob", "(Ljava/lang/String;Ljava/io/Reader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setClob", "(ILjava/io/Reader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setClob", "(Ljava/lang/String;Ljava/io/Reader;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setClob", "(ILjava/io/Reader;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSQLXML", "(Ljava/lang/String;Ljava/sql/SQLXML;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSQLXML", "(ILjava/sql/SQLXML;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRowId", "(Ljava/lang/String;Ljava/sql/RowId;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRowId", "(ILjava/sql/RowId;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNString", "(ILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNString", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNClob", "(ILjava/sql/NClob;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNClob", "(Ljava/lang/String;Ljava/io/Reader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNClob", "(ILjava/io/Reader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNClob", "(Ljava/lang/String;Ljava/sql/NClob;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNClob", "(ILjava/io/Reader;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNClob", "(Ljava/lang/String;Ljava/io/Reader;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wasNull", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAsciiStream", "(I)Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAsciiStream", "(Ljava/lang/String;)Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUnicodeStream", "(I)Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUnicodeStream", "(Ljava/lang/String;)Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBinaryStream", "(I)Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBinaryStream", "(Ljava/lang/String;)Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCursorName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findColumn", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isBeforeFirst", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAfterLast", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFirst", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLast", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "beforeFirst", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "afterLast", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRow", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rowUpdated", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rowInserted", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rowDeleted", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateNull", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateNull", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateBoolean", "(IZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateBoolean", "(Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateByte", "(Ljava/lang/String;B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateByte", "(IB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateShort", "(Ljava/lang/String;S)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateShort", "(IS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateInt", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateInt", "(Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateLong", "(IJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateLong", "(Ljava/lang/String;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateFloat", "(IF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateFloat", "(Ljava/lang/String;F)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateDouble", "(ID)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateDouble", "(Ljava/lang/String;D)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateBigDecimal", "(ILjava/math/BigDecimal;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateBigDecimal", "(Ljava/lang/String;Ljava/math/BigDecimal;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateString", "(ILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateString", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateDate", "(Ljava/lang/String;Ljava/sql/Date;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateDate", "(ILjava/sql/Date;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateTimestamp", "(ILjava/sql/Timestamp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateAsciiStream", "(ILjava/io/InputStream;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateAsciiStream", "(ILjava/io/InputStream;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateAsciiStream", "(ILjava/io/InputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateBinaryStream", "(ILjava/io/InputStream;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateBinaryStream", "(ILjava/io/InputStream;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateBinaryStream", "(ILjava/io/InputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateCharacterStream", "(ILjava/io/Reader;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateCharacterStream", "(ILjava/io/Reader;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateCharacterStream", "(ILjava/io/Reader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateObject", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateObject", "(ILjava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateObject", "(ILjava/lang/Object;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateObject", "(Ljava/lang/String;Ljava/lang/Object;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertRow", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateRow", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deleteRow", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "refreshRow", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cancelRowUpdates", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "moveToInsertRow", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "moveToCurrentRow", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlob", "(I)Ljava/sql/Blob;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlob", "(Ljava/lang/String;)Ljava/sql/Blob;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClob", "(I)Ljava/sql/Clob;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClob", "(Ljava/lang/String;)Ljava/sql/Clob;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateRef", "(Ljava/lang/String;Ljava/sql/Ref;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateRef", "(ILjava/sql/Ref;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateBlob", "(ILjava/io/InputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateBlob", "(Ljava/lang/String;Ljava/io/InputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateBlob", "(Ljava/lang/String;Ljava/sql/Blob;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateBlob", "(ILjava/sql/Blob;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateBlob", "(Ljava/lang/String;Ljava/io/InputStream;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateBlob", "(ILjava/io/InputStream;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateClob", "(ILjava/io/Reader;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateClob", "(Ljava/lang/String;Ljava/io/Reader;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateClob", "(Ljava/lang/String;Ljava/sql/Clob;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateClob", "(Ljava/lang/String;Ljava/io/Reader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateClob", "(ILjava/io/Reader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateClob", "(ILjava/sql/Clob;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateArray", "(ILjava/sql/Array;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateArray", "(Ljava/lang/String;Ljava/sql/Array;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowId", "(I)Ljava/sql/RowId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowId", "(Ljava/lang/String;)Ljava/sql/RowId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateRowId", "(ILjava/sql/RowId;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateRowId", "(Ljava/lang/String;Ljava/sql/RowId;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateNString", "(ILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateNString", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateNClob", "(ILjava/io/Reader;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateNClob", "(Ljava/lang/String;Ljava/io/Reader;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateNClob", "(ILjava/io/Reader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateNClob", "(Ljava/lang/String;Ljava/io/Reader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateNClob", "(ILjava/sql/NClob;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateNClob", "(Ljava/lang/String;Ljava/sql/NClob;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNClob", "(Ljava/lang/String;)Ljava/sql/NClob;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNClob", "(I)Ljava/sql/NClob;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSQLXML", "(Ljava/lang/String;)Ljava/sql/SQLXML;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSQLXML", "(I)Ljava/sql/SQLXML;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateSQLXML", "(Ljava/lang/String;Ljava/sql/SQLXML;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateSQLXML", "(ILjava/sql/SQLXML;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNString", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNString", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNCharacterStream", "(I)Ljava/io/Reader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateNCharacterStream", "(ILjava/io/Reader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateNCharacterStream", "(ILjava/io/Reader;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStatement", "()Ljava/sql/Statement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHoldability", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isWrapperFor", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMetaData", "()Ljava/sql/ResultSetMetaData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWarnings", "()Ljava/sql/SQLWarning;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearWarnings", "()V"));
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
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isString", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMatchColumnNames", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMatchColumn", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMatchColumn", "([I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMatchColumn", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMatchColumn", "([Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMatchColumnIndexes", "()[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unsetMatchColumn", "([Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unsetMatchColumn", "([I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unsetMatchColumn", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unsetMatchColumn", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOriginal", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "populate", "(Ljava/sql/ResultSet;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "populate", "(Ljava/sql/ResultSet;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setObject", "(Ljava/lang/String;Ljava/lang/Object;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setObject", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setObject", "(Ljava/lang/String;Ljava/lang/Object;II)V"));
	}

	[JniSignatureAttribute("Ljavax/sql/rowset/spi/SyncProvider;", "private")]
	public Dova.JDK.javax.sql.rowset.spi.SyncProvider provider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.rowset.spi.SyncProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/sql/RowSetReader;", "private")]
	public Dova.JDK.javax.sql.RowSetReader rowSetReader_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.RowSetReader>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/sql/RowSetWriter;", "private")]
	public Dova.JDK.javax.sql.RowSetWriter rowSetWriter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.RowSetWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/sql/Connection;", "private transient")]
	public Dova.JDK.java.sql.Connection conn_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Connection>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/sql/ResultSetMetaData;", "private transient")]
	public Dova.JDK.java.sql.ResultSetMetaData RSMD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.sql.ResultSetMetaData>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/sql/rowset/RowSetMetaDataImpl;", "private")]
	public Dova.JDK.javax.sql.rowset.RowSetMetaDataImpl RowSetMD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.rowset.RowSetMetaDataImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> keyCols_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String tableName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Vector;", "private")]
	public Dova.JDK.java.util.Vector rvh_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int cursorPos_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int absolutePos_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int numDeleted_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int numRows_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/rowset/internal/InsertRow;", "private")]
	public Dova.JDK.com.sun.rowset.@internal.InsertRow insertRow_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.rowset.@internal.InsertRow>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool onInsertRow_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int currentRow_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool lastValueNull_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("Ljava/sql/SQLWarning;", "private")]
	public Dova.JDK.java.sql.SQLWarning sqlwarn_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.sql.SQLWarning>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String strMatchColumn_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int iMatchColumn_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("Ljavax/sql/rowset/RowSetWarning;", "private")]
	public Dova.JDK.javax.sql.rowset.RowSetWarning rowsetWarning_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.rowset.RowSetWarning>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String DEFAULT_SYNC_PROVIDER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool dbmslocatorsUpdateCopy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("Ljava/sql/ResultSet;", "private transient")]
	public Dova.JDK.java.sql.ResultSet resultSet_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.sql.ResultSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int endPos_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[24]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[24], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int prevEndPos_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[25]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[25], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int startPos_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[26]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[26], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int startPrev_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[27]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[27], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int pageSize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[28]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[28], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int maxRowsreached_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[29]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[29], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool pagenotend_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[30]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[30], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool onFirstPage_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[31]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[31], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool onLastPage_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[32]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[32], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int populatecallcount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[33]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[33], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int totalRows_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[34]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[34], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool callWithCon_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[35]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[35], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/rowset/internal/CachedRowSetReader;", "private")]
	public Dova.JDK.com.sun.rowset.@internal.CachedRowSetReader crsReader_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[36]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.rowset.@internal.CachedRowSetReader>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Vector;", "private")]
	public Dova.JDK.java.util.Vector iMatchColumns_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[37]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Vector;", "private")]
	public Dova.JDK.java.util.Vector strMatchColumns_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[38]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool tXWriter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[39]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[39], value);
		}
	}

	[JniSignatureAttribute("Ljavax/sql/rowset/spi/TransactionalWriter;", "private")]
	public Dova.JDK.javax.sql.rowset.spi.TransactionalWriter tWriter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[40]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.rowset.spi.TransactionalWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/rowset/JdbcRowSetResourceBundle;", "protected transient")]
	public Dova.JDK.com.sun.rowset.JdbcRowSetResourceBundle resBundle_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[41]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.rowset.JdbcRowSetResourceBundle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[41], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool updateOnInsert_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[42]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[42], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[43]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[43], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CachedRowSetImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public CachedRowSetImpl() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljava/util/Hashtable;)V", "public")]
	public CachedRowSetImpl(Dova.JDK.java.util.Hashtable arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/rowset/CachedRowSetImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)V", "private")]
	public void checkIndex(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "protected")]
	public Dova.JDK.java.lang.Object clone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(I[B)V", "public")]
	public void updateBytes(int arg0, JavaArray<byte> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[B)V", "public")]
	public void updateBytes(Dova.JDK.java.lang.String arg0, JavaArray<byte> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
	public bool getBoolean(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool getBoolean(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)B", "public")]
	public byte getByte(int arg0)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)B", "public")]
	public byte getByte(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)S", "public")]
	public short getShort(int arg0)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)S", "public")]
	public short getShort(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getInt(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int getInt(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)J", "public")]
	public long getLong(int arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)J", "public")]
	public long getLong(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)F", "public")]
	public float getFloat(int arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)F", "public")]
	public float getFloat(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)D", "public")]
	public double getDouble(int arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)D", "public")]
	public double getDouble(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)[B", "public")]
	public JavaArray<byte> getBytes(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[B", "public")]
	public JavaArray<byte> getBytes(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int size()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool next()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool last()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool first()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void initProperties()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24]);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void execute()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26]);
	}

	[JniSignatureAttribute("(Ljava/sql/Connection;)V", "public")]
	public void execute(Dova.JDK.java.sql.Connection arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)V", "public")]
	public void setBoolean(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;B)V", "public")]
	public void setByte(Dova.JDK.java.lang.String arg0, byte arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;S)V", "public")]
	public void setShort(Dova.JDK.java.lang.String arg0, short arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "public")]
	public void setInt(Dova.JDK.java.lang.String arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;J)V", "public")]
	public void setLong(Dova.JDK.java.lang.String arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;F)V", "public")]
	public void setFloat(Dova.JDK.java.lang.String arg0, float arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;D)V", "public")]
	public void setDouble(Dova.JDK.java.lang.String arg0, double arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object unwrap(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getObject(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/Class;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getObject(int arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(ILjava/util/Map;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getObject(int arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getObject(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getObject(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getObject(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/sql/Ref;", "public")]
	public Dova.JDK.java.sql.Ref getRef(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Ref>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/sql/Ref;", "public")]
	public Dova.JDK.java.sql.Ref getRef(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Ref>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void release()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45]);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool previous()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[46]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/sql/Array;", "public")]
	public Dova.JDK.java.sql.Array getArray(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Array>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/sql/Array;", "public")]
	public Dova.JDK.java.sql.Array getArray(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Array>(ret);
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool absolute(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/net/URL;)V", "public")]
	public void setURL(int arg0, Dova.JDK.java.net.URL arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/sql/Timestamp;", "public")]
	public Dova.JDK.java.sql.Timestamp getTimestamp(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Timestamp>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/sql/Timestamp;", "public")]
	public Dova.JDK.java.sql.Timestamp getTimestamp(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Timestamp>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Timestamp;", "public")]
	public Dova.JDK.java.sql.Timestamp getTimestamp(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Calendar arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Timestamp>(ret);
	}

	[JniSignatureAttribute("(ILjava/util/Calendar;)Ljava/sql/Timestamp;", "public")]
	public Dova.JDK.java.sql.Timestamp getTimestamp(int arg0, Dova.JDK.java.util.Calendar arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Timestamp>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void commit()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55]);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getString(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getString(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Ljava/math/BigDecimal;", "public")]
	public Dova.JDK.java.math.BigDecimal getBigDecimal(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigDecimal>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/math/BigDecimal;", "public")]
	public Dova.JDK.java.math.BigDecimal getBigDecimal(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigDecimal>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/math/BigDecimal;", "public")]
	public Dova.JDK.java.math.BigDecimal getBigDecimal(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigDecimal>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/math/BigDecimal;", "public")]
	public Dova.JDK.java.math.BigDecimal getBigDecimal(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigDecimal>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/sql/Time;", "public")]
	public Dova.JDK.java.sql.Time getTime(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Time>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/sql/Time;", "public")]
	public Dova.JDK.java.sql.Time getTime(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Time>(ret);
	}

	[JniSignatureAttribute("(ILjava/util/Calendar;)Ljava/sql/Time;", "public")]
	public Dova.JDK.java.sql.Time getTime(int arg0, Dova.JDK.java.util.Calendar arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[64], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Time>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Time;", "public")]
	public Dova.JDK.java.sql.Time getTime(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Calendar arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Time>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/Time;)V", "public")]
	public void setTime(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.Time arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[66], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/Time;Ljava/util/Calendar;)V", "public")]
	public void setTime(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.Time arg1, Dova.JDK.java.util.Calendar arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[67], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/sql/Time;)V", "public")]
	public void updateTime(int arg0, Dova.JDK.java.sql.Time arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[68], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/Time;)V", "public")]
	public void updateTime(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.Time arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[69], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/Date;)V", "public")]
	public void setDate(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.Date arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[70], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/Date;Ljava/util/Calendar;)V", "public")]
	public void setDate(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.Date arg1, Dova.JDK.java.util.Calendar arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[71], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/util/Calendar;)Ljava/sql/Date;", "public")]
	public Dova.JDK.java.sql.Date getDate(int arg0, Dova.JDK.java.util.Calendar arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[72], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Date>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Date;", "public")]
	public Dova.JDK.java.sql.Date getDate(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Calendar arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[73], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Date>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/sql/Date;", "public")]
	public Dova.JDK.java.sql.Date getDate(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[74], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Date>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/sql/Date;", "public")]
	public Dova.JDK.java.sql.Date getDate(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[75], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Date>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Collection;", "public")]
	public Dova.JDK.java.util.Collection toCollection(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[76], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/util/Collection;", "public")]
	public Dova.JDK.java.util.Collection toCollection(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[77], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Collection;", "public")]
	public Dova.JDK.java.util.Collection toCollection()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[78]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/net/URL;", "public")]
	public Dova.JDK.java.net.URL getURL(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[79], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/net/URL;", "public")]
	public Dova.JDK.java.net.URL getURL(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[80], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
	}

	[JniSignatureAttribute("(I)Z", "private")]
	public bool isNumeric(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[81], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool relative(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[82], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void initContainer()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[83]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void checkTransactionalWriter()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[84]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void establishTransactionalWriter()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[85]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String buildTableName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[86], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Z", "private")]
	public bool isTemporal(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[87], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;II)Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object convertBoolean(Dova.JDK.java.lang.Object arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[88], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;II)Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object convertNumeric(Dova.JDK.java.lang.Object arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[89], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;II)Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object convertTemporal(Dova.JDK.java.lang.Object arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[90], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/rowset/internal/Row;)V", "private")]
	public void makeRowOriginal(Dova.JDK.com.sun.rowset.@internal.Row arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[91], arg0);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void removeCurrentRow()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[92]);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setRowInserted(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[93], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void checkCursor()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[94]);
	}

	[JniSignatureAttribute("()Lcom/sun/rowset/internal/BaseRow;", "protected")]
	public Dova.JDK.com.sun.rowset.@internal.BaseRow getCurrentRow()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[95]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.rowset.@internal.BaseRow>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "private")]
	public int getColIdxByName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[96], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "private")]
	public void setLastValueNull(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[97], arg0);
	}

	[JniSignatureAttribute("(Ljava/sql/Connection;)V", "private")]
	public void setConnection(Dova.JDK.java.sql.Connection arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[98], arg0);
	}

	[JniSignatureAttribute("(Ljavax/sql/rowset/RowSetMetaDataImpl;Ljava/sql/ResultSetMetaData;)V", "private")]
	public void initMetaData(Dova.JDK.javax.sql.rowset.RowSetMetaDataImpl arg0, Dova.JDK.java.sql.ResultSetMetaData arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[99], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/sql/RowSetEvent;I)V", "public")]
	public void rowSetPopulated(Dova.JDK.javax.sql.RowSetEvent arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[100], arg0, arg1);
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool internalNext()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[101]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool internalPrevious()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[102]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool internalFirst()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[103]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool internalLast()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[104]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;)V", "public")]
	public void setCharacterStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[105], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;I)V", "public")]
	public void setCharacterStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[106], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(I)Ljava/io/Reader;", "public")]
	public Dova.JDK.java.io.Reader getCharacterStream(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[107], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.Reader>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/io/Reader;", "public")]
	public Dova.JDK.java.io.Reader getCharacterStream(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[108], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.Reader>(ret);
	}

	[JniSignatureAttribute("()Ljava/sql/Connection;", "public")]
	public Dova.JDK.java.sql.Connection getConnection()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[109]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Connection>(ret);
	}

	[JniSignatureAttribute("(Ljava/sql/Savepoint;)V", "public")]
	public void rollback(Dova.JDK.java.sql.Savepoint arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[110], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void rollback()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[111]);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isClosed()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[112]);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "private")]
	public bool isBinary(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[113], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "private")]
	public bool isBoolean(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[114], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setCommand(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[115], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "public")]
	public void setNull(Dova.JDK.java.lang.String arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[116], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)V", "public")]
	public void setNull(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[117], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/math/BigDecimal;)V", "public")]
	public void setBigDecimal(Dova.JDK.java.lang.String arg0, Dova.JDK.java.math.BigDecimal arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[118], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void setString(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[119], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[B)V", "public")]
	public void setBytes(Dova.JDK.java.lang.String arg0, JavaArray<byte> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[120], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/Timestamp;Ljava/util/Calendar;)V", "public")]
	public void setTimestamp(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.Timestamp arg1, Dova.JDK.java.util.Calendar arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[121], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/Timestamp;)V", "public")]
	public void setTimestamp(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.Timestamp arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[122], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;I)V", "public")]
	public void setAsciiStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[123], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;)V", "public")]
	public void setAsciiStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[124], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;I)V", "public")]
	public void setBinaryStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[125], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;)V", "public")]
	public void setBinaryStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[126], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;J)V", "public")]
	public void setNCharacterStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[127], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/io/Reader;J)V", "public")]
	public void setNCharacterStream(int arg0, Dova.JDK.java.io.Reader arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[128], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;)V", "public")]
	public void setNCharacterStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[129], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/io/Reader;)V", "public")]
	public void setNCharacterStream(int arg0, Dova.JDK.java.io.Reader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[130], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;J)V", "public")]
	public void setBlob(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[131], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/io/InputStream;J)V", "public")]
	public void setBlob(int arg0, Dova.JDK.java.io.InputStream arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[132], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/Blob;)V", "public")]
	public void setBlob(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.Blob arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[133], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;)V", "public")]
	public void setBlob(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[134], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/io/InputStream;)V", "public")]
	public void setBlob(int arg0, Dova.JDK.java.io.InputStream arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[135], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/Clob;)V", "public")]
	public void setClob(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.Clob arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[136], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;)V", "public")]
	public void setClob(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[137], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/io/Reader;)V", "public")]
	public void setClob(int arg0, Dova.JDK.java.io.Reader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[138], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;J)V", "public")]
	public void setClob(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[139], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/io/Reader;J)V", "public")]
	public void setClob(int arg0, Dova.JDK.java.io.Reader arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[140], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/SQLXML;)V", "public")]
	public void setSQLXML(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.SQLXML arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[141], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/sql/SQLXML;)V", "public")]
	public void setSQLXML(int arg0, Dova.JDK.java.sql.SQLXML arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[142], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/RowId;)V", "public")]
	public void setRowId(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.RowId arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[143], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/sql/RowId;)V", "public")]
	public void setRowId(int arg0, Dova.JDK.java.sql.RowId arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[144], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/lang/String;)V", "public")]
	public void setNString(int arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[145], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void setNString(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[146], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/sql/NClob;)V", "public")]
	public void setNClob(int arg0, Dova.JDK.java.sql.NClob arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[147], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;)V", "public")]
	public void setNClob(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[148], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/io/Reader;)V", "public")]
	public void setNClob(int arg0, Dova.JDK.java.io.Reader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[149], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/NClob;)V", "public")]
	public void setNClob(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.NClob arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[150], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/io/Reader;J)V", "public")]
	public void setNClob(int arg0, Dova.JDK.java.io.Reader arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[151], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;J)V", "public")]
	public void setNClob(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[152], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool wasNull()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[153]);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/io/InputStream;", "public")]
	public Dova.JDK.java.io.InputStream getAsciiStream(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[154], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/io/InputStream;", "public")]
	public Dova.JDK.java.io.InputStream getAsciiStream(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[155], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/io/InputStream;", "public")]
	public Dova.JDK.java.io.InputStream getUnicodeStream(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[156], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/io/InputStream;", "public")]
	public Dova.JDK.java.io.InputStream getUnicodeStream(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[157], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/io/InputStream;", "public")]
	public Dova.JDK.java.io.InputStream getBinaryStream(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[158], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/io/InputStream;", "public")]
	public Dova.JDK.java.io.InputStream getBinaryStream(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[159], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getCursorName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[160]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int findColumn(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[161], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isBeforeFirst()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[162]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isAfterLast()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[163]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isFirst()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[164]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isLast()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[165]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void beforeFirst()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[166]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void afterLast()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[167]);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getRow()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[168]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool rowUpdated()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[169]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool rowInserted()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[170]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool rowDeleted()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[171]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void updateNull(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[172], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void updateNull(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[173], arg0);
	}

	[JniSignatureAttribute("(IZ)V", "public")]
	public void updateBoolean(int arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[174], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)V", "public")]
	public void updateBoolean(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[175], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;B)V", "public")]
	public void updateByte(Dova.JDK.java.lang.String arg0, byte arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[176], arg0, arg1);
	}

	[JniSignatureAttribute("(IB)V", "public")]
	public void updateByte(int arg0, byte arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[177], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;S)V", "public")]
	public void updateShort(Dova.JDK.java.lang.String arg0, short arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[178], arg0, arg1);
	}

	[JniSignatureAttribute("(IS)V", "public")]
	public void updateShort(int arg0, short arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[179], arg0, arg1);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void updateInt(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[180], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "public")]
	public void updateInt(Dova.JDK.java.lang.String arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[181], arg0, arg1);
	}

	[JniSignatureAttribute("(IJ)V", "public")]
	public void updateLong(int arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[182], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;J)V", "public")]
	public void updateLong(Dova.JDK.java.lang.String arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[183], arg0, arg1);
	}

	[JniSignatureAttribute("(IF)V", "public")]
	public void updateFloat(int arg0, float arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[184], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;F)V", "public")]
	public void updateFloat(Dova.JDK.java.lang.String arg0, float arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[185], arg0, arg1);
	}

	[JniSignatureAttribute("(ID)V", "public")]
	public void updateDouble(int arg0, double arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[186], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;D)V", "public")]
	public void updateDouble(Dova.JDK.java.lang.String arg0, double arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[187], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/math/BigDecimal;)V", "public")]
	public void updateBigDecimal(int arg0, Dova.JDK.java.math.BigDecimal arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[188], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/math/BigDecimal;)V", "public")]
	public void updateBigDecimal(Dova.JDK.java.lang.String arg0, Dova.JDK.java.math.BigDecimal arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[189], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/lang/String;)V", "public")]
	public void updateString(int arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[190], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void updateString(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[191], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/Date;)V", "public")]
	public void updateDate(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.Date arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[192], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/sql/Date;)V", "public")]
	public void updateDate(int arg0, Dova.JDK.java.sql.Date arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[193], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/sql/Timestamp;)V", "public")]
	public void updateTimestamp(int arg0, Dova.JDK.java.sql.Timestamp arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[194], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/Timestamp;)V", "public")]
	public void updateTimestamp(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.Timestamp arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[195], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;J)V", "public")]
	public void updateAsciiStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[196], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/io/InputStream;J)V", "public")]
	public void updateAsciiStream(int arg0, Dova.JDK.java.io.InputStream arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[197], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/io/InputStream;I)V", "public")]
	public void updateAsciiStream(int arg0, Dova.JDK.java.io.InputStream arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[198], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;I)V", "public")]
	public void updateAsciiStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[199], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;)V", "public")]
	public void updateAsciiStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[200], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/io/InputStream;)V", "public")]
	public void updateAsciiStream(int arg0, Dova.JDK.java.io.InputStream arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[201], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/io/InputStream;J)V", "public")]
	public void updateBinaryStream(int arg0, Dova.JDK.java.io.InputStream arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[202], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;J)V", "public")]
	public void updateBinaryStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[203], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;I)V", "public")]
	public void updateBinaryStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[204], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/io/InputStream;I)V", "public")]
	public void updateBinaryStream(int arg0, Dova.JDK.java.io.InputStream arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[205], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;)V", "public")]
	public void updateBinaryStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[206], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/io/InputStream;)V", "public")]
	public void updateBinaryStream(int arg0, Dova.JDK.java.io.InputStream arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[207], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;I)V", "public")]
	public void updateCharacterStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[208], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/io/Reader;J)V", "public")]
	public void updateCharacterStream(int arg0, Dova.JDK.java.io.Reader arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[209], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;J)V", "public")]
	public void updateCharacterStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[210], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/io/Reader;I)V", "public")]
	public void updateCharacterStream(int arg0, Dova.JDK.java.io.Reader arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[211], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/io/Reader;)V", "public")]
	public void updateCharacterStream(int arg0, Dova.JDK.java.io.Reader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[212], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;)V", "public")]
	public void updateCharacterStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[213], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public")]
	public void updateObject(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[214], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/lang/Object;)V", "public")]
	public void updateObject(int arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[215], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/lang/Object;I)V", "public")]
	public void updateObject(int arg0, Dova.JDK.java.lang.Object arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[216], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;I)V", "public")]
	public void updateObject(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[217], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()V", "public")]
	public void insertRow()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[218]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void updateRow()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[219]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void deleteRow()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[220]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void refreshRow()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[221]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void cancelRowUpdates()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[222]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void moveToInsertRow()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[223]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void moveToCurrentRow()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[224]);
	}

	[JniSignatureAttribute("(I)Ljava/sql/Blob;", "public")]
	public Dova.JDK.java.sql.Blob getBlob(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[225], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Blob>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/sql/Blob;", "public")]
	public Dova.JDK.java.sql.Blob getBlob(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[226], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Blob>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/sql/Clob;", "public")]
	public Dova.JDK.java.sql.Clob getClob(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[227], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Clob>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/sql/Clob;", "public")]
	public Dova.JDK.java.sql.Clob getClob(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[228], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Clob>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/Ref;)V", "public")]
	public void updateRef(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.Ref arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[229], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/sql/Ref;)V", "public")]
	public void updateRef(int arg0, Dova.JDK.java.sql.Ref arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[230], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/io/InputStream;)V", "public")]
	public void updateBlob(int arg0, Dova.JDK.java.io.InputStream arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[231], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;)V", "public")]
	public void updateBlob(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[232], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/Blob;)V", "public")]
	public void updateBlob(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.Blob arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[233], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/sql/Blob;)V", "public")]
	public void updateBlob(int arg0, Dova.JDK.java.sql.Blob arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[234], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;J)V", "public")]
	public void updateBlob(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[235], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/io/InputStream;J)V", "public")]
	public void updateBlob(int arg0, Dova.JDK.java.io.InputStream arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[236], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/io/Reader;J)V", "public")]
	public void updateClob(int arg0, Dova.JDK.java.io.Reader arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[237], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;J)V", "public")]
	public void updateClob(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[238], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/Clob;)V", "public")]
	public void updateClob(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.Clob arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[239], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;)V", "public")]
	public void updateClob(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[240], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/io/Reader;)V", "public")]
	public void updateClob(int arg0, Dova.JDK.java.io.Reader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[241], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/sql/Clob;)V", "public")]
	public void updateClob(int arg0, Dova.JDK.java.sql.Clob arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[242], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/sql/Array;)V", "public")]
	public void updateArray(int arg0, Dova.JDK.java.sql.Array arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[243], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/Array;)V", "public")]
	public void updateArray(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.Array arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[244], arg0, arg1);
	}

	[JniSignatureAttribute("(I)Ljava/sql/RowId;", "public")]
	public Dova.JDK.java.sql.RowId getRowId(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[245], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.RowId>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/sql/RowId;", "public")]
	public Dova.JDK.java.sql.RowId getRowId(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[246], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.RowId>(ret);
	}

	[JniSignatureAttribute("(ILjava/sql/RowId;)V", "public")]
	public void updateRowId(int arg0, Dova.JDK.java.sql.RowId arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[247], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/RowId;)V", "public")]
	public void updateRowId(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.RowId arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[248], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/lang/String;)V", "public")]
	public void updateNString(int arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[249], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void updateNString(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[250], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/io/Reader;J)V", "public")]
	public void updateNClob(int arg0, Dova.JDK.java.io.Reader arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[251], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;J)V", "public")]
	public void updateNClob(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[252], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/io/Reader;)V", "public")]
	public void updateNClob(int arg0, Dova.JDK.java.io.Reader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[253], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;)V", "public")]
	public void updateNClob(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[254], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/sql/NClob;)V", "public")]
	public void updateNClob(int arg0, Dova.JDK.java.sql.NClob arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[255], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/NClob;)V", "public")]
	public void updateNClob(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.NClob arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[256], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/sql/NClob;", "public")]
	public Dova.JDK.java.sql.NClob getNClob(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[257], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.NClob>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/sql/NClob;", "public")]
	public Dova.JDK.java.sql.NClob getNClob(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[258], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.NClob>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/sql/SQLXML;", "public")]
	public Dova.JDK.java.sql.SQLXML getSQLXML(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[259], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.SQLXML>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/sql/SQLXML;", "public")]
	public Dova.JDK.java.sql.SQLXML getSQLXML(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[260], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.SQLXML>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/SQLXML;)V", "public")]
	public void updateSQLXML(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.SQLXML arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[261], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/sql/SQLXML;)V", "public")]
	public void updateSQLXML(int arg0, Dova.JDK.java.sql.SQLXML arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[262], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getNString(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[263], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getNString(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[264], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/io/Reader;", "public")]
	public Dova.JDK.java.io.Reader getNCharacterStream(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[265], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.Reader>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/io/Reader;", "public")]
	public Dova.JDK.java.io.Reader getNCharacterStream(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[266], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.Reader>(ret);
	}

	[JniSignatureAttribute("(ILjava/io/Reader;)V", "public")]
	public void updateNCharacterStream(int arg0, Dova.JDK.java.io.Reader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[267], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;)V", "public")]
	public void updateNCharacterStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[268], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;J)V", "public")]
	public void updateNCharacterStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[269], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/io/Reader;J)V", "public")]
	public void updateNCharacterStream(int arg0, Dova.JDK.java.io.Reader arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[270], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Ljava/sql/Statement;", "public")]
	public Dova.JDK.java.sql.Statement getStatement()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[271]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Statement>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getHoldability()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[272]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public")]
	public bool isWrapperFor(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[273], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/sql/ResultSetMetaData;", "public")]
	public Dova.JDK.java.sql.ResultSetMetaData getMetaData()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[274]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.ResultSetMetaData>(ret);
	}

	[JniSignatureAttribute("()Ljava/sql/SQLWarning;", "public")]
	public Dova.JDK.java.sql.SQLWarning getWarnings()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[275]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.SQLWarning>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void clearWarnings()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[276]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void acceptChanges()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[277]);
	}

	[JniSignatureAttribute("(Ljava/sql/Connection;)V", "public")]
	public void acceptChanges(Dova.JDK.java.sql.Connection arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[278], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void restoreOriginal()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[279]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void undoDelete()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[280]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void undoInsert()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[281]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void undoUpdate()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[282]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
	public bool columnUpdated(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[283], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool columnUpdated(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[284], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/sql/rowset/spi/SyncProvider;", "public")]
	public Dova.JDK.javax.sql.rowset.spi.SyncProvider getSyncProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[285]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.rowset.spi.SyncProvider>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setSyncProvider(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[286], arg0);
	}

	[JniSignatureAttribute("(Ljavax/sql/RowSetMetaData;)V", "public")]
	public void setMetaData(Dova.JDK.javax.sql.RowSetMetaData arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[287], arg0);
	}

	[JniSignatureAttribute("()Ljava/sql/ResultSet;", "public")]
	public Dova.JDK.java.sql.ResultSet getOriginal()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[288]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.ResultSet>(ret);
	}

	[JniSignatureAttribute("()Ljava/sql/ResultSet;", "public")]
	public Dova.JDK.java.sql.ResultSet getOriginalRow()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[289]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.ResultSet>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void setOriginalRow()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[290]);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getTableName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[291]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setTableName(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[292], arg0);
	}

	[JniSignatureAttribute("()[I", "public")]
	public JavaArray<int> getKeyColumns()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[293]);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("([I)V", "public")]
	public void setKeyColumns(JavaArray<int> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[294], arg0);
	}

	[JniSignatureAttribute("()Ljavax/sql/RowSet;", "public")]
	public Dova.JDK.javax.sql.RowSet createShared()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[295]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.RowSet>(ret);
	}

	[JniSignatureAttribute("()Ljavax/sql/rowset/CachedRowSet;", "public")]
	public Dova.JDK.javax.sql.rowset.CachedRowSet createCopy()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[296]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.rowset.CachedRowSet>(ret);
	}

	[JniSignatureAttribute("()Ljavax/sql/rowset/CachedRowSet;", "public")]
	public Dova.JDK.javax.sql.rowset.CachedRowSet createCopySchema()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[297]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.rowset.CachedRowSet>(ret);
	}

	[JniSignatureAttribute("()Ljavax/sql/rowset/CachedRowSet;", "public")]
	public Dova.JDK.javax.sql.rowset.CachedRowSet createCopyNoConstraints()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[298]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.rowset.CachedRowSet>(ret);
	}

	[JniSignatureAttribute("()Ljavax/sql/rowset/RowSetWarning;", "public")]
	public Dova.JDK.javax.sql.rowset.RowSetWarning getRowSetWarnings()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[299]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.rowset.RowSetWarning>(ret);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setPageSize(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[300], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getPageSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[301]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool nextPage()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[302]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool previousPage()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[303]);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "private")]
	public bool isString(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[304], arg0);
		return ret;
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getMatchColumnNames()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[305]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setMatchColumn(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[306], arg0);
	}

	[JniSignatureAttribute("([I)V", "public")]
	public void setMatchColumn(JavaArray<int> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[307], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setMatchColumn(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[308], arg0);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)V", "public")]
	public void setMatchColumn(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[309], arg0);
	}

	[JniSignatureAttribute("()[I", "public")]
	public JavaArray<int> getMatchColumnIndexes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[310]);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)V", "public")]
	public void unsetMatchColumn(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[311], arg0);
	}

	[JniSignatureAttribute("([I)V", "public")]
	public void unsetMatchColumn(JavaArray<int> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[312], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void unsetMatchColumn(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[313], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void unsetMatchColumn(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[314], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void setOriginal()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[315]);
	}

	[JniSignatureAttribute("(Ljava/sql/ResultSet;I)V", "public")]
	public void populate(Dova.JDK.java.sql.ResultSet arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[316], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/sql/ResultSet;)V", "public")]
	public void populate(Dova.JDK.java.sql.ResultSet arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[317], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;I)V", "public")]
	public void setObject(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[318], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public")]
	public void setObject(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[319], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;II)V", "public")]
	public void setObject(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[320], arg0, arg1, arg2, arg3);
	}
}
