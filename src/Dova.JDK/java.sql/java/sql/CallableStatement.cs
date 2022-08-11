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

namespace Dova.JDK.java.sql;

[JniSignatureAttribute("Ljava/sql/CallableStatement;", "public abstract interface")]
public partial interface CallableStatement
	: IJavaObject
	, Dova.JDK.java.sql.PreparedStatement
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CallableStatement()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/sql/CallableStatement;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBoolean", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBoolean", "(Ljava/lang/String;)Z"));
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
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDouble", "(Ljava/lang/String;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDouble", "(I)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBytes", "(Ljava/lang/String;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBytes", "(I)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBoolean", "(Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setByte", "(Ljava/lang/String;B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setShort", "(Ljava/lang/String;S)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInt", "(Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLong", "(Ljava/lang/String;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFloat", "(Ljava/lang/String;F)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDouble", "(Ljava/lang/String;D)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObject", "(ILjava/util/Map;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObject", "(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObject", "(ILjava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObject", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObject", "(I)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObject", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRef", "(Ljava/lang/String;)Ljava/sql/Ref;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRef", "(I)Ljava/sql/Ref;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getArray", "(I)Ljava/sql/Array;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getArray", "(Ljava/lang/String;)Ljava/sql/Array;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setURL", "(Ljava/lang/String;Ljava/net/URL;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTimestamp", "(Ljava/lang/String;)Ljava/sql/Timestamp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTimestamp", "(I)Ljava/sql/Timestamp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTimestamp", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Timestamp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTimestamp", "(ILjava/util/Calendar;)Ljava/sql/Timestamp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getString", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getString", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBigDecimal", "(II)Ljava/math/BigDecimal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBigDecimal", "(Ljava/lang/String;)Ljava/math/BigDecimal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBigDecimal", "(I)Ljava/math/BigDecimal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTime", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Time;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTime", "(ILjava/util/Calendar;)Ljava/sql/Time;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTime", "(I)Ljava/sql/Time;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTime", "(Ljava/lang/String;)Ljava/sql/Time;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTime", "(Ljava/lang/String;Ljava/sql/Time;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTime", "(Ljava/lang/String;Ljava/sql/Time;Ljava/util/Calendar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDate", "(Ljava/lang/String;Ljava/sql/Date;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDate", "(Ljava/lang/String;Ljava/sql/Date;Ljava/util/Calendar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDate", "(ILjava/util/Calendar;)Ljava/sql/Date;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDate", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Date;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDate", "(Ljava/lang/String;)Ljava/sql/Date;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDate", "(I)Ljava/sql/Date;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getURL", "(I)Ljava/net/URL;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getURL", "(Ljava/lang/String;)Ljava/net/URL;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharacterStream", "(I)Ljava/io/Reader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerOutParameter", "(ILjava/sql/SQLType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerOutParameter", "(Ljava/lang/String;Ljava/sql/SQLType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerOutParameter", "(Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerOutParameter", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerOutParameter", "(ILjava/sql/SQLType;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerOutParameter", "(ILjava/sql/SQLType;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerOutParameter", "(Ljava/lang/String;Ljava/sql/SQLType;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerOutParameter", "(Ljava/lang/String;Ljava/sql/SQLType;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerOutParameter", "(III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerOutParameter", "(Ljava/lang/String;ILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerOutParameter", "(Ljava/lang/String;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerOutParameter", "(IILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNull", "(Ljava/lang/String;ILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNull", "(Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBigDecimal", "(Ljava/lang/String;Ljava/math/BigDecimal;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setString", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBytes", "(Ljava/lang/String;[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;Ljava/util/Calendar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBlob", "(Ljava/lang/String;Ljava/io/InputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBlob", "(Ljava/lang/String;Ljava/sql/Blob;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBlob", "(Ljava/lang/String;Ljava/io/InputStream;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setClob", "(Ljava/lang/String;Ljava/io/Reader;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setClob", "(Ljava/lang/String;Ljava/sql/Clob;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setClob", "(Ljava/lang/String;Ljava/io/Reader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSQLXML", "(Ljava/lang/String;Ljava/sql/SQLXML;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRowId", "(Ljava/lang/String;Ljava/sql/RowId;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNString", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNClob", "(Ljava/lang/String;Ljava/io/Reader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNClob", "(Ljava/lang/String;Ljava/sql/NClob;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNClob", "(Ljava/lang/String;Ljava/io/Reader;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wasNull", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlob", "(I)Ljava/sql/Blob;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlob", "(Ljava/lang/String;)Ljava/sql/Blob;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClob", "(I)Ljava/sql/Clob;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClob", "(Ljava/lang/String;)Ljava/sql/Clob;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowId", "(Ljava/lang/String;)Ljava/sql/RowId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowId", "(I)Ljava/sql/RowId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNClob", "(Ljava/lang/String;)Ljava/sql/NClob;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNClob", "(I)Ljava/sql/NClob;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSQLXML", "(Ljava/lang/String;)Ljava/sql/SQLXML;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSQLXML", "(I)Ljava/sql/SQLXML;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNString", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNString", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNCharacterStream", "(I)Ljava/io/Reader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setObject", "(Ljava/lang/String;Ljava/lang/Object;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setObject", "(Ljava/lang/String;Ljava/lang/Object;Ljava/sql/SQLType;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setObject", "(Ljava/lang/String;Ljava/lang/Object;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setObject", "(Ljava/lang/String;Ljava/lang/Object;Ljava/sql/SQLType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setObject", "(Ljava/lang/String;Ljava/lang/Object;)V"));
	}

	[JniSignatureAttribute("(I)Z", "public abstract")]
	bool getBoolean(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public abstract")]
	bool getBoolean(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)B", "public abstract")]
	byte getByte(int arg0)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)B", "public abstract")]
	byte getByte(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)S", "public abstract")]
	short getShort(int arg0)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)S", "public abstract")]
	short getShort(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public abstract")]
	int getInt(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public abstract")]
	int getInt(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)J", "public abstract")]
	long getLong(int arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)J", "public abstract")]
	long getLong(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)F", "public abstract")]
	float getFloat(int arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)F", "public abstract")]
	float getFloat(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)D", "public abstract")]
	double getDouble(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)D", "public abstract")]
	double getDouble(int arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[B", "public abstract")]
	JavaArray<byte> getBytes(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(I)[B", "public abstract")]
	JavaArray<byte> getBytes(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)V", "public abstract")]
	void setBoolean(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;B)V", "public abstract")]
	void setByte(Dova.JDK.java.lang.String arg0, byte arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;S)V", "public abstract")]
	void setShort(Dova.JDK.java.lang.String arg0, short arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "public abstract")]
	void setInt(Dova.JDK.java.lang.String arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;J)V", "public abstract")]
	void setLong(Dova.JDK.java.lang.String arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;F)V", "public abstract")]
	void setFloat(Dova.JDK.java.lang.String arg0, float arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;D)V", "public abstract")]
	void setDouble(Dova.JDK.java.lang.String arg0, double arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/util/Map;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object getObject(int arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object getObject(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/Class;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object getObject(int arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object getObject(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object getObject(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object getObject(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/sql/Ref;", "public abstract")]
	Dova.JDK.java.sql.Ref getRef(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Ref>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/sql/Ref;", "public abstract")]
	Dova.JDK.java.sql.Ref getRef(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Ref>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/sql/Array;", "public abstract")]
	Dova.JDK.java.sql.Array getArray(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Array>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/sql/Array;", "public abstract")]
	Dova.JDK.java.sql.Array getArray(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Array>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/net/URL;)V", "public abstract")]
	void setURL(Dova.JDK.java.lang.String arg0, Dova.JDK.java.net.URL arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/sql/Timestamp;", "public abstract")]
	Dova.JDK.java.sql.Timestamp getTimestamp(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Timestamp>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/sql/Timestamp;", "public abstract")]
	Dova.JDK.java.sql.Timestamp getTimestamp(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Timestamp>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Timestamp;", "public abstract")]
	Dova.JDK.java.sql.Timestamp getTimestamp(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Calendar arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Timestamp>(ret);
	}

	[JniSignatureAttribute("(ILjava/util/Calendar;)Ljava/sql/Timestamp;", "public abstract")]
	Dova.JDK.java.sql.Timestamp getTimestamp(int arg0, Dova.JDK.java.util.Calendar arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Timestamp>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getString(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getString(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/math/BigDecimal;", "public abstract")]
	Dova.JDK.java.math.BigDecimal getBigDecimal(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigDecimal>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/math/BigDecimal;", "public abstract")]
	Dova.JDK.java.math.BigDecimal getBigDecimal(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigDecimal>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/math/BigDecimal;", "public abstract")]
	Dova.JDK.java.math.BigDecimal getBigDecimal(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigDecimal>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Time;", "public abstract")]
	Dova.JDK.java.sql.Time getTime(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Calendar arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Time>(ret);
	}

	[JniSignatureAttribute("(ILjava/util/Calendar;)Ljava/sql/Time;", "public abstract")]
	Dova.JDK.java.sql.Time getTime(int arg0, Dova.JDK.java.util.Calendar arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Time>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/sql/Time;", "public abstract")]
	Dova.JDK.java.sql.Time getTime(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Time>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/sql/Time;", "public abstract")]
	Dova.JDK.java.sql.Time getTime(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Time>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/Time;)V", "public abstract")]
	void setTime(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.Time arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/Time;Ljava/util/Calendar;)V", "public abstract")]
	void setTime(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.Time arg1, Dova.JDK.java.util.Calendar arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/Date;)V", "public abstract")]
	void setDate(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.Date arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/Date;Ljava/util/Calendar;)V", "public abstract")]
	void setDate(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.Date arg1, Dova.JDK.java.util.Calendar arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/util/Calendar;)Ljava/sql/Date;", "public abstract")]
	Dova.JDK.java.sql.Date getDate(int arg0, Dova.JDK.java.util.Calendar arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Date>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Date;", "public abstract")]
	Dova.JDK.java.sql.Date getDate(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Calendar arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Date>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/sql/Date;", "public abstract")]
	Dova.JDK.java.sql.Date getDate(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Date>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/sql/Date;", "public abstract")]
	Dova.JDK.java.sql.Date getDate(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Date>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/net/URL;", "public abstract")]
	Dova.JDK.java.net.URL getURL(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/net/URL;", "public abstract")]
	Dova.JDK.java.net.URL getURL(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;I)V", "public abstract")]
	void setCharacterStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[57], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;J)V", "public abstract")]
	void setCharacterStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[58], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;)V", "public abstract")]
	void setCharacterStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[59], arg0, arg1);
	}

	[JniSignatureAttribute("(I)Ljava/io/Reader;", "public abstract")]
	Dova.JDK.java.io.Reader getCharacterStream(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.Reader>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/io/Reader;", "public abstract")]
	Dova.JDK.java.io.Reader getCharacterStream(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.Reader>(ret);
	}

	[JniSignatureAttribute("(ILjava/sql/SQLType;)V", "public")]
	void registerOutParameter(int arg0, Dova.JDK.java.sql.SQLType arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[62], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/SQLType;)V", "public")]
	void registerOutParameter(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.SQLType arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[63], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "public abstract")]
	void registerOutParameter(Dova.JDK.java.lang.String arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[64], arg0, arg1);
	}

	[JniSignatureAttribute("(II)V", "public abstract")]
	void registerOutParameter(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[65], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/sql/SQLType;Ljava/lang/String;)V", "public")]
	void registerOutParameter(int arg0, Dova.JDK.java.sql.SQLType arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[66], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjava/sql/SQLType;I)V", "public")]
	void registerOutParameter(int arg0, Dova.JDK.java.sql.SQLType arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[67], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/SQLType;Ljava/lang/String;)V", "public")]
	void registerOutParameter(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.SQLType arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[68], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/SQLType;I)V", "public")]
	void registerOutParameter(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.SQLType arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[69], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(III)V", "public abstract")]
	void registerOutParameter(int arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[70], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)V", "public abstract")]
	void registerOutParameter(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[71], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;II)V", "public abstract")]
	void registerOutParameter(Dova.JDK.java.lang.String arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[72], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(IILjava/lang/String;)V", "public abstract")]
	void registerOutParameter(int arg0, int arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[73], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)V", "public abstract")]
	void setNull(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[74], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "public abstract")]
	void setNull(Dova.JDK.java.lang.String arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[75], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/math/BigDecimal;)V", "public abstract")]
	void setBigDecimal(Dova.JDK.java.lang.String arg0, Dova.JDK.java.math.BigDecimal arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[76], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public abstract")]
	void setString(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[77], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[B)V", "public abstract")]
	void setBytes(Dova.JDK.java.lang.String arg0, JavaArray<byte> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[78], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/Timestamp;Ljava/util/Calendar;)V", "public abstract")]
	void setTimestamp(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.Timestamp arg1, Dova.JDK.java.util.Calendar arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[79], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/Timestamp;)V", "public abstract")]
	void setTimestamp(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.Timestamp arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[80], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;)V", "public abstract")]
	void setAsciiStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[81], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;J)V", "public abstract")]
	void setAsciiStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[82], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;I)V", "public abstract")]
	void setAsciiStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[83], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;I)V", "public abstract")]
	void setBinaryStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[84], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;J)V", "public abstract")]
	void setBinaryStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[85], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;)V", "public abstract")]
	void setBinaryStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[86], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;J)V", "public abstract")]
	void setNCharacterStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[87], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;)V", "public abstract")]
	void setNCharacterStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[88], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;)V", "public abstract")]
	void setBlob(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[89], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/Blob;)V", "public abstract")]
	void setBlob(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.Blob arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[90], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/InputStream;J)V", "public abstract")]
	void setBlob(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.InputStream arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[91], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;J)V", "public abstract")]
	void setClob(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[92], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/Clob;)V", "public abstract")]
	void setClob(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.Clob arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[93], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;)V", "public abstract")]
	void setClob(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[94], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/SQLXML;)V", "public abstract")]
	void setSQLXML(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.SQLXML arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[95], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/RowId;)V", "public abstract")]
	void setRowId(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.RowId arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[96], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public abstract")]
	void setNString(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[97], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;)V", "public abstract")]
	void setNClob(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[98], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/sql/NClob;)V", "public abstract")]
	void setNClob(Dova.JDK.java.lang.String arg0, Dova.JDK.java.sql.NClob arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[99], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/io/Reader;J)V", "public abstract")]
	void setNClob(Dova.JDK.java.lang.String arg0, Dova.JDK.java.io.Reader arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[100], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool wasNull()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[101]);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/sql/Blob;", "public abstract")]
	Dova.JDK.java.sql.Blob getBlob(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[102], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Blob>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/sql/Blob;", "public abstract")]
	Dova.JDK.java.sql.Blob getBlob(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[103], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Blob>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/sql/Clob;", "public abstract")]
	Dova.JDK.java.sql.Clob getClob(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[104], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Clob>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/sql/Clob;", "public abstract")]
	Dova.JDK.java.sql.Clob getClob(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[105], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Clob>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/sql/RowId;", "public abstract")]
	Dova.JDK.java.sql.RowId getRowId(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[106], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.RowId>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/sql/RowId;", "public abstract")]
	Dova.JDK.java.sql.RowId getRowId(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[107], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.RowId>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/sql/NClob;", "public abstract")]
	Dova.JDK.java.sql.NClob getNClob(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[108], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.NClob>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/sql/NClob;", "public abstract")]
	Dova.JDK.java.sql.NClob getNClob(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[109], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.NClob>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/sql/SQLXML;", "public abstract")]
	Dova.JDK.java.sql.SQLXML getSQLXML(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[110], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.SQLXML>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/sql/SQLXML;", "public abstract")]
	Dova.JDK.java.sql.SQLXML getSQLXML(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[111], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.SQLXML>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getNString(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[112], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getNString(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[113], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/io/Reader;", "public abstract")]
	Dova.JDK.java.io.Reader getNCharacterStream(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[114], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.Reader>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/io/Reader;", "public abstract")]
	Dova.JDK.java.io.Reader getNCharacterStream(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[115], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.Reader>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;II)V", "public abstract")]
	void setObject(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[116], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;Ljava/sql/SQLType;I)V", "public")]
	void setObject(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.sql.SQLType arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[117], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;I)V", "public abstract")]
	void setObject(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[118], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;Ljava/sql/SQLType;)V", "public")]
	void setObject(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.sql.SQLType arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[119], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public abstract")]
	void setObject(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[120], arg0, arg1);
	}
}
