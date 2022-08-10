/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
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

[JniSignatureAttribute("Ljdk/internal/misc/ScopedMemoryAccess;", "public")]
public partial class ScopedMemoryAccess
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ScopedMemoryAccess()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/misc/ScopedMemoryAccess;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "UNSAFE", "Ljdk/internal/misc/Unsafe;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "theScopedMemoryAccess", "Ljdk/internal/misc/ScopedMemoryAccess;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ScopedMemoryAccess", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "vectorizedMismatch", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JLjava/lang/Object;JII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getByte", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putByte", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getShort", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putShort", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getChar", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putChar", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getInt", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putInt", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLong", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putLong", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFloat", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putFloat", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDouble", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putDouble", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getByteVolatile", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putByteVolatile", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getShortVolatile", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putShortVolatile", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCharVolatile", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putCharVolatile", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getIntVolatile", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putIntVolatile", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLongVolatile", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putLongVolatile", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFloatVolatile", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putFloatVolatile", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDoubleVolatile", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putDoubleVolatile", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getByteOpaque", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putByteOpaque", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getShortOpaque", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putShortOpaque", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCharOpaque", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putCharOpaque", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getIntOpaque", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putIntOpaque", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLongOpaque", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putLongOpaque", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFloatOpaque", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putFloatOpaque", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDoubleOpaque", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putDoubleOpaque", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getByteAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putByteRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getShortAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putShortRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCharAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putCharRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getIntAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putIntRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLongAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putLongRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFloatAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putFloatRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDoubleAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putDoubleRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getShortUnaligned", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JZ)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putShortUnaligned", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JSZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCharUnaligned", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JZ)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putCharUnaligned", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JCZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getIntUnaligned", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putIntUnaligned", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLongUnaligned", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JZ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putLongUnaligned", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndSetLong", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndExchangeLong", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndExchangeLongAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndExchangeLongRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndSetInt", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndExchangeInt", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndExchangeIntAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndExchangeIntRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetLongPlain", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetLongAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetLongRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetLong", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetIntPlain", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetIntAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetIntRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetInt", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddInt", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddLong", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddByte", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddShort", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndSetInt", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndSetLong", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "load", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;JZJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "registerNatives", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setMemory", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copyMemory", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JLjava/lang/Object;JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copySwapMemory", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JLjava/lang/Object;JJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddShortRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddShortAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndSetIntRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndSetIntAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndSetLongRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndSetLongAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrByte", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrByteRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrByteAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndByte", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndByteRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndByteAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorByte", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorByteRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorByteAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrShort", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrShortRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrShortAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndShort", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndShortRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndShortAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorShort", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorShortRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorShortAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndSetFloat", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndExchangeFloat", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndExchangeFloatAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndExchangeFloatRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetFloatPlain", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetFloatAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetFloatRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetFloat", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndSetDouble", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndExchangeDouble", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndExchangeDoubleAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndExchangeDoubleRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetDoublePlain", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetDoubleAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetDoubleRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetDouble", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddIntRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddIntAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddLongRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddLongAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddByteRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddByteAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddChar", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddCharRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddCharAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddFloat", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddFloatRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddFloatAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddDouble", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddDoubleRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddDoubleAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndSetFloat", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndSetFloatRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndSetFloatAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndSetDouble", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndSetDoubleRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndSetDoubleAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrChar", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrCharRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrCharAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndChar", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndCharRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndCharAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorChar", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorCharRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorCharAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrInt", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrIntRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrIntAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndInt", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndIntRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndIntAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorInt", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorIntRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorIntAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrLong", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrLongRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrLongAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndLong", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndLongRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndLongAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorLong", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorLongRelease", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorLongAcquire", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getScopedMemoryAccess", "()Ljdk/internal/misc/ScopedMemoryAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isReadOnly", "(Ljava/nio/ByteBuffer;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "closeScope0", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljdk/internal/misc/ScopedMemoryAccess$Scope$ScopedAccessError;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copyMemoryInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JLjava/lang/Object;JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copySwapMemoryInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JLjava/lang/Object;JJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setMemoryInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "vectorizedMismatchInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JLjava/lang/Object;JII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isLoadedInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;JZJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isLoaded", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;JZJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "loadInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;JZJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "unloadInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;JZJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "unload", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;JZJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "forceInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/io/FileDescriptor;JZJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "force", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/io/FileDescriptor;JZJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "loadFromByteBufferScoped", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Class;Ljava/lang/Class;ILjava/nio/ByteBuffer;ILjdk/internal/vm/vector/VectorSupport$VectorSpecies;Ljdk/internal/vm/vector/VectorSupport$LoadOperation;)Ljdk/internal/vm/vector/VectorSupport$Vector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "loadFromByteBufferMaskedScoped", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;ILjava/nio/ByteBuffer;ILjdk/internal/vm/vector/VectorSupport$VectorMask;Ljdk/internal/vm/vector/VectorSupport$VectorSpecies;Ljdk/internal/vm/vector/VectorSupport$LoadVectorMaskedOperation;)Ljdk/internal/vm/vector/VectorSupport$Vector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "storeIntoByteBufferScoped", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Class;Ljava/lang/Class;ILjdk/internal/vm/vector/VectorSupport$Vector;Ljava/nio/ByteBuffer;ILjdk/internal/vm/vector/VectorSupport$StoreVectorOperation;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "storeIntoByteBufferMaskedScoped", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;ILjdk/internal/vm/vector/VectorSupport$Vector;Ljdk/internal/vm/vector/VectorSupport$VectorMask;Ljava/nio/ByteBuffer;ILjdk/internal/vm/vector/VectorSupport$StoreVectorMaskedOperation;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getByteInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putByteInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getByteVolatileInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putByteVolatileInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getByteAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putByteReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getByteOpaqueInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putByteOpaqueInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddByteInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddByteAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddByteReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrByteInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrByteAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrByteReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndByteInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndByteAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndByteReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorByteInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorByteAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorByteReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getShortInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putShortInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getShortUnalignedInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JZ)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putShortUnalignedInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JSZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getShortVolatileInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putShortVolatileInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getShortAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putShortReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getShortOpaqueInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putShortOpaqueInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddShortInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddShortAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddShortReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrShortInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrShortAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrShortReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndShortInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndShortAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndShortReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorShortInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorShortAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorShortReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCharInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putCharInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCharUnalignedInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JZ)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putCharUnalignedInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JCZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCharVolatileInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putCharVolatileInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCharAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putCharReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCharOpaqueInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putCharOpaqueInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddCharInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddCharAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddCharReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrCharInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrCharAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrCharReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndCharInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndCharAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndCharReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorCharInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorCharAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorCharReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getIntInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putIntInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getIntUnalignedInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putIntUnalignedInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getIntVolatileInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putIntVolatileInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getIntAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putIntReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getIntOpaqueInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putIntOpaqueInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndSetIntInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndExchangeIntInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndExchangeIntAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndExchangeIntReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetIntPlainInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetIntInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetIntAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetIntReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndSetIntInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndSetIntAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndSetIntReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddIntInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddIntAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddIntReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrIntInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrIntAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrIntReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndIntInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndIntAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndIntReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorIntInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorIntAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorIntReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLongInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putLongInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLongUnalignedInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JZ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putLongUnalignedInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLongVolatileInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putLongVolatileInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLongAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putLongReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLongOpaqueInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putLongOpaqueInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndSetLongInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndExchangeLongInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndExchangeLongAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndExchangeLongReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetLongPlainInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetLongInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetLongAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetLongReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndSetLongInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndSetLongAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndSetLongReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddLongInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddLongAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddLongReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrLongInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrLongAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseOrLongReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndLongInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndLongAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseAndLongReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorLongInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorLongAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndBitwiseXorLongReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFloatInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putFloatInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFloatVolatileInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putFloatVolatileInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFloatAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putFloatReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFloatOpaqueInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putFloatOpaqueInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndSetFloatInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndExchangeFloatInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndExchangeFloatAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndExchangeFloatReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetFloatPlainInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetFloatInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetFloatAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetFloatReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndSetFloatInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndSetFloatAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndSetFloatReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddFloatInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddFloatAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddFloatReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDoubleInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putDoubleInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDoubleVolatileInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putDoubleVolatileInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDoubleAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putDoubleReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDoubleOpaqueInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putDoubleOpaqueInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndSetDoubleInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndExchangeDoubleInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndExchangeDoubleAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareAndExchangeDoubleReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetDoublePlainInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetDoubleInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetDoubleAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "weakCompareAndSetDoubleReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndSetDoubleInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndSetDoubleAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndSetDoubleReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddDoubleInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddDoubleAcquireInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAndAddDoubleReleaseInternal", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "closeScope", "(Ljdk/internal/misc/ScopedMemoryAccess$Scope;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "loadFromByteBuffer", "(Ljava/lang/Class;Ljava/lang/Class;ILjava/nio/ByteBuffer;ILjdk/internal/vm/vector/VectorSupport$VectorSpecies;Ljdk/internal/vm/vector/VectorSupport$LoadOperation;)Ljdk/internal/vm/vector/VectorSupport$Vector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "loadFromByteBufferMasked", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;ILjava/nio/ByteBuffer;ILjdk/internal/vm/vector/VectorSupport$VectorMask;Ljdk/internal/vm/vector/VectorSupport$VectorSpecies;Ljdk/internal/vm/vector/VectorSupport$LoadVectorMaskedOperation;)Ljdk/internal/vm/vector/VectorSupport$Vector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "storeIntoByteBuffer", "(Ljava/lang/Class;Ljava/lang/Class;ILjdk/internal/vm/vector/VectorSupport$Vector;Ljava/nio/ByteBuffer;ILjdk/internal/vm/vector/VectorSupport$StoreVectorOperation;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "storeIntoByteBufferMasked", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;ILjdk/internal/vm/vector/VectorSupport$Vector;Ljdk/internal/vm/vector/VectorSupport$VectorMask;Ljava/nio/ByteBuffer;ILjdk/internal/vm/vector/VectorSupport$StoreVectorMaskedOperation;)V"));
	}

	[JniSignatureAttribute("Ljdk/internal/misc/Unsafe;", "private static final")]
	public static Dova.JDK.jdk.@internal.misc.Unsafe UNSAFE_Property
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

	[JniSignatureAttribute("Ljdk/internal/misc/ScopedMemoryAccess;", "private static final")]
	public static Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess theScopedMemoryAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ScopedMemoryAccess(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public ScopedMemoryAccess() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/misc/ScopedMemoryAccess;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JLjava/lang/Object;JII)I", "public")]
	public int vectorizedMismatch(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg1, Dova.JDK.java.lang.Object arg2, long arg3, Dova.JDK.java.lang.Object arg4, long arg5, int arg6, int arg7)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)B", "public")]
	public byte getByte(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)V", "public")]
	public void putByte(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)S", "public")]
	public short getShort(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)V", "public")]
	public void putShort(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)C", "public")]
	public char getChar(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)V", "public")]
	public void putChar(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)I", "public")]
	public int getInt(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)V", "public")]
	public void putInt(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)J", "public")]
	public long getLong(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)V", "public")]
	public void putLong(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)F", "public")]
	public float getFloat(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)V", "public")]
	public void putFloat(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)D", "public")]
	public double getDouble(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)V", "public")]
	public void putDouble(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)B", "public")]
	public byte getByteVolatile(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)V", "public")]
	public void putByteVolatile(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)S", "public")]
	public short getShortVolatile(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)V", "public")]
	public void putShortVolatile(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)C", "public")]
	public char getCharVolatile(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)V", "public")]
	public void putCharVolatile(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)I", "public")]
	public int getIntVolatile(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)V", "public")]
	public void putIntVolatile(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)J", "public")]
	public long getLongVolatile(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)V", "public")]
	public void putLongVolatile(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)F", "public")]
	public float getFloatVolatile(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)V", "public")]
	public void putFloatVolatile(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)D", "public")]
	public double getDoubleVolatile(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)V", "public")]
	public void putDoubleVolatile(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)B", "public")]
	public byte getByteOpaque(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)V", "public")]
	public void putByteOpaque(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)S", "public")]
	public short getShortOpaque(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)V", "public")]
	public void putShortOpaque(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)C", "public")]
	public char getCharOpaque(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)V", "public")]
	public void putCharOpaque(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)I", "public")]
	public int getIntOpaque(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)V", "public")]
	public void putIntOpaque(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)J", "public")]
	public long getLongOpaque(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)V", "public")]
	public void putLongOpaque(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)F", "public")]
	public float getFloatOpaque(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)V", "public")]
	public void putFloatOpaque(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)D", "public")]
	public double getDoubleOpaque(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)V", "public")]
	public void putDoubleOpaque(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)B", "public")]
	public byte getByteAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)V", "public")]
	public void putByteRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)S", "public")]
	public short getShortAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)V", "public")]
	public void putShortRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)C", "public")]
	public char getCharAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)V", "public")]
	public void putCharRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)I", "public")]
	public int getIntAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)V", "public")]
	public void putIntRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)J", "public")]
	public long getLongAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)V", "public")]
	public void putLongRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)F", "public")]
	public float getFloatAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)V", "public")]
	public void putFloatRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)D", "public")]
	public double getDoubleAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)V", "public")]
	public void putDoubleRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JZ)S", "public")]
	public short getShortUnaligned(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[57], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JSZ)V", "public")]
	public void putShortUnaligned(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3, bool arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[58], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JZ)C", "public")]
	public char getCharUnaligned(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[59], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JCZ)V", "public")]
	public void putCharUnaligned(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3, bool arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[60], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JZ)I", "public")]
	public int getIntUnaligned(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[61], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JIZ)V", "public")]
	public void putIntUnaligned(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3, bool arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[62], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JZ)J", "public")]
	public long getLongUnaligned(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[63], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJZ)V", "public")]
	public void putLongUnaligned(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3, bool arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[64], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)Z", "public")]
	public bool compareAndSetLong(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3, long arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[65], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)J", "public")]
	public long compareAndExchangeLong(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3, long arg4)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[66], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)J", "public")]
	public long compareAndExchangeLongAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3, long arg4)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[67], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)J", "public")]
	public long compareAndExchangeLongRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3, long arg4)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[68], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)Z", "public")]
	public bool compareAndSetInt(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[69], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)I", "public")]
	public int compareAndExchangeInt(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[70], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)I", "public")]
	public int compareAndExchangeIntAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[71], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)I", "public")]
	public int compareAndExchangeIntRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[72], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)Z", "public")]
	public bool weakCompareAndSetLongPlain(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3, long arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[73], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)Z", "public")]
	public bool weakCompareAndSetLongAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3, long arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[74], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)Z", "public")]
	public bool weakCompareAndSetLongRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3, long arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[75], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)Z", "public")]
	public bool weakCompareAndSetLong(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3, long arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[76], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)Z", "public")]
	public bool weakCompareAndSetIntPlain(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[77], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)Z", "public")]
	public bool weakCompareAndSetIntAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[78], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)Z", "public")]
	public bool weakCompareAndSetIntRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[79], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)Z", "public")]
	public bool weakCompareAndSetInt(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[80], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "public")]
	public int getAndAddInt(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[81], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "public")]
	public long getAndAddLong(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[82], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B", "public")]
	public byte getAndAddByte(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[83], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S", "public")]
	public short getAndAddShort(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[84], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "public")]
	public int getAndSetInt(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[85], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "public")]
	public long getAndSetLong(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[86], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;JZJ)V", "public")]
	public void load(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, long arg1, bool arg2, long arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[87], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()V", "private static native")]
	public static void registerNatives()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[88]);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJB)V", "public")]
	public void setMemory(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3, byte arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[89], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JLjava/lang/Object;JJ)V", "public")]
	public void copyMemory(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg1, Dova.JDK.java.lang.Object arg2, long arg3, Dova.JDK.java.lang.Object arg4, long arg5, long arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[90], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JLjava/lang/Object;JJJ)V", "public")]
	public void copySwapMemory(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg1, Dova.JDK.java.lang.Object arg2, long arg3, Dova.JDK.java.lang.Object arg4, long arg5, long arg6, long arg7)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[91], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S", "public")]
	public short getAndAddShortRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[92], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S", "public")]
	public short getAndAddShortAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[93], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "public")]
	public int getAndSetIntRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[94], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "public")]
	public int getAndSetIntAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[95], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "public")]
	public long getAndSetLongRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[96], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "public")]
	public long getAndSetLongAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[97], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B", "public")]
	public byte getAndBitwiseOrByte(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[98], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B", "public")]
	public byte getAndBitwiseOrByteRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[99], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B", "public")]
	public byte getAndBitwiseOrByteAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[100], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B", "public")]
	public byte getAndBitwiseAndByte(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[101], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B", "public")]
	public byte getAndBitwiseAndByteRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[102], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B", "public")]
	public byte getAndBitwiseAndByteAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[103], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B", "public")]
	public byte getAndBitwiseXorByte(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[104], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B", "public")]
	public byte getAndBitwiseXorByteRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[105], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B", "public")]
	public byte getAndBitwiseXorByteAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[106], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S", "public")]
	public short getAndBitwiseOrShort(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[107], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S", "public")]
	public short getAndBitwiseOrShortRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[108], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S", "public")]
	public short getAndBitwiseOrShortAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[109], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S", "public")]
	public short getAndBitwiseAndShort(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[110], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S", "public")]
	public short getAndBitwiseAndShortRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[111], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S", "public")]
	public short getAndBitwiseAndShortAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[112], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S", "public")]
	public short getAndBitwiseXorShort(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[113], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S", "public")]
	public short getAndBitwiseXorShortRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[114], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S", "public")]
	public short getAndBitwiseXorShortAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[115], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)Z", "public")]
	public bool compareAndSetFloat(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3, float arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[116], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)F", "public")]
	public float compareAndExchangeFloat(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3, float arg4)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[117], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)F", "public")]
	public float compareAndExchangeFloatAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3, float arg4)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[118], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)F", "public")]
	public float compareAndExchangeFloatRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3, float arg4)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[119], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)Z", "public")]
	public bool weakCompareAndSetFloatPlain(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3, float arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[120], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)Z", "public")]
	public bool weakCompareAndSetFloatAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3, float arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[121], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)Z", "public")]
	public bool weakCompareAndSetFloatRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3, float arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[122], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)Z", "public")]
	public bool weakCompareAndSetFloat(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3, float arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[123], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)Z", "public")]
	public bool compareAndSetDouble(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3, double arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[124], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)D", "public")]
	public double compareAndExchangeDouble(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3, double arg4)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[125], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)D", "public")]
	public double compareAndExchangeDoubleAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3, double arg4)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[126], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)D", "public")]
	public double compareAndExchangeDoubleRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3, double arg4)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[127], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)Z", "public")]
	public bool weakCompareAndSetDoublePlain(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3, double arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[128], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)Z", "public")]
	public bool weakCompareAndSetDoubleAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3, double arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[129], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)Z", "public")]
	public bool weakCompareAndSetDoubleRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3, double arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[130], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)Z", "public")]
	public bool weakCompareAndSetDouble(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3, double arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[131], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "public")]
	public int getAndAddIntRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[132], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "public")]
	public int getAndAddIntAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[133], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "public")]
	public long getAndAddLongRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[134], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "public")]
	public long getAndAddLongAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[135], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B", "public")]
	public byte getAndAddByteRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[136], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B", "public")]
	public byte getAndAddByteAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[137], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C", "public")]
	public char getAndAddChar(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[138], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C", "public")]
	public char getAndAddCharRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[139], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C", "public")]
	public char getAndAddCharAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[140], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)F", "public")]
	public float getAndAddFloat(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[141], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)F", "public")]
	public float getAndAddFloatRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[142], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)F", "public")]
	public float getAndAddFloatAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[143], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)D", "public")]
	public double getAndAddDouble(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[144], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)D", "public")]
	public double getAndAddDoubleRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[145], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)D", "public")]
	public double getAndAddDoubleAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[146], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)F", "public")]
	public float getAndSetFloat(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[147], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)F", "public")]
	public float getAndSetFloatRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[148], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)F", "public")]
	public float getAndSetFloatAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[149], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)D", "public")]
	public double getAndSetDouble(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[150], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)D", "public")]
	public double getAndSetDoubleRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[151], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)D", "public")]
	public double getAndSetDoubleAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[152], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C", "public")]
	public char getAndBitwiseOrChar(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[153], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C", "public")]
	public char getAndBitwiseOrCharRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[154], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C", "public")]
	public char getAndBitwiseOrCharAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[155], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C", "public")]
	public char getAndBitwiseAndChar(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[156], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C", "public")]
	public char getAndBitwiseAndCharRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[157], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C", "public")]
	public char getAndBitwiseAndCharAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[158], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C", "public")]
	public char getAndBitwiseXorChar(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[159], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C", "public")]
	public char getAndBitwiseXorCharRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[160], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C", "public")]
	public char getAndBitwiseXorCharAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[161], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "public")]
	public int getAndBitwiseOrInt(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[162], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "public")]
	public int getAndBitwiseOrIntRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[163], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "public")]
	public int getAndBitwiseOrIntAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[164], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "public")]
	public int getAndBitwiseAndInt(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[165], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "public")]
	public int getAndBitwiseAndIntRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[166], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "public")]
	public int getAndBitwiseAndIntAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[167], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "public")]
	public int getAndBitwiseXorInt(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[168], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "public")]
	public int getAndBitwiseXorIntRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[169], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "public")]
	public int getAndBitwiseXorIntAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[170], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "public")]
	public long getAndBitwiseOrLong(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[171], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "public")]
	public long getAndBitwiseOrLongRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[172], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "public")]
	public long getAndBitwiseOrLongAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[173], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "public")]
	public long getAndBitwiseAndLong(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[174], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "public")]
	public long getAndBitwiseAndLongRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[175], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "public")]
	public long getAndBitwiseAndLongAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[176], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "public")]
	public long getAndBitwiseXorLong(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[177], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "public")]
	public long getAndBitwiseXorLongRelease(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[178], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "public")]
	public long getAndBitwiseXorLongAcquire(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[179], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/internal/misc/ScopedMemoryAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess getScopedMemoryAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[180]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Z", "public static")]
	public static bool isReadOnly(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[181], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljdk/internal/misc/ScopedMemoryAccess$Scope$ScopedAccessError;)Z", "native")]
	public bool closeScope0(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope.ScopedAccessError arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[182], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JLjava/lang/Object;JJ)V", "private")]
	public void copyMemoryInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg1, Dova.JDK.java.lang.Object arg2, long arg3, Dova.JDK.java.lang.Object arg4, long arg5, long arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[183], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JLjava/lang/Object;JJJ)V", "private")]
	public void copySwapMemoryInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg1, Dova.JDK.java.lang.Object arg2, long arg3, Dova.JDK.java.lang.Object arg4, long arg5, long arg6, long arg7)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[184], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJB)V", "private")]
	public void setMemoryInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3, byte arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[185], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JLjava/lang/Object;JII)I", "private")]
	public int vectorizedMismatchInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg1, Dova.JDK.java.lang.Object arg2, long arg3, Dova.JDK.java.lang.Object arg4, long arg5, int arg6, int arg7)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[186], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;JZJ)Z", "public")]
	public bool isLoadedInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, long arg1, bool arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[187], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;JZJ)Z", "public")]
	public bool isLoaded(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, long arg1, bool arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[188], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;JZJ)V", "public")]
	public void loadInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, long arg1, bool arg2, long arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[189], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;JZJ)V", "public")]
	public void unloadInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, long arg1, bool arg2, long arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[190], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;JZJ)V", "public")]
	public void unload(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, long arg1, bool arg2, long arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[191], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/io/FileDescriptor;JZJJ)V", "public")]
	public void forceInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.io.FileDescriptor arg1, long arg2, bool arg3, long arg4, long arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[192], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/io/FileDescriptor;JZJJ)V", "public")]
	public void force(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.io.FileDescriptor arg1, long arg2, bool arg3, long arg4, long arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[193], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Class;Ljava/lang/Class;ILjava/nio/ByteBuffer;ILjdk/internal/vm/vector/VectorSupport$VectorSpecies;Ljdk/internal/vm/vector/VectorSupport$LoadOperation;)Ljdk/internal/vm/vector/VectorSupport$Vector;", "private static")]
	public static Dova.JDK.java.lang.Object loadFromByteBufferScoped(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.Class arg2, int arg3, Dova.JDK.java.nio.ByteBuffer arg4, int arg5, Dova.JDK.java.lang.Object arg6, Dova.JDK.jdk.@internal.vm.vector.VectorSupport.LoadOperation arg7)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[194], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;ILjava/nio/ByteBuffer;ILjdk/internal/vm/vector/VectorSupport$VectorMask;Ljdk/internal/vm/vector/VectorSupport$VectorSpecies;Ljdk/internal/vm/vector/VectorSupport$LoadVectorMaskedOperation;)Ljdk/internal/vm/vector/VectorSupport$Vector;", "private static")]
	public static Dova.JDK.java.lang.Object loadFromByteBufferMaskedScoped(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.Class arg2, Dova.JDK.java.lang.Class arg3, int arg4, Dova.JDK.java.nio.ByteBuffer arg5, int arg6, Dova.JDK.java.lang.Object arg7, Dova.JDK.java.lang.Object arg8, Dova.JDK.jdk.@internal.vm.vector.VectorSupport.LoadVectorMaskedOperation arg9)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[195], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Class;Ljava/lang/Class;ILjdk/internal/vm/vector/VectorSupport$Vector;Ljava/nio/ByteBuffer;ILjdk/internal/vm/vector/VectorSupport$StoreVectorOperation;)V", "private static")]
	public static void storeIntoByteBufferScoped(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.Class arg2, int arg3, Dova.JDK.java.lang.Object arg4, Dova.JDK.java.nio.ByteBuffer arg5, int arg6, Dova.JDK.jdk.@internal.vm.vector.VectorSupport.StoreVectorOperation arg7)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[196], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;ILjdk/internal/vm/vector/VectorSupport$Vector;Ljdk/internal/vm/vector/VectorSupport$VectorMask;Ljava/nio/ByteBuffer;ILjdk/internal/vm/vector/VectorSupport$StoreVectorMaskedOperation;)V", "private static")]
	public static void storeIntoByteBufferMaskedScoped(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.Class arg2, Dova.JDK.java.lang.Class arg3, int arg4, Dova.JDK.java.lang.Object arg5, Dova.JDK.java.lang.Object arg6, Dova.JDK.java.nio.ByteBuffer arg7, int arg8, Dova.JDK.jdk.@internal.vm.vector.VectorSupport.StoreVectorMaskedOperation arg9)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[197], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)B", "private")]
	public byte getByteInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[198], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)V", "private")]
	public void putByteInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[199], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)B", "private")]
	public byte getByteVolatileInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[200], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)V", "private")]
	public void putByteVolatileInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[201], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)B", "private")]
	public byte getByteAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[202], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)V", "private")]
	public void putByteReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[203], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)B", "private")]
	public byte getByteOpaqueInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[204], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)V", "private")]
	public void putByteOpaqueInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[205], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B", "private")]
	public byte getAndAddByteInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[206], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B", "private")]
	public byte getAndAddByteAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[207], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B", "private")]
	public byte getAndAddByteReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[208], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B", "private")]
	public byte getAndBitwiseOrByteInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[209], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B", "private")]
	public byte getAndBitwiseOrByteAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[210], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B", "private")]
	public byte getAndBitwiseOrByteReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[211], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B", "private")]
	public byte getAndBitwiseAndByteInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[212], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B", "private")]
	public byte getAndBitwiseAndByteAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[213], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B", "private")]
	public byte getAndBitwiseAndByteReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[214], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B", "private")]
	public byte getAndBitwiseXorByteInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[215], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B", "private")]
	public byte getAndBitwiseXorByteAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[216], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JB)B", "private")]
	public byte getAndBitwiseXorByteReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[217], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)S", "private")]
	public short getShortInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[218], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)V", "private")]
	public void putShortInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[219], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JZ)S", "private")]
	public short getShortUnalignedInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[220], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JSZ)V", "private")]
	public void putShortUnalignedInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3, bool arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[221], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)S", "private")]
	public short getShortVolatileInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[222], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)V", "private")]
	public void putShortVolatileInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[223], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)S", "private")]
	public short getShortAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[224], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)V", "private")]
	public void putShortReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[225], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)S", "private")]
	public short getShortOpaqueInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[226], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)V", "private")]
	public void putShortOpaqueInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[227], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S", "private")]
	public short getAndAddShortInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[228], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S", "private")]
	public short getAndAddShortAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[229], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S", "private")]
	public short getAndAddShortReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[230], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S", "private")]
	public short getAndBitwiseOrShortInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[231], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S", "private")]
	public short getAndBitwiseOrShortAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[232], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S", "private")]
	public short getAndBitwiseOrShortReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[233], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S", "private")]
	public short getAndBitwiseAndShortInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[234], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S", "private")]
	public short getAndBitwiseAndShortAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[235], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S", "private")]
	public short getAndBitwiseAndShortReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[236], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S", "private")]
	public short getAndBitwiseXorShortInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[237], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S", "private")]
	public short getAndBitwiseXorShortAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[238], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JS)S", "private")]
	public short getAndBitwiseXorShortReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[239], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)C", "private")]
	public char getCharInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[240], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)V", "private")]
	public void putCharInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[241], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JZ)C", "private")]
	public char getCharUnalignedInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[242], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JCZ)V", "private")]
	public void putCharUnalignedInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3, bool arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[243], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)C", "private")]
	public char getCharVolatileInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[244], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)V", "private")]
	public void putCharVolatileInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[245], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)C", "private")]
	public char getCharAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[246], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)V", "private")]
	public void putCharReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[247], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)C", "private")]
	public char getCharOpaqueInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[248], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)V", "private")]
	public void putCharOpaqueInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[249], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C", "private")]
	public char getAndAddCharInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[250], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C", "private")]
	public char getAndAddCharAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[251], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C", "private")]
	public char getAndAddCharReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[252], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C", "private")]
	public char getAndBitwiseOrCharInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[253], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C", "private")]
	public char getAndBitwiseOrCharAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[254], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C", "private")]
	public char getAndBitwiseOrCharReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[255], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C", "private")]
	public char getAndBitwiseAndCharInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[256], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C", "private")]
	public char getAndBitwiseAndCharAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[257], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C", "private")]
	public char getAndBitwiseAndCharReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[258], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C", "private")]
	public char getAndBitwiseXorCharInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[259], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C", "private")]
	public char getAndBitwiseXorCharAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[260], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JC)C", "private")]
	public char getAndBitwiseXorCharReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[261], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)I", "private")]
	public int getIntInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[262], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)V", "private")]
	public void putIntInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[263], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JZ)I", "private")]
	public int getIntUnalignedInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[264], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JIZ)V", "private")]
	public void putIntUnalignedInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3, bool arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[265], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)I", "private")]
	public int getIntVolatileInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[266], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)V", "private")]
	public void putIntVolatileInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[267], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)I", "private")]
	public int getIntAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[268], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)V", "private")]
	public void putIntReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[269], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)I", "private")]
	public int getIntOpaqueInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[270], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)V", "private")]
	public void putIntOpaqueInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[271], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)Z", "private")]
	public bool compareAndSetIntInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[272], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)I", "private")]
	public int compareAndExchangeIntInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[273], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)I", "private")]
	public int compareAndExchangeIntAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[274], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)I", "private")]
	public int compareAndExchangeIntReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[275], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)Z", "private")]
	public bool weakCompareAndSetIntPlainInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[276], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)Z", "private")]
	public bool weakCompareAndSetIntInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[277], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)Z", "private")]
	public bool weakCompareAndSetIntAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[278], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JII)Z", "private")]
	public bool weakCompareAndSetIntReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[279], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "private")]
	public int getAndSetIntInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[280], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "private")]
	public int getAndSetIntAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[281], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "private")]
	public int getAndSetIntReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[282], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "private")]
	public int getAndAddIntInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[283], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "private")]
	public int getAndAddIntAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[284], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "private")]
	public int getAndAddIntReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[285], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "private")]
	public int getAndBitwiseOrIntInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[286], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "private")]
	public int getAndBitwiseOrIntAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[287], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "private")]
	public int getAndBitwiseOrIntReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[288], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "private")]
	public int getAndBitwiseAndIntInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[289], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "private")]
	public int getAndBitwiseAndIntAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[290], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "private")]
	public int getAndBitwiseAndIntReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[291], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "private")]
	public int getAndBitwiseXorIntInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[292], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "private")]
	public int getAndBitwiseXorIntAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[293], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JI)I", "private")]
	public int getAndBitwiseXorIntReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[294], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)J", "private")]
	public long getLongInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[295], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)V", "private")]
	public void putLongInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[296], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JZ)J", "private")]
	public long getLongUnalignedInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[297], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJZ)V", "private")]
	public void putLongUnalignedInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3, bool arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[298], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)J", "private")]
	public long getLongVolatileInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[299], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)V", "private")]
	public void putLongVolatileInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[300], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)J", "private")]
	public long getLongAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[301], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)V", "private")]
	public void putLongReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[302], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)J", "private")]
	public long getLongOpaqueInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[303], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)V", "private")]
	public void putLongOpaqueInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[304], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)Z", "private")]
	public bool compareAndSetLongInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3, long arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[305], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)J", "private")]
	public long compareAndExchangeLongInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3, long arg4)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[306], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)J", "private")]
	public long compareAndExchangeLongAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3, long arg4)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[307], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)J", "private")]
	public long compareAndExchangeLongReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3, long arg4)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[308], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)Z", "private")]
	public bool weakCompareAndSetLongPlainInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3, long arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[309], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)Z", "private")]
	public bool weakCompareAndSetLongInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3, long arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[310], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)Z", "private")]
	public bool weakCompareAndSetLongAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3, long arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[311], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJJ)Z", "private")]
	public bool weakCompareAndSetLongReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3, long arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[312], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "private")]
	public long getAndSetLongInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[313], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "private")]
	public long getAndSetLongAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[314], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "private")]
	public long getAndSetLongReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[315], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "private")]
	public long getAndAddLongInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[316], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "private")]
	public long getAndAddLongAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[317], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "private")]
	public long getAndAddLongReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[318], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "private")]
	public long getAndBitwiseOrLongInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[319], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "private")]
	public long getAndBitwiseOrLongAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[320], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "private")]
	public long getAndBitwiseOrLongReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[321], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "private")]
	public long getAndBitwiseAndLongInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[322], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "private")]
	public long getAndBitwiseAndLongAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[323], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "private")]
	public long getAndBitwiseAndLongReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[324], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "private")]
	public long getAndBitwiseXorLongInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[325], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "private")]
	public long getAndBitwiseXorLongAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[326], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JJ)J", "private")]
	public long getAndBitwiseXorLongReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[327], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)F", "private")]
	public float getFloatInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[328], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)V", "private")]
	public void putFloatInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[329], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)F", "private")]
	public float getFloatVolatileInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[330], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)V", "private")]
	public void putFloatVolatileInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[331], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)F", "private")]
	public float getFloatAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[332], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)V", "private")]
	public void putFloatReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[333], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)F", "private")]
	public float getFloatOpaqueInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[334], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)V", "private")]
	public void putFloatOpaqueInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[335], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)Z", "private")]
	public bool compareAndSetFloatInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3, float arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[336], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)F", "private")]
	public float compareAndExchangeFloatInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3, float arg4)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[337], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)F", "private")]
	public float compareAndExchangeFloatAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3, float arg4)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[338], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)F", "private")]
	public float compareAndExchangeFloatReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3, float arg4)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[339], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)Z", "private")]
	public bool weakCompareAndSetFloatPlainInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3, float arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[340], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)Z", "private")]
	public bool weakCompareAndSetFloatInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3, float arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[341], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)Z", "private")]
	public bool weakCompareAndSetFloatAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3, float arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[342], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JFF)Z", "private")]
	public bool weakCompareAndSetFloatReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3, float arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[343], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)F", "private")]
	public float getAndSetFloatInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[344], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)F", "private")]
	public float getAndSetFloatAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[345], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)F", "private")]
	public float getAndSetFloatReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[346], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)F", "private")]
	public float getAndAddFloatInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[347], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)F", "private")]
	public float getAndAddFloatAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[348], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JF)F", "private")]
	public float getAndAddFloatReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[349], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)D", "private")]
	public double getDoubleInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[350], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)V", "private")]
	public void putDoubleInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[351], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)D", "private")]
	public double getDoubleVolatileInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[352], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)V", "private")]
	public void putDoubleVolatileInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[353], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)D", "private")]
	public double getDoubleAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[354], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)V", "private")]
	public void putDoubleReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[355], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;J)D", "private")]
	public double getDoubleOpaqueInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[356], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)V", "private")]
	public void putDoubleOpaqueInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[357], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)Z", "private")]
	public bool compareAndSetDoubleInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3, double arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[358], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)D", "private")]
	public double compareAndExchangeDoubleInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3, double arg4)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[359], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)D", "private")]
	public double compareAndExchangeDoubleAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3, double arg4)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[360], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)D", "private")]
	public double compareAndExchangeDoubleReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3, double arg4)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[361], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)Z", "private")]
	public bool weakCompareAndSetDoublePlainInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3, double arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[362], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)Z", "private")]
	public bool weakCompareAndSetDoubleInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3, double arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[363], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)Z", "private")]
	public bool weakCompareAndSetDoubleAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3, double arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[364], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JDD)Z", "private")]
	public bool weakCompareAndSetDoubleReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3, double arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[365], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)D", "private")]
	public double getAndSetDoubleInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[366], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)D", "private")]
	public double getAndSetDoubleAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[367], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)D", "private")]
	public double getAndSetDoubleReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[368], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)D", "private")]
	public double getAndAddDoubleInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[369], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)D", "private")]
	public double getAndAddDoubleAcquireInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[370], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;Ljava/lang/Object;JD)D", "private")]
	public double getAndAddDoubleReleaseInternal(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0, Dova.JDK.java.lang.Object arg1, long arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[371], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/misc/ScopedMemoryAccess$Scope;)Z", "public")]
	public bool closeScope(Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[372], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;ILjava/nio/ByteBuffer;ILjdk/internal/vm/vector/VectorSupport$VectorSpecies;Ljdk/internal/vm/vector/VectorSupport$LoadOperation;)Ljdk/internal/vm/vector/VectorSupport$Vector;", "public static")]
	public static Dova.JDK.java.lang.Object loadFromByteBuffer(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1, int arg2, Dova.JDK.java.nio.ByteBuffer arg3, int arg4, Dova.JDK.java.lang.Object arg5, Dova.JDK.jdk.@internal.vm.vector.VectorSupport.LoadOperation arg6)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[373], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;ILjava/nio/ByteBuffer;ILjdk/internal/vm/vector/VectorSupport$VectorMask;Ljdk/internal/vm/vector/VectorSupport$VectorSpecies;Ljdk/internal/vm/vector/VectorSupport$LoadVectorMaskedOperation;)Ljdk/internal/vm/vector/VectorSupport$Vector;", "public static")]
	public static Dova.JDK.java.lang.Object loadFromByteBufferMasked(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.Class arg2, int arg3, Dova.JDK.java.nio.ByteBuffer arg4, int arg5, Dova.JDK.java.lang.Object arg6, Dova.JDK.java.lang.Object arg7, Dova.JDK.jdk.@internal.vm.vector.VectorSupport.LoadVectorMaskedOperation arg8)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[374], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;ILjdk/internal/vm/vector/VectorSupport$Vector;Ljava/nio/ByteBuffer;ILjdk/internal/vm/vector/VectorSupport$StoreVectorOperation;)V", "public static")]
	public static void storeIntoByteBuffer(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1, int arg2, Dova.JDK.java.lang.Object arg3, Dova.JDK.java.nio.ByteBuffer arg4, int arg5, Dova.JDK.jdk.@internal.vm.vector.VectorSupport.StoreVectorOperation arg6)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[375], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;ILjdk/internal/vm/vector/VectorSupport$Vector;Ljdk/internal/vm/vector/VectorSupport$VectorMask;Ljava/nio/ByteBuffer;ILjdk/internal/vm/vector/VectorSupport$StoreVectorMaskedOperation;)V", "public static")]
	public static void storeIntoByteBufferMasked(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.Class arg2, int arg3, Dova.JDK.java.lang.Object arg4, Dova.JDK.java.lang.Object arg5, Dova.JDK.java.nio.ByteBuffer arg6, int arg7, Dova.JDK.jdk.@internal.vm.vector.VectorSupport.StoreVectorMaskedOperation arg8)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[376], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
	}

	[JniSignatureAttribute("Ljdk/internal/misc/ScopedMemoryAccess$Scope;", "public abstract static interface")]
	public partial interface Scope
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Scope()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/misc/ScopedMemoryAccess$Scope;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "checkValidState", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ownerThread", "()Ljava/lang/Thread;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "acquire0", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "release0", "()V"));
		}

		[JniSignatureAttribute("()V", "public abstract")]
		void checkValidState()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()Ljava/lang/Thread;", "public abstract")]
		Dova.JDK.java.lang.Thread ownerThread()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Thread>(ret);
		}

		[JniSignatureAttribute("()V", "public abstract")]
		void acquire0()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}

		[JniSignatureAttribute("()V", "public abstract")]
		void release0()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("Ljdk/internal/misc/ScopedMemoryAccess$Scope$ScopedAccessError;", "public static final")]
		public partial class ScopedAccessError
			: Dova.JDK.java.lang.Error
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ScopedAccessError()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/misc/ScopedMemoryAccess$Scope$ScopedAccessError;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INSTANCE", "Ljdk/internal/misc/ScopedMemoryAccess$Scope$ScopedAccessError;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ScopedAccessError", "()V"));
			}

			[JniSignatureAttribute("J", "static final")]
			public static long serialVersionUID_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
				}
			}

			[JniSignatureAttribute("Ljdk/internal/misc/ScopedMemoryAccess$Scope$ScopedAccessError;", "public static final")]
			public static Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope.ScopedAccessError INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope.ScopedAccessError>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ScopedAccessError(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "private")]
			public ScopedAccessError() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/internal/misc/ScopedMemoryAccess$Scope$ScopedAccessError;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
		}
	}

	[JniSignatureAttribute("Ljdk/internal/misc/ScopedMemoryAccess$BufferAccess;", "static final")]
	public partial class BufferAccess
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BufferAccess()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/misc/ScopedMemoryAccess$BufferAccess;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BUFFER_ADDRESS", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BYTE_BUFFER_HB", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BYTE_BUFFER_IS_READ_ONLY", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NIO_ACCESS", "Ljdk/internal/access/JavaNioAccess;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BufferAccess", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "scope", "(Ljava/nio/ByteBuffer;)Ljdk/internal/misc/ScopedMemoryAccess$Scope;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "bufferBase", "(Ljava/nio/ByteBuffer;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "bufferAddress", "(Ljava/nio/ByteBuffer;J)J"));
		}

		[JniSignatureAttribute("J", "static final")]
		public static long BUFFER_ADDRESS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("J", "static final")]
		public static long BYTE_BUFFER_HB_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("J", "static final")]
		public static long BYTE_BUFFER_IS_READ_ONLY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/access/JavaNioAccess;", "static final")]
		public static Dova.JDK.jdk.@internal.access.JavaNioAccess NIO_ACCESS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaNioAccess>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BufferAccess(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public BufferAccess() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/misc/ScopedMemoryAccess$BufferAccess;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Ljdk/internal/misc/ScopedMemoryAccess$Scope;", "static")]
		public static Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope scope(Dova.JDK.java.nio.ByteBuffer arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess.Scope>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Ljava/lang/Object;", "static")]
		public static Dova.JDK.java.lang.Object bufferBase(Dova.JDK.java.nio.ByteBuffer arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/ByteBuffer;J)J", "static")]
		public static long bufferAddress(Dova.JDK.java.nio.ByteBuffer arg0, long arg1)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljdk/internal/misc/ScopedMemoryAccess$Scoped;", "abstract static interface")]
	public partial interface Scoped
		: IJavaObject
		, Dova.JDK.java.lang.annotation.Annotation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }


		static Scoped()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/misc/ScopedMemoryAccess$Scoped;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		}
	}
}
