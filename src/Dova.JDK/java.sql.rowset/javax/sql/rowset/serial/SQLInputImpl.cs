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

namespace Dova.JDK.javax.sql.rowset.serial;

[JniSignatureAttribute("Ljavax/sql/rowset/serial/SQLInputImpl;", "public")]
public partial class SQLInputImpl
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.sql.SQLInput
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SQLInputImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/sql/rowset/serial/SQLInputImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastValueWasNull", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "idx", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attrib", "[Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "map", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/lang/Object;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readInt", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readBytes", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readFloat", "()F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readBoolean", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readByte", "()B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readShort", "()S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readLong", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readDouble", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wasNull", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNextAttribute", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readBigDecimal", "()Ljava/math/BigDecimal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readDate", "()Ljava/sql/Date;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readTime", "()Ljava/sql/Time;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readTimestamp", "()Ljava/sql/Timestamp;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readCharacterStream", "()Ljava/io/Reader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readAsciiStream", "()Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readBinaryStream", "()Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readRef", "()Ljava/sql/Ref;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readBlob", "()Ljava/sql/Blob;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readClob", "()Ljava/sql/Clob;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readURL", "()Ljava/net/URL;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readNClob", "()Ljava/sql/NClob;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readNString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readSQLXML", "()Ljava/sql/SQLXML;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readRowId", "()Ljava/sql/RowId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readArray", "()Ljava/sql/Array;"));
	}

	[JniSignatureAttribute("Z", "private")]
	public bool lastValueWasNull_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int idx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/Object;", "private")]
	public JavaArray<Dova.JDK.java.lang.Object> attrib_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map map_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SQLInputImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("([Ljava/lang/Object;Ljava/util/Map;)V", "public")]
	public SQLInputImpl(JavaArray<Dova.JDK.java.lang.Object> arg0, Dova.JDK.java.util.Map arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/sql/rowset/serial/SQLInputImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object readObject()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int readInt()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()[B", "public")]
	public JavaArray<byte> readBytes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()F", "public")]
	public float readFloat()
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool readBoolean()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()B", "public")]
	public byte readByte()
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()S", "public")]
	public short readShort()
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long readLong()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public")]
	public double readDouble()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String readString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool wasNull()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object getNextAttribute()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/math/BigDecimal;", "public")]
	public Dova.JDK.java.math.BigDecimal readBigDecimal()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigDecimal>(ret);
	}

	[JniSignatureAttribute("()Ljava/sql/Date;", "public")]
	public Dova.JDK.java.sql.Date readDate()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Date>(ret);
	}

	[JniSignatureAttribute("()Ljava/sql/Time;", "public")]
	public Dova.JDK.java.sql.Time readTime()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Time>(ret);
	}

	[JniSignatureAttribute("()Ljava/sql/Timestamp;", "public")]
	public Dova.JDK.java.sql.Timestamp readTimestamp()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Timestamp>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/Reader;", "public")]
	public Dova.JDK.java.io.Reader readCharacterStream()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.Reader>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/InputStream;", "public")]
	public Dova.JDK.java.io.InputStream readAsciiStream()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/InputStream;", "public")]
	public Dova.JDK.java.io.InputStream readBinaryStream()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/sql/Ref;", "public")]
	public Dova.JDK.java.sql.Ref readRef()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Ref>(ret);
	}

	[JniSignatureAttribute("()Ljava/sql/Blob;", "public")]
	public Dova.JDK.java.sql.Blob readBlob()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Blob>(ret);
	}

	[JniSignatureAttribute("()Ljava/sql/Clob;", "public")]
	public Dova.JDK.java.sql.Clob readClob()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Clob>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/URL;", "public")]
	public Dova.JDK.java.net.URL readURL()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
	}

	[JniSignatureAttribute("()Ljava/sql/NClob;", "public")]
	public Dova.JDK.java.sql.NClob readNClob()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.NClob>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String readNString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/sql/SQLXML;", "public")]
	public Dova.JDK.java.sql.SQLXML readSQLXML()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.SQLXML>(ret);
	}

	[JniSignatureAttribute("()Ljava/sql/RowId;", "public")]
	public Dova.JDK.java.sql.RowId readRowId()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.RowId>(ret);
	}

	[JniSignatureAttribute("()Ljava/sql/Array;", "public")]
	public Dova.JDK.java.sql.Array readArray()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.sql.Array>(ret);
	}
}
