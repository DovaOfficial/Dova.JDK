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

namespace Dova.JDK.jdk.@internal.misc;

[JniSignatureAttribute("Ljdk/internal/misc/Unsafe;", "public final")]
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
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/misc/Unsafe;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "theUnsafe", "Ljdk/internal/misc/Unsafe;"));
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
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeback0", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writebackPreSync0", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writebackPostSync0", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allocateInstance", "(Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allocateUninitializedArray0", "(Ljava/lang/Class;I)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyMemory0", "(Ljava/lang/Object;JLjava/lang/Object;JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadFence", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "storeFence", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "storeStoreFence", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fullFence", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReference", "(Ljava/lang/Object;J)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putReference", "(Ljava/lang/Object;JLjava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBoolean", "(Ljava/lang/Object;J)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putBoolean", "(Ljava/lang/Object;JZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByte", "(Ljava/lang/Object;J)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByte", "(J)B"));
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
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInt", "(J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInt", "(Ljava/lang/Object;J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putInt", "(JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putInt", "(Ljava/lang/Object;JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLong", "(Ljava/lang/Object;J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLong", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putLong", "(Ljava/lang/Object;JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putLong", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFloat", "(Ljava/lang/Object;J)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFloat", "(J)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putFloat", "(JF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putFloat", "(Ljava/lang/Object;JF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDouble", "(J)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDouble", "(Ljava/lang/Object;J)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putDouble", "(Ljava/lang/Object;JD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putDouble", "(JD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReferenceVolatile", "(Ljava/lang/Object;J)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putReferenceVolatile", "(Ljava/lang/Object;JLjava/lang/Object;)V"));
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
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReferenceOpaque", "(Ljava/lang/Object;J)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putReferenceOpaque", "(Ljava/lang/Object;JLjava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBooleanOpaque", "(Ljava/lang/Object;J)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putBooleanOpaque", "(Ljava/lang/Object;JZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByteOpaque", "(Ljava/lang/Object;J)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putByteOpaque", "(Ljava/lang/Object;JB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShortOpaque", "(Ljava/lang/Object;J)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putShortOpaque", "(Ljava/lang/Object;JS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharOpaque", "(Ljava/lang/Object;J)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putCharOpaque", "(Ljava/lang/Object;JC)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIntOpaque", "(Ljava/lang/Object;J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putIntOpaque", "(Ljava/lang/Object;JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLongOpaque", "(Ljava/lang/Object;J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putLongOpaque", "(Ljava/lang/Object;JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFloatOpaque", "(Ljava/lang/Object;J)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putFloatOpaque", "(Ljava/lang/Object;JF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDoubleOpaque", "(Ljava/lang/Object;J)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putDoubleOpaque", "(Ljava/lang/Object;JD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReferenceAcquire", "(Ljava/lang/Object;J)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putReferenceRelease", "(Ljava/lang/Object;JLjava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBooleanAcquire", "(Ljava/lang/Object;J)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putBooleanRelease", "(Ljava/lang/Object;JZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByteAcquire", "(Ljava/lang/Object;J)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putByteRelease", "(Ljava/lang/Object;JB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShortAcquire", "(Ljava/lang/Object;J)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putShortRelease", "(Ljava/lang/Object;JS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharAcquire", "(Ljava/lang/Object;J)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putCharRelease", "(Ljava/lang/Object;JC)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIntAcquire", "(Ljava/lang/Object;J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putIntRelease", "(Ljava/lang/Object;JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLongAcquire", "(Ljava/lang/Object;J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putLongRelease", "(Ljava/lang/Object;JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFloatAcquire", "(Ljava/lang/Object;J)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putFloatRelease", "(Ljava/lang/Object;JF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDoubleAcquire", "(Ljava/lang/Object;J)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putDoubleRelease", "(Ljava/lang/Object;JD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShortUnaligned", "(Ljava/lang/Object;JZ)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShortUnaligned", "(Ljava/lang/Object;J)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putShortUnaligned", "(Ljava/lang/Object;JSZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putShortUnaligned", "(Ljava/lang/Object;JS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharUnaligned", "(Ljava/lang/Object;J)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharUnaligned", "(Ljava/lang/Object;JZ)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putCharUnaligned", "(Ljava/lang/Object;JC)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putCharUnaligned", "(Ljava/lang/Object;JCZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIntUnaligned", "(Ljava/lang/Object;J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIntUnaligned", "(Ljava/lang/Object;JZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putIntUnaligned", "(Ljava/lang/Object;JIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putIntUnaligned", "(Ljava/lang/Object;JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLongUnaligned", "(Ljava/lang/Object;JZ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLongUnaligned", "(Ljava/lang/Object;J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putLongUnaligned", "(Ljava/lang/Object;JJZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putLongUnaligned", "(Ljava/lang/Object;JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndSetReference", "(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeReference", "(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeReferenceAcquire", "(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeReferenceRelease", "(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndSetLong", "(Ljava/lang/Object;JJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeLong", "(Ljava/lang/Object;JJJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeLongAcquire", "(Ljava/lang/Object;JJJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeLongRelease", "(Ljava/lang/Object;JJJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndSetInt", "(Ljava/lang/Object;JII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeInt", "(Ljava/lang/Object;JII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeIntAcquire", "(Ljava/lang/Object;JII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeIntRelease", "(Ljava/lang/Object;JII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndSetByte", "(Ljava/lang/Object;JBB)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeByte", "(Ljava/lang/Object;JBB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeByteAcquire", "(Ljava/lang/Object;JBB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeByteRelease", "(Ljava/lang/Object;JBB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndSetShort", "(Ljava/lang/Object;JSS)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeShort", "(Ljava/lang/Object;JSS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeShortAcquire", "(Ljava/lang/Object;JSS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeShortRelease", "(Ljava/lang/Object;JSS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetReferencePlain", "(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetReferenceAcquire", "(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetReferenceRelease", "(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetReference", "(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetLongPlain", "(Ljava/lang/Object;JJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetLongAcquire", "(Ljava/lang/Object;JJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetLongRelease", "(Ljava/lang/Object;JJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetLong", "(Ljava/lang/Object;JJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetIntPlain", "(Ljava/lang/Object;JII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetIntAcquire", "(Ljava/lang/Object;JII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetIntRelease", "(Ljava/lang/Object;JII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetInt", "(Ljava/lang/Object;JII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetBytePlain", "(Ljava/lang/Object;JBB)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetByteAcquire", "(Ljava/lang/Object;JBB)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetByteRelease", "(Ljava/lang/Object;JBB)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetByte", "(Ljava/lang/Object;JBB)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetShortPlain", "(Ljava/lang/Object;JSS)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetShortAcquire", "(Ljava/lang/Object;JSS)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetShortRelease", "(Ljava/lang/Object;JSS)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetShort", "(Ljava/lang/Object;JSS)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAddInt", "(Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAddLong", "(Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAddByte", "(Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAddShort", "(Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetInt", "(Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetLong", "(Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetByte", "(Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetShort", "(Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetReference", "(Ljava/lang/Object;JLjava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "park", "(ZJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unpark", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwException", "(Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkOffset", "(Ljava/lang/Object;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getUnsafe", "()Ljdk/internal/misc/Unsafe;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "registerNatives", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineClass", "(Ljava/lang/String;[BIILjava/lang/ClassLoader;Ljava/security/ProtectionDomain;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "objectFieldOffset", "(Ljava/lang/Class;Ljava/lang/String;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "objectFieldOffset", "(Ljava/lang/reflect/Field;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineClass0", "(Ljava/lang/String;[BIILjava/lang/ClassLoader;Ljava/security/ProtectionDomain;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureClassInitialized", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "staticFieldBase", "(Ljava/lang/reflect/Field;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "staticFieldOffset", "(Ljava/lang/reflect/Field;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shouldBeInitialized", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndSetBoolean", "(Ljava/lang/Object;JZZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadLoadFence", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toUnsignedLong", "(I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toUnsignedLong", "(B)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toUnsignedLong", "(S)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAddress", "(Ljava/lang/Object;J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAddress", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putAddress", "(Ljava/lang/Object;JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putAddress", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "is32BitClean", "(J)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invalidInput", "()Ljava/lang/RuntimeException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkNativeAddress", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkPointer", "(Ljava/lang/Object;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkPrimitiveArray", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "alignToHeapWordSize", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allocateMemoryChecks", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allocateMemory0", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkSize", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reallocateMemoryChecks", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "freeMemory", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reallocateMemory0", "(JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMemoryChecks", "(Ljava/lang/Object;JJB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMemory0", "(Ljava/lang/Object;JJB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMemory", "(Ljava/lang/Object;JJB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMemory", "(JJB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkPrimitivePointer", "(Ljava/lang/Object;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyMemoryChecks", "(Ljava/lang/Object;JLjava/lang/Object;JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyMemory", "(JJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyMemory", "(Ljava/lang/Object;JLjava/lang/Object;JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copySwapMemoryChecks", "(Ljava/lang/Object;JLjava/lang/Object;JJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copySwapMemory0", "(Ljava/lang/Object;JLjava/lang/Object;JJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copySwapMemory", "(JJJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copySwapMemory", "(Ljava/lang/Object;JLjava/lang/Object;JJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "freeMemoryChecks", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "freeMemory0", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkWritebackEnabled", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkWritebackMemory", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dataCacheLineAlignDown", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dataCacheLineFlushSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isWritebackEnabled", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "objectFieldOffset0", "(Ljava/lang/reflect/Field;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "objectFieldOffset1", "(Ljava/lang/Class;Ljava/lang/String;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "staticFieldOffset0", "(Ljava/lang/reflect/Field;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "staticFieldBase0", "(Ljava/lang/reflect/Field;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shouldBeInitialized0", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureClassInitialized0", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "arrayBaseOffset0", "(Ljava/lang/Class;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "arrayIndexScale0", "(Ljava/lang/Class;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "c2s", "(C)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "s2c", "(S)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bool2byte", "(Z)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "byte2bool", "(B)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLoadAverage0", "([DI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAddShortRelease", "(Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAddShortAcquire", "(Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetByteRelease", "(Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetByteAcquire", "(Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetShortRelease", "(Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetShortAcquire", "(Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetIntRelease", "(Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetIntAcquire", "(Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetLongRelease", "(Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetLongAcquire", "(Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseOrByte", "(Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseOrByteRelease", "(Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseOrByteAcquire", "(Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseAndByte", "(Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseAndByteRelease", "(Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseAndByteAcquire", "(Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseXorByte", "(Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseXorByteRelease", "(Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseXorByteAcquire", "(Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseOrShort", "(Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseOrShortRelease", "(Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseOrShortAcquire", "(Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseAndShort", "(Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseAndShortRelease", "(Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseAndShortAcquire", "(Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseXorShort", "(Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseXorShortRelease", "(Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseXorShortAcquire", "(Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeLong", "(BBBBBBBB)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeLong", "(SSSS)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeLong", "(II)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "convEndian", "(ZC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "convEndian", "(ZJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "convEndian", "(ZI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "convEndian", "(ZS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeInt", "(BBBB)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeInt", "(SS)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeShort", "(BB)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putLongParts", "(Ljava/lang/Object;JSSSS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putLongParts", "(Ljava/lang/Object;JII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putLongParts", "(Ljava/lang/Object;JBBBBBBBB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putIntParts", "(Ljava/lang/Object;JBBBB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putIntParts", "(Ljava/lang/Object;JSS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putShortParts", "(Ljava/lang/Object;JBB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "pickPos", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toUnsignedInt", "(B)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toUnsignedInt", "(S)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "pick", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "pick", "(SS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "pick", "(BB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetReferenceAcquire", "(Ljava/lang/Object;JLjava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetReferenceRelease", "(Ljava/lang/Object;JLjava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "arrayBaseOffset", "(Ljava/lang/Class;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "arrayIndexScale", "(Ljava/lang/Class;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUncompressedObject", "(J)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allocateMemory", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reallocateMemory", "(JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writebackMemory", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addressSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pageSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allocateUninitializedArray", "(Ljava/lang/Class;I)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndSetChar", "(Ljava/lang/Object;JCC)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeChar", "(Ljava/lang/Object;JCC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeCharAcquire", "(Ljava/lang/Object;JCC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeCharRelease", "(Ljava/lang/Object;JCC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetChar", "(Ljava/lang/Object;JCC)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetCharAcquire", "(Ljava/lang/Object;JCC)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetCharRelease", "(Ljava/lang/Object;JCC)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetCharPlain", "(Ljava/lang/Object;JCC)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeBoolean", "(Ljava/lang/Object;JZZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeBooleanAcquire", "(Ljava/lang/Object;JZZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeBooleanRelease", "(Ljava/lang/Object;JZZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetBoolean", "(Ljava/lang/Object;JZZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetBooleanAcquire", "(Ljava/lang/Object;JZZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetBooleanRelease", "(Ljava/lang/Object;JZZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetBooleanPlain", "(Ljava/lang/Object;JZZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndSetFloat", "(Ljava/lang/Object;JFF)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeFloat", "(Ljava/lang/Object;JFF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeFloatAcquire", "(Ljava/lang/Object;JFF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeFloatRelease", "(Ljava/lang/Object;JFF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetFloatPlain", "(Ljava/lang/Object;JFF)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetFloatAcquire", "(Ljava/lang/Object;JFF)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetFloatRelease", "(Ljava/lang/Object;JFF)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetFloat", "(Ljava/lang/Object;JFF)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndSetDouble", "(Ljava/lang/Object;JDD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeDouble", "(Ljava/lang/Object;JDD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeDoubleAcquire", "(Ljava/lang/Object;JDD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeDoubleRelease", "(Ljava/lang/Object;JDD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetDoublePlain", "(Ljava/lang/Object;JDD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetDoubleAcquire", "(Ljava/lang/Object;JDD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetDoubleRelease", "(Ljava/lang/Object;JDD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetDouble", "(Ljava/lang/Object;JDD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLoadAverage", "([DI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAddIntRelease", "(Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAddIntAcquire", "(Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAddLongRelease", "(Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAddLongAcquire", "(Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAddByteRelease", "(Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAddByteAcquire", "(Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAddChar", "(Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAddCharRelease", "(Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAddCharAcquire", "(Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAddFloat", "(Ljava/lang/Object;JF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAddFloatRelease", "(Ljava/lang/Object;JF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAddFloatAcquire", "(Ljava/lang/Object;JF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAddDouble", "(Ljava/lang/Object;JD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAddDoubleRelease", "(Ljava/lang/Object;JD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAddDoubleAcquire", "(Ljava/lang/Object;JD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetBoolean", "(Ljava/lang/Object;JZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetBooleanRelease", "(Ljava/lang/Object;JZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetBooleanAcquire", "(Ljava/lang/Object;JZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetChar", "(Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetCharRelease", "(Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetCharAcquire", "(Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetFloat", "(Ljava/lang/Object;JF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetFloatRelease", "(Ljava/lang/Object;JF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetFloatAcquire", "(Ljava/lang/Object;JF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetDouble", "(Ljava/lang/Object;JD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetDoubleRelease", "(Ljava/lang/Object;JD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetDoubleAcquire", "(Ljava/lang/Object;JD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseOrBoolean", "(Ljava/lang/Object;JZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseOrBooleanRelease", "(Ljava/lang/Object;JZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseOrBooleanAcquire", "(Ljava/lang/Object;JZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseAndBoolean", "(Ljava/lang/Object;JZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseAndBooleanRelease", "(Ljava/lang/Object;JZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseAndBooleanAcquire", "(Ljava/lang/Object;JZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseXorBoolean", "(Ljava/lang/Object;JZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseXorBooleanRelease", "(Ljava/lang/Object;JZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseXorBooleanAcquire", "(Ljava/lang/Object;JZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseOrChar", "(Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseOrCharRelease", "(Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseOrCharAcquire", "(Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseAndChar", "(Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseAndCharRelease", "(Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseAndCharAcquire", "(Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseXorChar", "(Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseXorCharRelease", "(Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseXorCharAcquire", "(Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseOrInt", "(Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseOrIntRelease", "(Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseOrIntAcquire", "(Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseAndInt", "(Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseAndIntRelease", "(Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseAndIntAcquire", "(Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseXorInt", "(Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseXorIntRelease", "(Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseXorIntAcquire", "(Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseOrLong", "(Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseOrLongRelease", "(Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseOrLongAcquire", "(Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseAndLong", "(Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseAndLongRelease", "(Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseAndLongAcquire", "(Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseXorLong", "(Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseXorLongRelease", "(Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndBitwiseXorLongAcquire", "(Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "throwIllegalAccessError", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "throwNoSuchMethodError", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isBigEndian", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unalignedAccess", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeCleaner", "(Ljava/nio/ByteBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObject", "(Ljava/lang/Object;J)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObjectVolatile", "(Ljava/lang/Object;J)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObjectAcquire", "(Ljava/lang/Object;J)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObjectOpaque", "(Ljava/lang/Object;J)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putObject", "(Ljava/lang/Object;JLjava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putObjectVolatile", "(Ljava/lang/Object;JLjava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putObjectOpaque", "(Ljava/lang/Object;JLjava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putObjectRelease", "(Ljava/lang/Object;JLjava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetObject", "(Ljava/lang/Object;JLjava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetObjectAcquire", "(Ljava/lang/Object;JLjava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSetObjectRelease", "(Ljava/lang/Object;JLjava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndSetObject", "(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeObject", "(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeObjectAcquire", "(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeObjectRelease", "(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetObject", "(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetObjectAcquire", "(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetObjectPlain", "(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetObjectRelease", "(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Z"));
	}

	[JniSignatureAttribute("Ljdk/internal/misc/Unsafe;", "private static final")]
	public static Dova.JDK.jdk.@internal.misc.Unsafe theUnsafe_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int INVALID_FIELD_OFFSET_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int ARRAY_BOOLEAN_BASE_OFFSET_Property
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
	public static int ARRAY_BYTE_BASE_OFFSET_Property
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
	public static int ARRAY_SHORT_BASE_OFFSET_Property
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
	public static int ARRAY_CHAR_BASE_OFFSET_Property
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
	public static int ARRAY_INT_BASE_OFFSET_Property
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
	public static int ARRAY_LONG_BASE_OFFSET_Property
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
	public static int ARRAY_FLOAT_BASE_OFFSET_Property
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
	public static int ARRAY_DOUBLE_BASE_OFFSET_Property
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
	public static int ARRAY_OBJECT_BASE_OFFSET_Property
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
	public static int ARRAY_BOOLEAN_INDEX_SCALE_Property
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
	public static int ARRAY_BYTE_INDEX_SCALE_Property
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
	public static int ARRAY_SHORT_INDEX_SCALE_Property
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
	public static int ARRAY_CHAR_INDEX_SCALE_Property
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
	public static int ARRAY_INT_INDEX_SCALE_Property
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
	public static int ARRAY_LONG_INDEX_SCALE_Property
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
	public static int ARRAY_FLOAT_INDEX_SCALE_Property
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
	public static int ARRAY_DOUBLE_INDEX_SCALE_Property
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
	public static int ARRAY_OBJECT_INDEX_SCALE_Property
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
	public static int ADDRESS_SIZE_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Unsafe(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public Unsafe() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/misc/Unsafe;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(J)V", "private native")]
	public void writeback0(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()V", "private native")]
	public void writebackPreSync0()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("()V", "private native")]
	public void writebackPostSync0()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Object;", "public native")]
	public Dova.JDK.java.lang.Object allocateInstance(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;I)Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object allocateUninitializedArray0(Dova.JDK.java.lang.Class arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;JJ)V", "private native")]
	public void copyMemory0(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2, long arg3, long arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("()V", "public final")]
	public void loadFence()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("()V", "public final")]
	public void storeFence()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("()V", "public final")]
	public void storeStoreFence()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("()V", "public native")]
	public void fullFence()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)Ljava/lang/Object;", "public native")]
	public Dova.JDK.java.lang.Object getReference(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;)V", "public native")]
	public void putReference(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)Z", "public native")]
	public bool getBoolean(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZ)V", "public native")]
	public void putBoolean(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)B", "public native")]
	public byte getByte(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)B", "public")]
	public byte getByte(long arg0)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JB)V", "public native")]
	public void putByte(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JB)V", "public")]
	public void putByte(long arg0, byte arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)S", "public native")]
	public short getShort(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)S", "public")]
	public short getShort(long arg0)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JS)V", "public")]
	public void putShort(long arg0, short arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JS)V", "public native")]
	public void putShort(Dova.JDK.java.lang.Object arg0, long arg1, short arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(J)C", "public")]
	public char getChar(long arg0)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)C", "public native")]
	public char getChar(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JC)V", "public native")]
	public void putChar(Dova.JDK.java.lang.Object arg0, long arg1, char arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JC)V", "public")]
	public void putChar(long arg0, char arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
	}

	[JniSignatureAttribute("(J)I", "public")]
	public int getInt(long arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)I", "public native")]
	public int getInt(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(JI)V", "public")]
	public void putInt(long arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JI)V", "public native")]
	public void putInt(Dova.JDK.java.lang.Object arg0, long arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)J", "public native")]
	public long getLong(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "public")]
	public long getLong(long arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJ)V", "public native")]
	public void putLong(Dova.JDK.java.lang.Object arg0, long arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JJ)V", "public")]
	public void putLong(long arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)F", "public native")]
	public float getFloat(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)F", "public")]
	public float getFloat(long arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JF)V", "public")]
	public void putFloat(long arg0, float arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JF)V", "public native")]
	public void putFloat(Dova.JDK.java.lang.Object arg0, long arg1, float arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(J)D", "public")]
	public double getDouble(long arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)D", "public native")]
	public double getDouble(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JD)V", "public native")]
	public void putDouble(Dova.JDK.java.lang.Object arg0, long arg1, double arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JD)V", "public")]
	public void putDouble(long arg0, double arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)Ljava/lang/Object;", "public native")]
	public Dova.JDK.java.lang.Object getReferenceVolatile(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;)V", "public native")]
	public void putReferenceVolatile(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)Z", "public native")]
	public bool getBooleanVolatile(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZ)V", "public native")]
	public void putBooleanVolatile(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)B", "public native")]
	public byte getByteVolatile(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JB)V", "public native")]
	public void putByteVolatile(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)S", "public native")]
	public short getShortVolatile(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JS)V", "public native")]
	public void putShortVolatile(Dova.JDK.java.lang.Object arg0, long arg1, short arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)C", "public native")]
	public char getCharVolatile(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JC)V", "public native")]
	public void putCharVolatile(Dova.JDK.java.lang.Object arg0, long arg1, char arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)I", "public native")]
	public int getIntVolatile(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JI)V", "public native")]
	public void putIntVolatile(Dova.JDK.java.lang.Object arg0, long arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)J", "public native")]
	public long getLongVolatile(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJ)V", "public native")]
	public void putLongVolatile(Dova.JDK.java.lang.Object arg0, long arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)F", "public native")]
	public float getFloatVolatile(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JF)V", "public native")]
	public void putFloatVolatile(Dova.JDK.java.lang.Object arg0, long arg1, float arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[57], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)D", "public native")]
	public double getDoubleVolatile(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[58], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JD)V", "public native")]
	public void putDoubleVolatile(Dova.JDK.java.lang.Object arg0, long arg1, double arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[59], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object getReferenceOpaque(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;)V", "public final")]
	public void putReferenceOpaque(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[61], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)Z", "public final")]
	public bool getBooleanOpaque(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[62], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZ)V", "public final")]
	public void putBooleanOpaque(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[63], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)B", "public final")]
	public byte getByteOpaque(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[64], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JB)V", "public final")]
	public void putByteOpaque(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[65], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)S", "public final")]
	public short getShortOpaque(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[66], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JS)V", "public final")]
	public void putShortOpaque(Dova.JDK.java.lang.Object arg0, long arg1, short arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[67], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)C", "public final")]
	public char getCharOpaque(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[68], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JC)V", "public final")]
	public void putCharOpaque(Dova.JDK.java.lang.Object arg0, long arg1, char arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[69], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)I", "public final")]
	public int getIntOpaque(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[70], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JI)V", "public final")]
	public void putIntOpaque(Dova.JDK.java.lang.Object arg0, long arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[71], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)J", "public final")]
	public long getLongOpaque(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[72], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJ)V", "public final")]
	public void putLongOpaque(Dova.JDK.java.lang.Object arg0, long arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[73], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)F", "public final")]
	public float getFloatOpaque(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[74], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JF)V", "public final")]
	public void putFloatOpaque(Dova.JDK.java.lang.Object arg0, long arg1, float arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[75], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)D", "public final")]
	public double getDoubleOpaque(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[76], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JD)V", "public final")]
	public void putDoubleOpaque(Dova.JDK.java.lang.Object arg0, long arg1, double arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[77], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object getReferenceAcquire(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[78], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;)V", "public final")]
	public void putReferenceRelease(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[79], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)Z", "public final")]
	public bool getBooleanAcquire(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[80], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZ)V", "public final")]
	public void putBooleanRelease(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[81], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)B", "public final")]
	public byte getByteAcquire(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[82], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JB)V", "public final")]
	public void putByteRelease(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[83], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)S", "public final")]
	public short getShortAcquire(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[84], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JS)V", "public final")]
	public void putShortRelease(Dova.JDK.java.lang.Object arg0, long arg1, short arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[85], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)C", "public final")]
	public char getCharAcquire(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[86], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JC)V", "public final")]
	public void putCharRelease(Dova.JDK.java.lang.Object arg0, long arg1, char arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[87], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)I", "public final")]
	public int getIntAcquire(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[88], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JI)V", "public final")]
	public void putIntRelease(Dova.JDK.java.lang.Object arg0, long arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[89], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)J", "public final")]
	public long getLongAcquire(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[90], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJ)V", "public final")]
	public void putLongRelease(Dova.JDK.java.lang.Object arg0, long arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[91], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)F", "public final")]
	public float getFloatAcquire(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[92], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JF)V", "public final")]
	public void putFloatRelease(Dova.JDK.java.lang.Object arg0, long arg1, float arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[93], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)D", "public final")]
	public double getDoubleAcquire(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[94], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JD)V", "public final")]
	public void putDoubleRelease(Dova.JDK.java.lang.Object arg0, long arg1, double arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[95], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZ)S", "public final")]
	public short getShortUnaligned(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[96], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)S", "public final")]
	public short getShortUnaligned(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[97], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JSZ)V", "public final")]
	public void putShortUnaligned(Dova.JDK.java.lang.Object arg0, long arg1, short arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[98], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JS)V", "public final")]
	public void putShortUnaligned(Dova.JDK.java.lang.Object arg0, long arg1, short arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[99], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)C", "public final")]
	public char getCharUnaligned(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[100], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZ)C", "public final")]
	public char getCharUnaligned(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[101], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JC)V", "public final")]
	public void putCharUnaligned(Dova.JDK.java.lang.Object arg0, long arg1, char arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[102], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JCZ)V", "public final")]
	public void putCharUnaligned(Dova.JDK.java.lang.Object arg0, long arg1, char arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[103], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)I", "public final")]
	public int getIntUnaligned(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[104], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZ)I", "public final")]
	public int getIntUnaligned(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[105], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JIZ)V", "public final")]
	public void putIntUnaligned(Dova.JDK.java.lang.Object arg0, long arg1, int arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[106], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JI)V", "public final")]
	public void putIntUnaligned(Dova.JDK.java.lang.Object arg0, long arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[107], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZ)J", "public final")]
	public long getLongUnaligned(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[108], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)J", "public final")]
	public long getLongUnaligned(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[109], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJZ)V", "public final")]
	public void putLongUnaligned(Dova.JDK.java.lang.Object arg0, long arg1, long arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[110], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJ)V", "public final")]
	public void putLongUnaligned(Dova.JDK.java.lang.Object arg0, long arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[111], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Z", "public final native")]
	public bool compareAndSetReference(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[112], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "public final native")]
	public Dova.JDK.java.lang.Object compareAndExchangeReference(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[113], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object compareAndExchangeReferenceAcquire(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[114], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object compareAndExchangeReferenceRelease(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[115], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJJ)Z", "public final native")]
	public bool compareAndSetLong(Dova.JDK.java.lang.Object arg0, long arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[116], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJJ)J", "public final native")]
	public long compareAndExchangeLong(Dova.JDK.java.lang.Object arg0, long arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[117], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJJ)J", "public final")]
	public long compareAndExchangeLongAcquire(Dova.JDK.java.lang.Object arg0, long arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[118], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJJ)J", "public final")]
	public long compareAndExchangeLongRelease(Dova.JDK.java.lang.Object arg0, long arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[119], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JII)Z", "public final native")]
	public bool compareAndSetInt(Dova.JDK.java.lang.Object arg0, long arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[120], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JII)I", "public final native")]
	public int compareAndExchangeInt(Dova.JDK.java.lang.Object arg0, long arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[121], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JII)I", "public final")]
	public int compareAndExchangeIntAcquire(Dova.JDK.java.lang.Object arg0, long arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[122], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JII)I", "public final")]
	public int compareAndExchangeIntRelease(Dova.JDK.java.lang.Object arg0, long arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[123], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JBB)Z", "public final")]
	public bool compareAndSetByte(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[124], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JBB)B", "public final")]
	public byte compareAndExchangeByte(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[125], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JBB)B", "public final")]
	public byte compareAndExchangeByteAcquire(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[126], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JBB)B", "public final")]
	public byte compareAndExchangeByteRelease(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[127], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JSS)Z", "public final")]
	public bool compareAndSetShort(Dova.JDK.java.lang.Object arg0, long arg1, short arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[128], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JSS)S", "public final")]
	public short compareAndExchangeShort(Dova.JDK.java.lang.Object arg0, long arg1, short arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[129], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JSS)S", "public final")]
	public short compareAndExchangeShortAcquire(Dova.JDK.java.lang.Object arg0, long arg1, short arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[130], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JSS)S", "public final")]
	public short compareAndExchangeShortRelease(Dova.JDK.java.lang.Object arg0, long arg1, short arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[131], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Z", "public final")]
	public bool weakCompareAndSetReferencePlain(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[132], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Z", "public final")]
	public bool weakCompareAndSetReferenceAcquire(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[133], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Z", "public final")]
	public bool weakCompareAndSetReferenceRelease(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[134], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Z", "public final")]
	public bool weakCompareAndSetReference(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[135], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJJ)Z", "public final")]
	public bool weakCompareAndSetLongPlain(Dova.JDK.java.lang.Object arg0, long arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[136], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJJ)Z", "public final")]
	public bool weakCompareAndSetLongAcquire(Dova.JDK.java.lang.Object arg0, long arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[137], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJJ)Z", "public final")]
	public bool weakCompareAndSetLongRelease(Dova.JDK.java.lang.Object arg0, long arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[138], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJJ)Z", "public final")]
	public bool weakCompareAndSetLong(Dova.JDK.java.lang.Object arg0, long arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[139], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JII)Z", "public final")]
	public bool weakCompareAndSetIntPlain(Dova.JDK.java.lang.Object arg0, long arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[140], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JII)Z", "public final")]
	public bool weakCompareAndSetIntAcquire(Dova.JDK.java.lang.Object arg0, long arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[141], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JII)Z", "public final")]
	public bool weakCompareAndSetIntRelease(Dova.JDK.java.lang.Object arg0, long arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[142], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JII)Z", "public final")]
	public bool weakCompareAndSetInt(Dova.JDK.java.lang.Object arg0, long arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[143], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JBB)Z", "public final")]
	public bool weakCompareAndSetBytePlain(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[144], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JBB)Z", "public final")]
	public bool weakCompareAndSetByteAcquire(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[145], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JBB)Z", "public final")]
	public bool weakCompareAndSetByteRelease(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[146], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JBB)Z", "public final")]
	public bool weakCompareAndSetByte(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[147], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JSS)Z", "public final")]
	public bool weakCompareAndSetShortPlain(Dova.JDK.java.lang.Object arg0, long arg1, short arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[148], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JSS)Z", "public final")]
	public bool weakCompareAndSetShortAcquire(Dova.JDK.java.lang.Object arg0, long arg1, short arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[149], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JSS)Z", "public final")]
	public bool weakCompareAndSetShortRelease(Dova.JDK.java.lang.Object arg0, long arg1, short arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[150], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JSS)Z", "public final")]
	public bool weakCompareAndSetShort(Dova.JDK.java.lang.Object arg0, long arg1, short arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[151], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JI)I", "public final")]
	public int getAndAddInt(Dova.JDK.java.lang.Object arg0, long arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[152], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJ)J", "public final")]
	public long getAndAddLong(Dova.JDK.java.lang.Object arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[153], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JB)B", "public final")]
	public byte getAndAddByte(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[154], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JS)S", "public final")]
	public short getAndAddShort(Dova.JDK.java.lang.Object arg0, long arg1, short arg2)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[155], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JI)I", "public final")]
	public int getAndSetInt(Dova.JDK.java.lang.Object arg0, long arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[156], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJ)J", "public final")]
	public long getAndSetLong(Dova.JDK.java.lang.Object arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[157], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JB)B", "public final")]
	public byte getAndSetByte(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[158], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JS)S", "public final")]
	public short getAndSetShort(Dova.JDK.java.lang.Object arg0, long arg1, short arg2)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[159], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object getAndSetReference(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[160], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(ZJ)V", "public native")]
	public void park(bool arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[161], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public native")]
	public void unpark(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[162], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "public native")]
	public void throwException(Dova.JDK.java.lang.Throwable arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[163], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)V", "private")]
	public void checkOffset(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[164], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljdk/internal/misc/Unsafe;", "public static")]
	public static Dova.JDK.jdk.@internal.misc.Unsafe getUnsafe()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[165]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.misc.Unsafe>(ret);
	}

	[JniSignatureAttribute("()V", "private static native")]
	public static void registerNatives()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[166]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[BIILjava/lang/ClassLoader;Ljava/security/ProtectionDomain;)Ljava/lang/Class;", "public")]
	public Dova.JDK.java.lang.Class defineClass(Dova.JDK.java.lang.String arg0, JavaArray<byte> arg1, int arg2, int arg3, Dova.JDK.java.lang.ClassLoader arg4, Dova.JDK.java.security.ProtectionDomain arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[167], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;)J", "public")]
	public long objectFieldOffset(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[168], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;)J", "public")]
	public long objectFieldOffset(Dova.JDK.java.lang.reflect.Field arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[169], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;[BIILjava/lang/ClassLoader;Ljava/security/ProtectionDomain;)Ljava/lang/Class;", "public native")]
	public Dova.JDK.java.lang.Class defineClass0(Dova.JDK.java.lang.String arg0, JavaArray<byte> arg1, int arg2, int arg3, Dova.JDK.java.lang.ClassLoader arg4, Dova.JDK.java.security.ProtectionDomain arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[170], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "public")]
	public void ensureClassInitialized(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[171], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object staticFieldBase(Dova.JDK.java.lang.reflect.Field arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[172], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;)J", "public")]
	public long staticFieldOffset(Dova.JDK.java.lang.reflect.Field arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[173], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public")]
	public bool shouldBeInitialized(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[174], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZZ)Z", "public final")]
	public bool compareAndSetBoolean(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[175], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("()V", "public final")]
	public void loadLoadFence()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[176]);
	}

	[JniSignatureAttribute("(I)J", "private static")]
	public static long toUnsignedLong(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[177], arg0);
		return ret;
	}

	[JniSignatureAttribute("(B)J", "private static")]
	public static long toUnsignedLong(byte arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[178], arg0);
		return ret;
	}

	[JniSignatureAttribute("(S)J", "private static")]
	public static long toUnsignedLong(short arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[179], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)J", "public")]
	public long getAddress(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[180], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "public")]
	public long getAddress(long arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[181], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJ)V", "public")]
	public void putAddress(Dova.JDK.java.lang.Object arg0, long arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[182], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JJ)V", "public")]
	public void putAddress(long arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[183], arg0, arg1);
	}

	[JniSignatureAttribute("(J)Z", "private")]
	public bool is32BitClean(long arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[184], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/RuntimeException;", "private")]
	public Dova.JDK.java.lang.RuntimeException invalidInput()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[185]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.RuntimeException>(ret);
	}

	[JniSignatureAttribute("(J)V", "private")]
	public void checkNativeAddress(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[186], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)V", "private")]
	public void checkPointer(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[187], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "private")]
	public void checkPrimitiveArray(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[188], arg0);
	}

	[JniSignatureAttribute("(J)J", "private")]
	public long alignToHeapWordSize(long arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[189], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "private")]
	public void allocateMemoryChecks(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[190], arg0);
	}

	[JniSignatureAttribute("(J)J", "private native")]
	public long allocateMemory0(long arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[191], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "private")]
	public void checkSize(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[192], arg0);
	}

	[JniSignatureAttribute("(JJ)V", "private")]
	public void reallocateMemoryChecks(long arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[193], arg0, arg1);
	}

	[JniSignatureAttribute("(J)V", "public")]
	public void freeMemory(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[194], arg0);
	}

	[JniSignatureAttribute("(JJ)J", "private native")]
	public long reallocateMemory0(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[195], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJB)V", "private")]
	public void setMemoryChecks(Dova.JDK.java.lang.Object arg0, long arg1, long arg2, byte arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[196], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJB)V", "private native")]
	public void setMemory0(Dova.JDK.java.lang.Object arg0, long arg1, long arg2, byte arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[197], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJB)V", "public")]
	public void setMemory(Dova.JDK.java.lang.Object arg0, long arg1, long arg2, byte arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[198], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(JJB)V", "public")]
	public void setMemory(long arg0, long arg1, byte arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[199], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)V", "private")]
	public void checkPrimitivePointer(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[200], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;JJ)V", "private")]
	public void copyMemoryChecks(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2, long arg3, long arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[201], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(JJJ)V", "public")]
	public void copyMemory(long arg0, long arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[202], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;JJ)V", "public")]
	public void copyMemory(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2, long arg3, long arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[203], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;JJJ)V", "private")]
	public void copySwapMemoryChecks(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2, long arg3, long arg4, long arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[204], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;JJJ)V", "private native")]
	public void copySwapMemory0(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2, long arg3, long arg4, long arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[205], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(JJJJ)V", "public")]
	public void copySwapMemory(long arg0, long arg1, long arg2, long arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[206], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;JJJ)V", "public")]
	public void copySwapMemory(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2, long arg3, long arg4, long arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[207], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(J)V", "private")]
	public void freeMemoryChecks(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[208], arg0);
	}

	[JniSignatureAttribute("(J)V", "private native")]
	public void freeMemory0(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[209], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void checkWritebackEnabled()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[210]);
	}

	[JniSignatureAttribute("(JJ)V", "private")]
	public void checkWritebackMemory(long arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[211], arg0, arg1);
	}

	[JniSignatureAttribute("(J)J", "public")]
	public long dataCacheLineAlignDown(long arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[212], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int dataCacheLineFlushSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[213]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isWritebackEnabled()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[214]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;)J", "private native")]
	public long objectFieldOffset0(Dova.JDK.java.lang.reflect.Field arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[215], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;)J", "private native")]
	public long objectFieldOffset1(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[216], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;)J", "private native")]
	public long staticFieldOffset0(Dova.JDK.java.lang.reflect.Field arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[217], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Ljava/lang/Object;", "private native")]
	public Dova.JDK.java.lang.Object staticFieldBase0(Dova.JDK.java.lang.reflect.Field arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[218], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "private native")]
	public bool shouldBeInitialized0(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[219], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "private native")]
	public void ensureClassInitialized0(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[220], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)I", "private native")]
	public int arrayBaseOffset0(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[221], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)I", "private native")]
	public int arrayIndexScale0(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[222], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)S", "private")]
	public short c2s(char arg0)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[223], arg0);
		return ret;
	}

	[JniSignatureAttribute("(S)C", "private")]
	public char s2c(short arg0)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[224], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Z)B", "private")]
	public byte bool2byte(bool arg0)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[225], arg0);
		return ret;
	}

	[JniSignatureAttribute("(B)Z", "private")]
	public bool byte2bool(byte arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[226], arg0);
		return ret;
	}

	[JniSignatureAttribute("([DI)I", "private native")]
	public int getLoadAverage0(JavaArray<double> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[227], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JS)S", "public final")]
	public short getAndAddShortRelease(Dova.JDK.java.lang.Object arg0, long arg1, short arg2)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[228], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JS)S", "public final")]
	public short getAndAddShortAcquire(Dova.JDK.java.lang.Object arg0, long arg1, short arg2)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[229], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JB)B", "public final")]
	public byte getAndSetByteRelease(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[230], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JB)B", "public final")]
	public byte getAndSetByteAcquire(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[231], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JS)S", "public final")]
	public short getAndSetShortRelease(Dova.JDK.java.lang.Object arg0, long arg1, short arg2)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[232], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JS)S", "public final")]
	public short getAndSetShortAcquire(Dova.JDK.java.lang.Object arg0, long arg1, short arg2)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[233], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JI)I", "public final")]
	public int getAndSetIntRelease(Dova.JDK.java.lang.Object arg0, long arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[234], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JI)I", "public final")]
	public int getAndSetIntAcquire(Dova.JDK.java.lang.Object arg0, long arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[235], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJ)J", "public final")]
	public long getAndSetLongRelease(Dova.JDK.java.lang.Object arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[236], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJ)J", "public final")]
	public long getAndSetLongAcquire(Dova.JDK.java.lang.Object arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[237], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JB)B", "public final")]
	public byte getAndBitwiseOrByte(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[238], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JB)B", "public final")]
	public byte getAndBitwiseOrByteRelease(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[239], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JB)B", "public final")]
	public byte getAndBitwiseOrByteAcquire(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[240], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JB)B", "public final")]
	public byte getAndBitwiseAndByte(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[241], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JB)B", "public final")]
	public byte getAndBitwiseAndByteRelease(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[242], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JB)B", "public final")]
	public byte getAndBitwiseAndByteAcquire(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[243], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JB)B", "public final")]
	public byte getAndBitwiseXorByte(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[244], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JB)B", "public final")]
	public byte getAndBitwiseXorByteRelease(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[245], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JB)B", "public final")]
	public byte getAndBitwiseXorByteAcquire(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[246], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JS)S", "public final")]
	public short getAndBitwiseOrShort(Dova.JDK.java.lang.Object arg0, long arg1, short arg2)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[247], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JS)S", "public final")]
	public short getAndBitwiseOrShortRelease(Dova.JDK.java.lang.Object arg0, long arg1, short arg2)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[248], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JS)S", "public final")]
	public short getAndBitwiseOrShortAcquire(Dova.JDK.java.lang.Object arg0, long arg1, short arg2)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[249], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JS)S", "public final")]
	public short getAndBitwiseAndShort(Dova.JDK.java.lang.Object arg0, long arg1, short arg2)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[250], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JS)S", "public final")]
	public short getAndBitwiseAndShortRelease(Dova.JDK.java.lang.Object arg0, long arg1, short arg2)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[251], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JS)S", "public final")]
	public short getAndBitwiseAndShortAcquire(Dova.JDK.java.lang.Object arg0, long arg1, short arg2)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[252], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JS)S", "public final")]
	public short getAndBitwiseXorShort(Dova.JDK.java.lang.Object arg0, long arg1, short arg2)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[253], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JS)S", "public final")]
	public short getAndBitwiseXorShortRelease(Dova.JDK.java.lang.Object arg0, long arg1, short arg2)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[254], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JS)S", "public final")]
	public short getAndBitwiseXorShortAcquire(Dova.JDK.java.lang.Object arg0, long arg1, short arg2)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[255], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(BBBBBBBB)J", "private static")]
	public static long makeLong(byte arg0, byte arg1, byte arg2, byte arg3, byte arg4, byte arg5, byte arg6, byte arg7)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[256], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return ret;
	}

	[JniSignatureAttribute("(SSSS)J", "private static")]
	public static long makeLong(short arg0, short arg1, short arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[257], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(II)J", "private static")]
	public static long makeLong(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[258], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(ZC)C", "private static")]
	public static char convEndian(bool arg0, char arg1)
	{
		var ret = DovaVM.Runtime.CallStaticCharMethodA(ClassRefPtr, MethodPtrs[259], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(ZJ)J", "private static")]
	public static long convEndian(bool arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[260], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(ZI)I", "private static")]
	public static int convEndian(bool arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[261], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(ZS)S", "private static")]
	public static short convEndian(bool arg0, short arg1)
	{
		var ret = DovaVM.Runtime.CallStaticShortMethodA(ClassRefPtr, MethodPtrs[262], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(BBBB)I", "private static")]
	public static int makeInt(byte arg0, byte arg1, byte arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[263], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(SS)I", "private static")]
	public static int makeInt(short arg0, short arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[264], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(BB)S", "private static")]
	public static short makeShort(byte arg0, byte arg1)
	{
		var ret = DovaVM.Runtime.CallStaticShortMethodA(ClassRefPtr, MethodPtrs[265], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JSSSS)V", "private")]
	public void putLongParts(Dova.JDK.java.lang.Object arg0, long arg1, short arg2, short arg3, short arg4, short arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[266], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JII)V", "private")]
	public void putLongParts(Dova.JDK.java.lang.Object arg0, long arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[267], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JBBBBBBBB)V", "private")]
	public void putLongParts(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2, byte arg3, byte arg4, byte arg5, byte arg6, byte arg7, byte arg8, byte arg9)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[268], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JBBBB)V", "private")]
	public void putIntParts(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2, byte arg3, byte arg4, byte arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[269], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JSS)V", "private")]
	public void putIntParts(Dova.JDK.java.lang.Object arg0, long arg1, short arg2, short arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[270], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JBB)V", "private")]
	public void putShortParts(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2, byte arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[271], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(II)I", "private static")]
	public static int pickPos(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[272], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(B)I", "private static")]
	public static int toUnsignedInt(byte arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[273], arg0);
		return ret;
	}

	[JniSignatureAttribute("(S)I", "private static")]
	public static int toUnsignedInt(short arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[274], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "private static")]
	public static int pick(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[275], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(SS)S", "private static")]
	public static short pick(short arg0, short arg1)
	{
		var ret = DovaVM.Runtime.CallStaticShortMethodA(ClassRefPtr, MethodPtrs[276], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(BB)B", "private static")]
	public static byte pick(byte arg0, byte arg1)
	{
		var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[277], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object getAndSetReferenceAcquire(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[278], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object getAndSetReferenceRelease(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[279], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)I", "public")]
	public int arrayBaseOffset(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[280], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)I", "public")]
	public int arrayIndexScale(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[281], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)Ljava/lang/Object;", "public native")]
	public Dova.JDK.java.lang.Object getUncompressedObject(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[282], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(J)J", "public")]
	public long allocateMemory(long arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[283], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JJ)J", "public")]
	public long reallocateMemory(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[284], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(JJ)V", "public")]
	public void writebackMemory(long arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[285], arg0, arg1);
	}

	[JniSignatureAttribute("()I", "public")]
	public int addressSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[286]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int pageSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[287]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;I)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object allocateUninitializedArray(Dova.JDK.java.lang.Class arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[288], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JCC)Z", "public final")]
	public bool compareAndSetChar(Dova.JDK.java.lang.Object arg0, long arg1, char arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[289], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JCC)C", "public final")]
	public char compareAndExchangeChar(Dova.JDK.java.lang.Object arg0, long arg1, char arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[290], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JCC)C", "public final")]
	public char compareAndExchangeCharAcquire(Dova.JDK.java.lang.Object arg0, long arg1, char arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[291], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JCC)C", "public final")]
	public char compareAndExchangeCharRelease(Dova.JDK.java.lang.Object arg0, long arg1, char arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[292], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JCC)Z", "public final")]
	public bool weakCompareAndSetChar(Dova.JDK.java.lang.Object arg0, long arg1, char arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[293], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JCC)Z", "public final")]
	public bool weakCompareAndSetCharAcquire(Dova.JDK.java.lang.Object arg0, long arg1, char arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[294], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JCC)Z", "public final")]
	public bool weakCompareAndSetCharRelease(Dova.JDK.java.lang.Object arg0, long arg1, char arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[295], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JCC)Z", "public final")]
	public bool weakCompareAndSetCharPlain(Dova.JDK.java.lang.Object arg0, long arg1, char arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[296], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZZ)Z", "public final")]
	public bool compareAndExchangeBoolean(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[297], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZZ)Z", "public final")]
	public bool compareAndExchangeBooleanAcquire(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[298], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZZ)Z", "public final")]
	public bool compareAndExchangeBooleanRelease(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[299], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZZ)Z", "public final")]
	public bool weakCompareAndSetBoolean(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[300], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZZ)Z", "public final")]
	public bool weakCompareAndSetBooleanAcquire(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[301], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZZ)Z", "public final")]
	public bool weakCompareAndSetBooleanRelease(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[302], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZZ)Z", "public final")]
	public bool weakCompareAndSetBooleanPlain(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[303], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JFF)Z", "public final")]
	public bool compareAndSetFloat(Dova.JDK.java.lang.Object arg0, long arg1, float arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[304], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JFF)F", "public final")]
	public float compareAndExchangeFloat(Dova.JDK.java.lang.Object arg0, long arg1, float arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[305], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JFF)F", "public final")]
	public float compareAndExchangeFloatAcquire(Dova.JDK.java.lang.Object arg0, long arg1, float arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[306], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JFF)F", "public final")]
	public float compareAndExchangeFloatRelease(Dova.JDK.java.lang.Object arg0, long arg1, float arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[307], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JFF)Z", "public final")]
	public bool weakCompareAndSetFloatPlain(Dova.JDK.java.lang.Object arg0, long arg1, float arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[308], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JFF)Z", "public final")]
	public bool weakCompareAndSetFloatAcquire(Dova.JDK.java.lang.Object arg0, long arg1, float arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[309], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JFF)Z", "public final")]
	public bool weakCompareAndSetFloatRelease(Dova.JDK.java.lang.Object arg0, long arg1, float arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[310], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JFF)Z", "public final")]
	public bool weakCompareAndSetFloat(Dova.JDK.java.lang.Object arg0, long arg1, float arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[311], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JDD)Z", "public final")]
	public bool compareAndSetDouble(Dova.JDK.java.lang.Object arg0, long arg1, double arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[312], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JDD)D", "public final")]
	public double compareAndExchangeDouble(Dova.JDK.java.lang.Object arg0, long arg1, double arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[313], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JDD)D", "public final")]
	public double compareAndExchangeDoubleAcquire(Dova.JDK.java.lang.Object arg0, long arg1, double arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[314], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JDD)D", "public final")]
	public double compareAndExchangeDoubleRelease(Dova.JDK.java.lang.Object arg0, long arg1, double arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[315], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JDD)Z", "public final")]
	public bool weakCompareAndSetDoublePlain(Dova.JDK.java.lang.Object arg0, long arg1, double arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[316], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JDD)Z", "public final")]
	public bool weakCompareAndSetDoubleAcquire(Dova.JDK.java.lang.Object arg0, long arg1, double arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[317], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JDD)Z", "public final")]
	public bool weakCompareAndSetDoubleRelease(Dova.JDK.java.lang.Object arg0, long arg1, double arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[318], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JDD)Z", "public final")]
	public bool weakCompareAndSetDouble(Dova.JDK.java.lang.Object arg0, long arg1, double arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[319], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([DI)I", "public")]
	public int getLoadAverage(JavaArray<double> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[320], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JI)I", "public final")]
	public int getAndAddIntRelease(Dova.JDK.java.lang.Object arg0, long arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[321], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JI)I", "public final")]
	public int getAndAddIntAcquire(Dova.JDK.java.lang.Object arg0, long arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[322], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJ)J", "public final")]
	public long getAndAddLongRelease(Dova.JDK.java.lang.Object arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[323], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJ)J", "public final")]
	public long getAndAddLongAcquire(Dova.JDK.java.lang.Object arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[324], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JB)B", "public final")]
	public byte getAndAddByteRelease(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[325], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JB)B", "public final")]
	public byte getAndAddByteAcquire(Dova.JDK.java.lang.Object arg0, long arg1, byte arg2)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[326], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JC)C", "public final")]
	public char getAndAddChar(Dova.JDK.java.lang.Object arg0, long arg1, char arg2)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[327], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JC)C", "public final")]
	public char getAndAddCharRelease(Dova.JDK.java.lang.Object arg0, long arg1, char arg2)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[328], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JC)C", "public final")]
	public char getAndAddCharAcquire(Dova.JDK.java.lang.Object arg0, long arg1, char arg2)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[329], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JF)F", "public final")]
	public float getAndAddFloat(Dova.JDK.java.lang.Object arg0, long arg1, float arg2)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[330], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JF)F", "public final")]
	public float getAndAddFloatRelease(Dova.JDK.java.lang.Object arg0, long arg1, float arg2)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[331], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JF)F", "public final")]
	public float getAndAddFloatAcquire(Dova.JDK.java.lang.Object arg0, long arg1, float arg2)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[332], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JD)D", "public final")]
	public double getAndAddDouble(Dova.JDK.java.lang.Object arg0, long arg1, double arg2)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[333], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JD)D", "public final")]
	public double getAndAddDoubleRelease(Dova.JDK.java.lang.Object arg0, long arg1, double arg2)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[334], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JD)D", "public final")]
	public double getAndAddDoubleAcquire(Dova.JDK.java.lang.Object arg0, long arg1, double arg2)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[335], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZ)Z", "public final")]
	public bool getAndSetBoolean(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[336], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZ)Z", "public final")]
	public bool getAndSetBooleanRelease(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[337], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZ)Z", "public final")]
	public bool getAndSetBooleanAcquire(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[338], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JC)C", "public final")]
	public char getAndSetChar(Dova.JDK.java.lang.Object arg0, long arg1, char arg2)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[339], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JC)C", "public final")]
	public char getAndSetCharRelease(Dova.JDK.java.lang.Object arg0, long arg1, char arg2)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[340], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JC)C", "public final")]
	public char getAndSetCharAcquire(Dova.JDK.java.lang.Object arg0, long arg1, char arg2)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[341], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JF)F", "public final")]
	public float getAndSetFloat(Dova.JDK.java.lang.Object arg0, long arg1, float arg2)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[342], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JF)F", "public final")]
	public float getAndSetFloatRelease(Dova.JDK.java.lang.Object arg0, long arg1, float arg2)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[343], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JF)F", "public final")]
	public float getAndSetFloatAcquire(Dova.JDK.java.lang.Object arg0, long arg1, float arg2)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[344], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JD)D", "public final")]
	public double getAndSetDouble(Dova.JDK.java.lang.Object arg0, long arg1, double arg2)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[345], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JD)D", "public final")]
	public double getAndSetDoubleRelease(Dova.JDK.java.lang.Object arg0, long arg1, double arg2)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[346], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JD)D", "public final")]
	public double getAndSetDoubleAcquire(Dova.JDK.java.lang.Object arg0, long arg1, double arg2)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[347], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZ)Z", "public final")]
	public bool getAndBitwiseOrBoolean(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[348], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZ)Z", "public final")]
	public bool getAndBitwiseOrBooleanRelease(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[349], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZ)Z", "public final")]
	public bool getAndBitwiseOrBooleanAcquire(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[350], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZ)Z", "public final")]
	public bool getAndBitwiseAndBoolean(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[351], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZ)Z", "public final")]
	public bool getAndBitwiseAndBooleanRelease(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[352], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZ)Z", "public final")]
	public bool getAndBitwiseAndBooleanAcquire(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[353], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZ)Z", "public final")]
	public bool getAndBitwiseXorBoolean(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[354], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZ)Z", "public final")]
	public bool getAndBitwiseXorBooleanRelease(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[355], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JZ)Z", "public final")]
	public bool getAndBitwiseXorBooleanAcquire(Dova.JDK.java.lang.Object arg0, long arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[356], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JC)C", "public final")]
	public char getAndBitwiseOrChar(Dova.JDK.java.lang.Object arg0, long arg1, char arg2)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[357], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JC)C", "public final")]
	public char getAndBitwiseOrCharRelease(Dova.JDK.java.lang.Object arg0, long arg1, char arg2)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[358], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JC)C", "public final")]
	public char getAndBitwiseOrCharAcquire(Dova.JDK.java.lang.Object arg0, long arg1, char arg2)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[359], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JC)C", "public final")]
	public char getAndBitwiseAndChar(Dova.JDK.java.lang.Object arg0, long arg1, char arg2)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[360], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JC)C", "public final")]
	public char getAndBitwiseAndCharRelease(Dova.JDK.java.lang.Object arg0, long arg1, char arg2)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[361], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JC)C", "public final")]
	public char getAndBitwiseAndCharAcquire(Dova.JDK.java.lang.Object arg0, long arg1, char arg2)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[362], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JC)C", "public final")]
	public char getAndBitwiseXorChar(Dova.JDK.java.lang.Object arg0, long arg1, char arg2)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[363], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JC)C", "public final")]
	public char getAndBitwiseXorCharRelease(Dova.JDK.java.lang.Object arg0, long arg1, char arg2)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[364], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JC)C", "public final")]
	public char getAndBitwiseXorCharAcquire(Dova.JDK.java.lang.Object arg0, long arg1, char arg2)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[365], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JI)I", "public final")]
	public int getAndBitwiseOrInt(Dova.JDK.java.lang.Object arg0, long arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[366], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JI)I", "public final")]
	public int getAndBitwiseOrIntRelease(Dova.JDK.java.lang.Object arg0, long arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[367], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JI)I", "public final")]
	public int getAndBitwiseOrIntAcquire(Dova.JDK.java.lang.Object arg0, long arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[368], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JI)I", "public final")]
	public int getAndBitwiseAndInt(Dova.JDK.java.lang.Object arg0, long arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[369], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JI)I", "public final")]
	public int getAndBitwiseAndIntRelease(Dova.JDK.java.lang.Object arg0, long arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[370], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JI)I", "public final")]
	public int getAndBitwiseAndIntAcquire(Dova.JDK.java.lang.Object arg0, long arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[371], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JI)I", "public final")]
	public int getAndBitwiseXorInt(Dova.JDK.java.lang.Object arg0, long arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[372], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JI)I", "public final")]
	public int getAndBitwiseXorIntRelease(Dova.JDK.java.lang.Object arg0, long arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[373], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JI)I", "public final")]
	public int getAndBitwiseXorIntAcquire(Dova.JDK.java.lang.Object arg0, long arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[374], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJ)J", "public final")]
	public long getAndBitwiseOrLong(Dova.JDK.java.lang.Object arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[375], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJ)J", "public final")]
	public long getAndBitwiseOrLongRelease(Dova.JDK.java.lang.Object arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[376], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJ)J", "public final")]
	public long getAndBitwiseOrLongAcquire(Dova.JDK.java.lang.Object arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[377], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJ)J", "public final")]
	public long getAndBitwiseAndLong(Dova.JDK.java.lang.Object arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[378], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJ)J", "public final")]
	public long getAndBitwiseAndLongRelease(Dova.JDK.java.lang.Object arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[379], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJ)J", "public final")]
	public long getAndBitwiseAndLongAcquire(Dova.JDK.java.lang.Object arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[380], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJ)J", "public final")]
	public long getAndBitwiseXorLong(Dova.JDK.java.lang.Object arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[381], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJ)J", "public final")]
	public long getAndBitwiseXorLongRelease(Dova.JDK.java.lang.Object arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[382], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJ)J", "public final")]
	public long getAndBitwiseXorLongAcquire(Dova.JDK.java.lang.Object arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[383], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()V", "private static")]
	public static void throwIllegalAccessError()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[384]);
	}

	[JniSignatureAttribute("()V", "private static")]
	public static void throwNoSuchMethodError()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[385]);
	}

	[JniSignatureAttribute("()Z", "public final")]
	public bool isBigEndian()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[386]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public final")]
	public bool unalignedAccess()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[387]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)V", "public")]
	public void invokeCleaner(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[388], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object getObject(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[389], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object getObjectVolatile(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[390], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object getObjectAcquire(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[391], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;J)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object getObjectOpaque(Dova.JDK.java.lang.Object arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[392], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;)V", "public final")]
	public void putObject(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[393], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;)V", "public final")]
	public void putObjectVolatile(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[394], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;)V", "public final")]
	public void putObjectOpaque(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[395], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;)V", "public final")]
	public void putObjectRelease(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[396], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object getAndSetObject(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[397], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object getAndSetObjectAcquire(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[398], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object getAndSetObjectRelease(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[399], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Z", "public final")]
	public bool compareAndSetObject(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[400], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object compareAndExchangeObject(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[401], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object compareAndExchangeObjectAcquire(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[402], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object compareAndExchangeObjectRelease(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[403], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Z", "public final")]
	public bool weakCompareAndSetObject(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[404], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Z", "public final")]
	public bool weakCompareAndSetObjectAcquire(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[405], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Z", "public final")]
	public bool weakCompareAndSetObjectPlain(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[406], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JLjava/lang/Object;Ljava/lang/Object;)Z", "public final")]
	public bool weakCompareAndSetObjectRelease(Dova.JDK.java.lang.Object arg0, long arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[407], arg0, arg1, arg2, arg3);
		return ret;
	}
}
