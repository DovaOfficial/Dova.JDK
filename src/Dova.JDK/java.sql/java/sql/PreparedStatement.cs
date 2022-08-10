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

[JniSignatureAttribute("Ljava/sql/PreparedStatement;", "public abstract interface")]
public partial interface PreparedStatement
	: IJavaObject
	, Dova.JDK.java.sql.Statement
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PreparedStatement()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/sql/PreparedStatement;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "execute", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setBoolean", "(IZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setByte", "(IB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setShort", "(IS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setInt", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setLong", "(IJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setFloat", "(IF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setDouble", "(ID)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setURL", "(ILjava/net/URL;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setArray", "(ILjava/sql/Array;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setTime", "(ILjava/sql/Time;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setTime", "(ILjava/sql/Time;Ljava/util/Calendar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setDate", "(ILjava/sql/Date;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setDate", "(ILjava/sql/Date;Ljava/util/Calendar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setCharacterStream", "(ILjava/io/Reader;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setCharacterStream", "(ILjava/io/Reader;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setCharacterStream", "(ILjava/io/Reader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setNull", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setNull", "(IILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setBigDecimal", "(ILjava/math/BigDecimal;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setString", "(ILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setBytes", "(I[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setTimestamp", "(ILjava/sql/Timestamp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setTimestamp", "(ILjava/sql/Timestamp;Ljava/util/Calendar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setAsciiStream", "(ILjava/io/InputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setAsciiStream", "(ILjava/io/InputStream;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setAsciiStream", "(ILjava/io/InputStream;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setBinaryStream", "(ILjava/io/InputStream;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setBinaryStream", "(ILjava/io/InputStream;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setBinaryStream", "(ILjava/io/InputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setNCharacterStream", "(ILjava/io/Reader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setNCharacterStream", "(ILjava/io/Reader;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setBlob", "(ILjava/io/InputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setBlob", "(ILjava/sql/Blob;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setBlob", "(ILjava/io/InputStream;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setClob", "(ILjava/io/Reader;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setClob", "(ILjava/io/Reader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setClob", "(ILjava/sql/Clob;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "clearParameters", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setSQLXML", "(ILjava/sql/SQLXML;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setRowId", "(ILjava/sql/RowId;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setNString", "(ILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setNClob", "(ILjava/io/Reader;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setNClob", "(ILjava/sql/NClob;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setNClob", "(ILjava/io/Reader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "executeLargeUpdate", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "executeQuery", "()Ljava/sql/ResultSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "executeUpdate", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addBatch", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getParameterMetaData", "()Ljava/sql/ParameterMetaData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setRef", "(ILjava/sql/Ref;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMetaData", "()Ljava/sql/ResultSetMetaData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setUnicodeStream", "(ILjava/io/InputStream;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setObject", "(ILjava/lang/Object;Ljava/sql/SQLType;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setObject", "(ILjava/lang/Object;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setObject", "(ILjava/lang/Object;Ljava/sql/SQLType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setObject", "(ILjava/lang/Object;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setObject", "(ILjava/lang/Object;)V"));
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool execute()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("(IZ)V", "public abstract")]
	void setBoolean(int arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(IB)V", "public abstract")]
	void setByte(int arg0, byte arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(IS)V", "public abstract")]
	void setShort(int arg0, short arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(II)V", "public abstract")]
	void setInt(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(IJ)V", "public abstract")]
	void setLong(int arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(IF)V", "public abstract")]
	void setFloat(int arg0, float arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(ID)V", "public abstract")]
	void setDouble(int arg0, double arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/net/URL;)V", "public abstract")]
	void setURL(int arg0, Dova.JDK.java.net.URL arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/sql/Array;)V", "public abstract")]
	void setArray(int arg0, Dova.JDK.java.sql.Array arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/sql/Time;)V", "public abstract")]
	void setTime(int arg0, Dova.JDK.java.sql.Time arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/sql/Time;Ljava/util/Calendar;)V", "public abstract")]
	void setTime(int arg0, Dova.JDK.java.sql.Time arg1, Dova.JDK.java.util.Calendar arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/sql/Date;)V", "public abstract")]
	void setDate(int arg0, Dova.JDK.java.sql.Date arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/sql/Date;Ljava/util/Calendar;)V", "public abstract")]
	void setDate(int arg0, Dova.JDK.java.sql.Date arg1, Dova.JDK.java.util.Calendar arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/io/Reader;J)V", "public abstract")]
	void setCharacterStream(int arg0, Dova.JDK.java.io.Reader arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/io/Reader;I)V", "public abstract")]
	void setCharacterStream(int arg0, Dova.JDK.java.io.Reader arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/io/Reader;)V", "public abstract")]
	void setCharacterStream(int arg0, Dova.JDK.java.io.Reader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
	}

	[JniSignatureAttribute("(II)V", "public abstract")]
	void setNull(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
	}

	[JniSignatureAttribute("(IILjava/lang/String;)V", "public abstract")]
	void setNull(int arg0, int arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/math/BigDecimal;)V", "public abstract")]
	void setBigDecimal(int arg0, Dova.JDK.java.math.BigDecimal arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/lang/String;)V", "public abstract")]
	void setString(int arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
	}

	[JniSignatureAttribute("(I[B)V", "public abstract")]
	void setBytes(int arg0, JavaArray<byte> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/sql/Timestamp;)V", "public abstract")]
	void setTimestamp(int arg0, Dova.JDK.java.sql.Timestamp arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/sql/Timestamp;Ljava/util/Calendar;)V", "public abstract")]
	void setTimestamp(int arg0, Dova.JDK.java.sql.Timestamp arg1, Dova.JDK.java.util.Calendar arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/io/InputStream;)V", "public abstract")]
	void setAsciiStream(int arg0, Dova.JDK.java.io.InputStream arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/io/InputStream;I)V", "public abstract")]
	void setAsciiStream(int arg0, Dova.JDK.java.io.InputStream arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/io/InputStream;J)V", "public abstract")]
	void setAsciiStream(int arg0, Dova.JDK.java.io.InputStream arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/io/InputStream;I)V", "public abstract")]
	void setBinaryStream(int arg0, Dova.JDK.java.io.InputStream arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/io/InputStream;J)V", "public abstract")]
	void setBinaryStream(int arg0, Dova.JDK.java.io.InputStream arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/io/InputStream;)V", "public abstract")]
	void setBinaryStream(int arg0, Dova.JDK.java.io.InputStream arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/io/Reader;)V", "public abstract")]
	void setNCharacterStream(int arg0, Dova.JDK.java.io.Reader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/io/Reader;J)V", "public abstract")]
	void setNCharacterStream(int arg0, Dova.JDK.java.io.Reader arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/io/InputStream;)V", "public abstract")]
	void setBlob(int arg0, Dova.JDK.java.io.InputStream arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/sql/Blob;)V", "public abstract")]
	void setBlob(int arg0, Dova.JDK.java.sql.Blob arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/io/InputStream;J)V", "public abstract")]
	void setBlob(int arg0, Dova.JDK.java.io.InputStream arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/io/Reader;J)V", "public abstract")]
	void setClob(int arg0, Dova.JDK.java.io.Reader arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/io/Reader;)V", "public abstract")]
	void setClob(int arg0, Dova.JDK.java.io.Reader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/sql/Clob;)V", "public abstract")]
	void setClob(int arg0, Dova.JDK.java.sql.Clob arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void clearParameters()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38]);
	}

	[JniSignatureAttribute("(ILjava/sql/SQLXML;)V", "public abstract")]
	void setSQLXML(int arg0, Dova.JDK.java.sql.SQLXML arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/sql/RowId;)V", "public abstract")]
	void setRowId(int arg0, Dova.JDK.java.sql.RowId arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/lang/String;)V", "public abstract")]
	void setNString(int arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/io/Reader;J)V", "public abstract")]
	void setNClob(int arg0, Dova.JDK.java.io.Reader arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/sql/NClob;)V", "public abstract")]
	void setNClob(int arg0, Dova.JDK.java.sql.NClob arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/io/Reader;)V", "public abstract")]
	void setNClob(int arg0, Dova.JDK.java.io.Reader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
	}

	[JniSignatureAttribute("()J", "public")]
	long executeLargeUpdate()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[45]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/sql/ResultSet;", "public abstract")]
	Dova.JDK.java.sql.ResultSet executeQuery()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.ResultSet>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int executeUpdate()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[47]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void addBatch()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48]);
	}

	[JniSignatureAttribute("()Ljava/sql/ParameterMetaData;", "public abstract")]
	Dova.JDK.java.sql.ParameterMetaData getParameterMetaData()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.ParameterMetaData>(ret);
	}

	[JniSignatureAttribute("(ILjava/sql/Ref;)V", "public abstract")]
	void setRef(int arg0, Dova.JDK.java.sql.Ref arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/sql/ResultSetMetaData;", "public abstract")]
	Dova.JDK.java.sql.ResultSetMetaData getMetaData()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.ResultSetMetaData>(ret);
	}

	[JniSignatureAttribute("(ILjava/io/InputStream;I)V", "public abstract")]
	void setUnicodeStream(int arg0, Dova.JDK.java.io.InputStream arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/lang/Object;Ljava/sql/SQLType;I)V", "public")]
	void setObject(int arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.sql.SQLType arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(ILjava/lang/Object;II)V", "public abstract")]
	void setObject(int arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(ILjava/lang/Object;Ljava/sql/SQLType;)V", "public")]
	void setObject(int arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.sql.SQLType arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/lang/Object;I)V", "public abstract")]
	void setObject(int arg0, Dova.JDK.java.lang.Object arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/lang/Object;)V", "public abstract")]
	void setObject(int arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[57], arg0, arg1);
	}
}
