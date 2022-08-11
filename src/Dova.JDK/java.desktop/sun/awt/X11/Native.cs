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

namespace Dova.JDK.sun.awt.X11;

[JniSignatureAttribute("Lsun/awt/X11/Native;", "")]
public partial class Native
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Native()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/Native;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "unsafe", "Ljdk/internal/misc/Unsafe;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "longSize", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "dataModel", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "put", "(J[J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toBytes", "(JI)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getByte", "(JI)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getByte", "(J)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putByte", "(JIB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putByte", "(JB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getShort", "(J)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putShort", "(JS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putShort", "(JIS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInt", "(J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInt", "(JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putInt", "(JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putInt", "(JII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getLong", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getLong", "(JI)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putLong", "(JLjava/util/Vector;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putLong", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putLong", "(JIJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getUShort", "(J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getUInt", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getUInt", "(JI)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getUByte", "(J)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getUByte", "(JI)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "allocateLongArray", "(I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getLongSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putUByte", "(JIS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putUByte", "(JS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getShortSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putUShort", "(JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putUShort", "(JII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getIntSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putUInt", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putUInt", "(JIJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getWindowSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toLongs", "(JI)[J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toData", "([J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toData", "([S)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toData", "([I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toData", "([B)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBool", "(JI)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBool", "(J)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putBool", "(JIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putBool", "(JZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getByteSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getUByteSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toUBytes", "(JI)[S"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toUData", "([J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toUData", "([I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toUData", "([S)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getUShortSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getUIntSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putLongReverse", "(JLjava/util/Vector;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getULong", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putULong", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putWindow", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putWindow", "(JIJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCard32", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCard32", "(JI)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putCard32", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putCard32", "(JIJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCard32Size", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "card32ToArray", "(JI)[J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "card32ToData", "([J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getWindow", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getWindow", "(JI)J"));
	}

	[JniSignatureAttribute("Ljdk/internal/misc/Unsafe;", "private static")]
	public static Dova.JDK.jdk.@internal.misc.Unsafe @unsafe_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.misc.Unsafe>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "static")]
	public static int longSize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("I", "static")]
	public static int dataModel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Native(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public Native() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/X11/Native;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(J[J)V", "static")]
	public static void put(long arg0, JavaArray<long> arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(JI)[B", "static")]
	public static JavaArray<byte> toBytes(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(JI)B", "static")]
	public static byte getByte(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)B", "static")]
	public static byte getByte(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JIB)V", "static")]
	public static void putByte(long arg0, int arg1, byte arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JB)V", "static")]
	public static void putByte(long arg0, byte arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(J)S", "static")]
	public static short getShort(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticShortMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JS)V", "static")]
	public static void putShort(long arg0, short arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(JIS)V", "static")]
	public static void putShort(long arg0, int arg1, short arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(J)I", "static")]
	public static int getInt(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JI)I", "static")]
	public static int getInt(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(JI)V", "static")]
	public static void putInt(long arg0, int arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(JII)V", "static")]
	public static void putInt(long arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(J)J", "static")]
	public static long getLong(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JI)J", "static")]
	public static long getLong(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(JLjava/util/Vector;)V", "static")]
	public static void putLong(long arg0, Dova.JDK.java.util.Vector arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1);
	}

	[JniSignatureAttribute("(JJ)V", "static")]
	public static void putLong(long arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1);
	}

	[JniSignatureAttribute("(JIJ)V", "static")]
	public static void putLong(long arg0, int arg1, long arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(J)I", "static")]
	public static int getUShort(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[18], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "static")]
	public static long getUInt(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[19], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JI)J", "static")]
	public static long getUInt(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)S", "static")]
	public static short getUByte(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticShortMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JI)S", "static")]
	public static short getUByte(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticShortMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)J", "static")]
	public static long allocateLongArray(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "static")]
	public static int getLongSize()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[24]);
		return ret;
	}

	[JniSignatureAttribute("(JIS)V", "static")]
	public static void putUByte(long arg0, int arg1, short arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JS)V", "static")]
	public static void putUByte(long arg0, short arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1);
	}

	[JniSignatureAttribute("()I", "static")]
	public static int getShortSize()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[27]);
		return ret;
	}

	[JniSignatureAttribute("(JI)V", "static")]
	public static void putUShort(long arg0, int arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1);
	}

	[JniSignatureAttribute("(JII)V", "static")]
	public static void putUShort(long arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()I", "static")]
	public static int getIntSize()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[30]);
		return ret;
	}

	[JniSignatureAttribute("(JJ)V", "static")]
	public static void putUInt(long arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[31], arg0, arg1);
	}

	[JniSignatureAttribute("(JIJ)V", "static")]
	public static void putUInt(long arg0, int arg1, long arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[32], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()I", "static")]
	public static int getWindowSize()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[33]);
		return ret;
	}

	[JniSignatureAttribute("(JI)[J", "static")]
	public static JavaArray<long> toLongs(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[34], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
	}

	[JniSignatureAttribute("([J)J", "static")]
	public static long toData(JavaArray<long> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[35], arg0);
		return ret;
	}

	[JniSignatureAttribute("([S)J", "static")]
	public static long toData(JavaArray<short> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[36], arg0);
		return ret;
	}

	[JniSignatureAttribute("([I)J", "static")]
	public static long toData(JavaArray<int> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[37], arg0);
		return ret;
	}

	[JniSignatureAttribute("([B)J", "static")]
	public static long toData(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[38], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JI)Z", "static")]
	public static bool getBool(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[39], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)Z", "static")]
	public static bool getBool(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[40], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JIZ)V", "static")]
	public static void putBool(long arg0, int arg1, bool arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[41], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JZ)V", "static")]
	public static void putBool(long arg0, bool arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[42], arg0, arg1);
	}

	[JniSignatureAttribute("()I", "static")]
	public static int getByteSize()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[43]);
		return ret;
	}

	[JniSignatureAttribute("()I", "static")]
	public static int getUByteSize()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[44]);
		return ret;
	}

	[JniSignatureAttribute("(JI)[S", "static")]
	public static JavaArray<short> toUBytes(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[45], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<short>>(ret);
	}

	[JniSignatureAttribute("([J)J", "static")]
	public static long toUData(JavaArray<long> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[46], arg0);
		return ret;
	}

	[JniSignatureAttribute("([I)J", "static")]
	public static long toUData(JavaArray<int> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[47], arg0);
		return ret;
	}

	[JniSignatureAttribute("([S)J", "static")]
	public static long toUData(JavaArray<short> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[48], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "static")]
	public static int getUShortSize()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[49]);
		return ret;
	}

	[JniSignatureAttribute("()I", "static")]
	public static int getUIntSize()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[50]);
		return ret;
	}

	[JniSignatureAttribute("(JLjava/util/Vector;)V", "static")]
	public static void putLongReverse(long arg0, Dova.JDK.java.util.Vector arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[51], arg0, arg1);
	}

	[JniSignatureAttribute("(J)J", "static")]
	public static long getULong(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[52], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JJ)V", "static")]
	public static void putULong(long arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[53], arg0, arg1);
	}

	[JniSignatureAttribute("(JJ)V", "static")]
	public static void putWindow(long arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[54], arg0, arg1);
	}

	[JniSignatureAttribute("(JIJ)V", "static")]
	public static void putWindow(long arg0, int arg1, long arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[55], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(J)J", "static")]
	public static long getCard32(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[56], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JI)J", "static")]
	public static long getCard32(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[57], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(JJ)V", "static")]
	public static void putCard32(long arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[58], arg0, arg1);
	}

	[JniSignatureAttribute("(JIJ)V", "static")]
	public static void putCard32(long arg0, int arg1, long arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[59], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()I", "static")]
	public static int getCard32Size()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[60]);
		return ret;
	}

	[JniSignatureAttribute("(JI)[J", "static")]
	public static JavaArray<long> card32ToArray(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[61], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
	}

	[JniSignatureAttribute("([J)J", "static")]
	public static long card32ToData(JavaArray<long> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[62], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "static")]
	public static long getWindow(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[63], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JI)J", "static")]
	public static long getWindow(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[64], arg0, arg1);
		return ret;
	}
}
