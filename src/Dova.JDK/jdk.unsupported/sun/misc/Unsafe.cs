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

namespace Dova.JDK.sun.misc;

[JniSignatureAttribute("Lsun/misc/Unsafe;", "public final")]
public partial class Unsafe
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Unsafe()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/misc/Unsafe;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "theUnsafe", "Lsun/misc/Unsafe;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "theInternalUnsafe", "Ljdk/internal/misc/Unsafe;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_FIELD_OFFSET", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_BOOLEAN_BASE_OFFSET", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_BYTE_BASE_OFFSET", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_SHORT_BASE_OFFSET", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_CHAR_BASE_OFFSET", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_INT_BASE_OFFSET", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_LONG_BASE_OFFSET", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_FLOAT_BASE_OFFSET", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_DOUBLE_BASE_OFFSET", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_OBJECT_BASE_OFFSET", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_BOOLEAN_INDEX_SCALE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_BYTE_INDEX_SCALE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_SHORT_INDEX_SCALE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_CHAR_INDEX_SCALE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_INT_INDEX_SCALE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_LONG_INDEX_SCALE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_FLOAT_INDEX_SCALE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_DOUBLE_INDEX_SCALE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_OBJECT_INDEX_SCALE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ADDRESS_SIZE", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allocateInstance", "(Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadFence", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "storeFence", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fullFence", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBoolean", "(Ljava/lang/Object;J)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putBoolean", "(Ljava/lang/Object;JZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByte", "(J)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByte", "(Ljava/lang/Object;J)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putByte", "(Ljava/lang/Object;JB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putByte", "(JB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShort", "(Ljava/lang/Object;J)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShort", "(J)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putShort", "(JS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putShort", "(Ljava/lang/Object;JS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChar", "(J)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChar", "(Ljava/lang/Object;J)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putChar", "(Ljava/lang/Object;JC)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putChar", "(JC)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInt", "(Ljava/lang/Object;J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInt", "(J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putInt", "(Ljava/lang/Object;JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putInt", "(JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLong", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLong", "(Ljava/lang/Object;J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putLong", "(Ljava/lang/Object;JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putLong", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFloat", "(J)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFloat", "(Ljava/lang/Object;J)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putFloat", "(JF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putFloat", "(Ljava/lang/Object;JF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDouble", "(J)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDouble", "(Ljava/lang/Object;J)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putDouble", "(JD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putDouble", "(Ljava/lang/Object;JD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBooleanVolatile", "(Ljava/lang/Object;J)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putBooleanVolatile", "(Ljava/lang/Object;JZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByteVolatile", "(Ljava/lang/Object;J)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putByteVolatile", "(Ljava/lang/Object;JB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShortVolatile", "(Ljava/lang/Object;J)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putShortVolatile", "(Ljava/lang/Object;JS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharVolatile", "(Ljava/lang/Object;J)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putCharVolatile", "(Ljava/lang/Object;JC)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIntVolatile", "(Ljava/lang/Object;J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putIntVolatile", "(Ljava/lang/Object;JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLongVolatile", "(Ljava/lang/Object;J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putLongVolatile", "(Ljava/lang/Object;JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFloatVolatile", "(Ljava/lang/Object;J)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putFloatVolatile", "(Ljava/lang/Object;JF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDoubleVolatile", "(Ljava/lang/Object;J)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putDoubleVolatile", "(Ljava/lang/Object;JD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAddInt", "(Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAddLong", "(Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetInt", "(Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetLong", "(Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "park", "(ZJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unpark", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwException", "(Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "objectFieldOffset", "(Ljava/lang/reflect/Field;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureClassInitialized", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "staticFieldBase", "(Ljava/lang/reflect/Field;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "staticFieldOffset", "(Ljava/lang/reflect/Field;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shouldBeInitialized", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAddress", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putAddress", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "freeMemory", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMemory", "(JJB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMemory", "(Ljava/lang/Object;JJB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyMemory", "(JJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyMemory", "(Ljava/lang/Object;JLjava/lang/Object;JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "arrayBaseOffset", "(Ljava/lang/Class;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "arrayIndexScale", "(Ljava/lang/Class;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allocateMemory", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reallocateMemory", "(JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addressSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pageSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLoadAverage", "([DI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeCleaner", "(Ljava/nio/ByteBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObject", "(Ljava/lang/Object;J)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObjectVolatile", "(Ljava/lang/Object;J)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putObject", "(Ljava/lang/Object;JLjava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putObjectVolatile", "(Ljava/lang/Object;JLjava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetObject", "(Ljava/lang/Object;JLjava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndSwapObject", "(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndSwapInt", "(Ljava/lang/Object;JII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndSwapLong", "(Ljava/lang/Object;JJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putOrderedObject", "(Ljava/lang/Object;JLjava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putOrderedInt", "(Ljava/lang/Object;JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putOrderedLong", "(Ljava/lang/Object;JJ)V"));
	}

	[JniSignatureAttribute("Lsun/misc/Unsafe;", "private static final")]
	public static Dova.JDK.sun.misc.Unsafe theUnsafe_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.misc.Unsafe>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/misc/Unsafe;", "private static final")]
	public static Dova.JDK.jdk.@internal.misc.Unsafe theInternalUnsafe_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.misc.Unsafe>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int INVALID_FIELD_OFFSET_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int ARRAY_BOOLEAN_BASE_OFFSET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ARRAY_BYTE_BASE_OFFSET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ARRAY_SHORT_BASE_OFFSET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ARRAY_CHAR_BASE_OFFSET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ARRAY_INT_BASE_OFFSET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ARRAY_LONG_BASE_OFFSET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ARRAY_FLOAT_BASE_OFFSET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ARRAY_DOUBLE_BASE_OFFSET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ARRAY_OBJECT_BASE_OFFSET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ARRAY_BOOLEAN_INDEX_SCALE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ARRAY_BYTE_INDEX_SCALE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ARRAY_SHORT_INDEX_SCALE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ARRAY_CHAR_INDEX_SCALE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ARRAY_INT_INDEX_SCALE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ARRAY_LONG_INDEX_SCALE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ARRAY_FLOAT_INDEX_SCALE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ARRAY_DOUBLE_INDEX_SCALE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ARRAY_OBJECT_INDEX_SCALE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ADDRESS_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Unsafe(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public Unsafe() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/misc/Unsafe;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object allocateInstance(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void loadFence()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void storeFence()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void fullFence()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)Z", "public")]
	public bool getBoolean(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZ)V", "public")]
	public void putBoolean(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(J)B", "public")]
	public byte getByte(long arg0)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)B", "public")]
	public byte getByte(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JB)V", "public")]
	public void putByte(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JB)V", "public")]
	public void putByte(long arg0, byte arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)S", "public")]
	public short getShort(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)S", "public")]
	public short getShort(long arg0)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JS)V", "public")]
	public void putShort(long arg0, short arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JS)V", "public")]
	public void putShort(Dova.JDK.java.lang.Object arg0, long arg1, short arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(J)C", "public")]
	public char getChar(long arg0)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)C", "public")]
	public char getChar(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JC)V", "public")]
	public void putChar(Dova.JDK.java.lang.Object arg0, long arg1, char arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JC)V", "public")]
	public void putChar(long arg0, char arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)I", "public")]
	public int getInt(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)I", "public")]
	public int getInt(long arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JI)V", "public")]
	public void putInt(Dova.JDK.java.lang.Object arg0, long arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JI)V", "public")]
	public void putInt(long arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
	}

	[JniSignatureAttribute("(J)J", "public")]
	public long getLong(long arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)J", "public")]
	public long getLong(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJ)V", "public")]
	public void putLong(Dova.JDK.java.lang.Object arg0, long arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JJ)V", "public")]
	public void putLong(long arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
	}

	[JniSignatureAttribute("(J)F", "public")]
	public float getFloat(long arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)F", "public")]
	public float getFloat(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(JF)V", "public")]
	public void putFloat(long arg0, float arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JF)V", "public")]
	public void putFloat(Dova.JDK.java.lang.Object arg0, long arg1, float arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(J)D", "public")]
	public double getDouble(long arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)D", "public")]
	public double getDouble(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(JD)V", "public")]
	public void putDouble(long arg0, double arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JD)V", "public")]
	public void putDouble(Dova.JDK.java.lang.Object arg0, long arg1, double arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)Z", "public")]
	public bool getBooleanVolatile(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZ)V", "public")]
	public void putBooleanVolatile(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)B", "public")]
	public byte getByteVolatile(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JB)V", "public")]
	public void putByteVolatile(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)S", "public")]
	public short getShortVolatile(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JS)V", "public")]
	public void putShortVolatile(Dova.JDK.java.lang.Object arg0, long arg1, short arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)C", "public")]
	public char getCharVolatile(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JC)V", "public")]
	public void putCharVolatile(Dova.JDK.java.lang.Object arg0, long arg1, char arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)I", "public")]
	public int getIntVolatile(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JI)V", "public")]
	public void putIntVolatile(Dova.JDK.java.lang.Object arg0, long arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)J", "public")]
	public long getLongVolatile(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJ)V", "public")]
	public void putLongVolatile(Dova.JDK.java.lang.Object arg0, long arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)F", "public")]
	public float getFloatVolatile(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JF)V", "public")]
	public void putFloatVolatile(Dova.JDK.java.lang.Object arg0, long arg1, float arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)D", "public")]
	public double getDoubleVolatile(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JD)V", "public")]
	public void putDoubleVolatile(Dova.JDK.java.lang.Object arg0, long arg1, double arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JI)I", "public final")]
	public int getAndAddInt(Dova.JDK.java.lang.Object arg0, long arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJ)J", "public final")]
	public long getAndAddLong(Dova.JDK.java.lang.Object arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JI)I", "public final")]
	public int getAndSetInt(Dova.JDK.java.lang.Object arg0, long arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJ)J", "public final")]
	public long getAndSetLong(Dova.JDK.java.lang.Object arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(ZJ)V", "public")]
	public void park(bool arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
	public void unpark(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "public")]
	public void throwException(Dova.JDK.java.lang.Throwable arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;)J", "public")]
	public long objectFieldOffset(Dova.JDK.java.lang.reflect.Field arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "public")]
	public void ensureClassInitialized(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object staticFieldBase(Dova.JDK.java.lang.reflect.Field arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;)J", "public")]
	public long staticFieldOffset(Dova.JDK.java.lang.reflect.Field arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public")]
	public bool shouldBeInitialized(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "public")]
	public long getAddress(long arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JJ)V", "public")]
	public void putAddress(long arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[63], arg0, arg1);
	}

	[JniSignatureAttribute("(J)V", "public")]
	public void freeMemory(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[64], arg0);
	}

	[JniSignatureAttribute("(JJB)V", "public")]
	public void setMemory(long arg0, long arg1, byte arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[65], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJB)V", "public")]
	public void setMemory(Dova.JDK.java.lang.Object arg0, long arg1, long arg2, byte arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[66], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(JJJ)V", "public")]
	public void copyMemory(long arg0, long arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[67], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;JJ)V", "public")]
	public void copyMemory(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2, long arg3, long arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[68], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)I", "public")]
	public int arrayBaseOffset(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[69], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)I", "public")]
	public int arrayIndexScale(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[70], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "public")]
	public long allocateMemory(long arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[71], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JJ)J", "public")]
	public long reallocateMemory(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[72], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int addressSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[73]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int pageSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[74]);
		return ret;
	}

	[JniSignatureAttribute("([DI)I", "public")]
	public int getLoadAverage(JavaArray<double> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[75], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)V", "public")]
	public void invokeCleaner(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[76], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getObject(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[77], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getObjectVolatile(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[78], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;)V", "public")]
	public void putObject(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[79], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;)V", "public")]
	public void putObjectVolatile(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[80], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object getAndSetObject(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[81], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Z", "public final")]
	public bool compareAndSwapObject(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[82], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JII)Z", "public final")]
	public bool compareAndSwapInt(Dova.JDK.java.lang.Object arg0, long arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[83], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJJ)Z", "public final")]
	public bool compareAndSwapLong(Dova.JDK.java.lang.Object arg0, long arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[84], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;)V", "public")]
	public void putOrderedObject(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[85], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JI)V", "public")]
	public void putOrderedInt(Dova.JDK.java.lang.Object arg0, long arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[86], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJ)V", "public")]
	public void putOrderedLong(Dova.JDK.java.lang.Object arg0, long arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[87], arg0, arg1, arg2);
	}
}
