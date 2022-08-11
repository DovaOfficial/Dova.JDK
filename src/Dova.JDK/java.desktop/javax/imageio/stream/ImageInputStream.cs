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

namespace Dova.JDK.javax.imageio.stream;

[JniSignatureAttribute("Ljavax/imageio/stream/ImageInputStream;", "public abstract interface")]
public partial interface ImageInputStream
	: IJavaObject
	, Dova.JDK.java.io.DataInput
	, Dova.JDK.java.io.Closeable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ImageInputStream()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/imageio/stream/ImageInputStream;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "length", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flush", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "([B)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "([BII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readLine", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readInt", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mark", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readUTF", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readBytes", "(Ljavax/imageio/stream/IIOByteBuffer;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readChar", "()C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readFloat", "()F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readFully", "([CII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readFully", "([SII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readFully", "([DII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readFully", "([FII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readFully", "([JII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readFully", "([III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readFully", "([BII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readFully", "([B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "skipBytes", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "skipBytes", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readBoolean", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readByte", "()B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readUnsignedByte", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readShort", "()S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readUnsignedShort", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readLong", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readDouble", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "seek", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCached", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByteOrder", "()Ljava/nio/ByteOrder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setByteOrder", "(Ljava/nio/ByteOrder;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readUnsignedInt", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStreamPosition", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBitOffset", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBitOffset", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readBit", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readBits", "(I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flushBefore", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFlushedPosition", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCachedMemory", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCachedFile", "()Z"));
	}

	[JniSignatureAttribute("()J", "public abstract")]
	long length()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void flush()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("([B)I", "public abstract")]
	int read(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("([BII)I", "public abstract")]
	int read(JavaArray<byte> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int read()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String readLine()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int readInt()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void mark()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void reset()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String readUTF()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/imageio/stream/IIOByteBuffer;I)V", "public abstract")]
	void readBytes(Dova.JDK.javax.imageio.stream.IIOByteBuffer arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("()C", "public abstract")]
	char readChar()
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("()F", "public abstract")]
	float readFloat()
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("([CII)V", "public abstract")]
	void readFully(JavaArray<char> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([SII)V", "public abstract")]
	void readFully(JavaArray<short> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([DII)V", "public abstract")]
	void readFully(JavaArray<double> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([FII)V", "public abstract")]
	void readFully(JavaArray<float> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([JII)V", "public abstract")]
	void readFully(JavaArray<long> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([III)V", "public abstract")]
	void readFully(JavaArray<int> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([BII)V", "public abstract")]
	void readFully(JavaArray<byte> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([B)V", "public abstract")]
	void readFully(JavaArray<byte> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(J)J", "public abstract")]
	long skipBytes(long arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public abstract")]
	int skipBytes(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool readBoolean()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24]);
		return ret;
	}

	[JniSignatureAttribute("()B", "public abstract")]
	byte readByte()
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int readUnsignedByte()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[26]);
		return ret;
	}

	[JniSignatureAttribute("()S", "public abstract")]
	short readShort()
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[27]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int readUnsignedShort()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[28]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public abstract")]
	long readLong()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[29]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public abstract")]
	double readDouble()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[30]);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "public abstract")]
	void seek(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isCached()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[32]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/nio/ByteOrder;", "public abstract")]
	Dova.JDK.java.nio.ByteOrder getByteOrder()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteOrder>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteOrder;)V", "public abstract")]
	void setByteOrder(Dova.JDK.java.nio.ByteOrder arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
	}

	[JniSignatureAttribute("()J", "public abstract")]
	long readUnsignedInt()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[35]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public abstract")]
	long getStreamPosition()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[36]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getBitOffset()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[37]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public abstract")]
	void setBitOffset(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int readBit()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[39]);
		return ret;
	}

	[JniSignatureAttribute("(I)J", "public abstract")]
	long readBits(int arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "public abstract")]
	void flushBefore(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
	}

	[JniSignatureAttribute("()J", "public abstract")]
	long getFlushedPosition()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[42]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isCachedMemory()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[43]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isCachedFile()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[44]);
		return ret;
	}
}
