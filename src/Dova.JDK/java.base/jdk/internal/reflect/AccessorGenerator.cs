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

namespace Dova.JDK.jdk.@internal.reflect;

[JniSignatureAttribute("Ljdk/internal/reflect/AccessorGenerator;", "")]
public partial class AccessorGenerator
	: Dova.JDK.java.lang.Object
	, Dova.JDK.jdk.@internal.reflect.ClassFileConstants
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AccessorGenerator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/reflect/AccessorGenerator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "unsafe", "Ljdk/internal/misc/Unsafe;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "S0", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "S1", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "S2", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "S3", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "S4", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "S5", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "S6", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "asm", "Ljdk/internal/reflect/ClassFileAssembler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modifiers", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thisClass", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "superClass", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targetClass", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "throwableClass", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classCastClass", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nullPointerClass", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "illegalArgumentClass", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "invocationTargetClass", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "initIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "initNameAndTypeIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "initStringNameAndTypeIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nullPointerCtorIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "illegalArgumentCtorIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "illegalArgumentStringCtorIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "invocationTargetCtorIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "superCtorIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "objectClass", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "toStringIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "codeIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exceptionsIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "valueOfIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "booleanIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "booleanBoxIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "booleanUnboxIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "byteIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "byteBoxIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "byteUnboxIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "characterIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "characterBoxIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "characterUnboxIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "doubleIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "doubleBoxIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "doubleUnboxIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "floatIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "floatBoxIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "floatUnboxIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "integerIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "integerBoxIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "integerUnboxIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "longIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "longBoxIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "longUnboxIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "shortIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "shortBoxIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "shortUnboxIdx", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "NUM_COMMON_CPOOL_ENTRIES", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "NUM_BOXING_CPOOL_ENTRIES", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "primitiveTypes", "[Ljava/lang/Class;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "illegalArgumentCodeBuffer", "Ljdk/internal/reflect/ClassFileAssembler;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "add", "(SS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isPrimitive", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isStatic", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrivate", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getClassName", "(Ljava/lang/Class;Z)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "sub", "(SS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "emitMethod", "(SILjdk/internal/reflect/ClassFileAssembler;Ljdk/internal/reflect/ClassFileAssembler;[S)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "illegalArgumentCodeBuffer", "()Ljdk/internal/reflect/ClassFileAssembler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "emitCommonConstantPoolEntries", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "emitBoxingContantPoolEntries", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "emitConstructor", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "indexForPrimitiveType", "(Ljava/lang/Class;)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "boxingMethodForPrimitiveType", "(Ljava/lang/Class;)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "canWidenTo", "(Ljava/lang/Class;Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "emitWideningBytecodeForPrimitiveConversion", "(Ljdk/internal/reflect/ClassFileAssembler;Ljava/lang/Class;Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unboxingMethodForPrimitiveType", "(Ljava/lang/Class;)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeSizeInStackSlots", "(Ljava/lang/Class;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "internalize", "(Ljava/lang/String;)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Ljdk/internal/misc/Unsafe;", "static final")]
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

	[JniSignatureAttribute("S", "protected static final")]
	public static short S0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("S", "protected static final")]
	public static short S1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("S", "protected static final")]
	public static short S2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("S", "protected static final")]
	public static short S3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("S", "protected static final")]
	public static short S4_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("S", "protected static final")]
	public static short S5_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("S", "protected static final")]
	public static short S6_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/reflect/ClassFileAssembler;", "protected")]
	public Dova.JDK.jdk.@internal.reflect.ClassFileAssembler asm_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ClassFileAssembler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int modifiers_Property
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

	[JniSignatureAttribute("S", "protected")]
	public short thisClass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short superClass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short targetClass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short throwableClass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short classCastClass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short nullPointerClass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short illegalArgumentClass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short invocationTargetClass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short initIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short initNameAndTypeIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short initStringNameAndTypeIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short nullPointerCtorIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short illegalArgumentCtorIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short illegalArgumentStringCtorIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short invocationTargetCtorIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[24]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[24], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short superCtorIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[25]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[25], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short objectClass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[26]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[26], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short toStringIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[27]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[27], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short codeIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[28]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[28], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short exceptionsIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[29]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[29], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short valueOfIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[30]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[30], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short booleanIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[31]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[31], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short booleanBoxIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[32]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[32], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short booleanUnboxIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[33]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[33], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short byteIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[34]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[34], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short byteBoxIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[35]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[35], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short byteUnboxIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[36]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[36], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short characterIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[37]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[37], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short characterBoxIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[38]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[38], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short characterUnboxIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[39]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[39], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short doubleIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[40]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[40], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short doubleBoxIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[41]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[41], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short doubleUnboxIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[42]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[42], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short floatIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[43]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[43], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short floatBoxIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[44]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[44], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short floatUnboxIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[45]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[45], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short integerIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[46]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[46], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short integerBoxIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[47]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[47], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short integerUnboxIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[48]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[48], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short longIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[49]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[49], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short longBoxIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[50]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[50], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short longUnboxIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[51]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[51], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short shortIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[52]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[52], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short shortBoxIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[53]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[53], value);
		}
	}

	[JniSignatureAttribute("S", "protected")]
	public short shortUnboxIdx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[54]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[54], value);
		}
	}

	[JniSignatureAttribute("S", "protected final")]
	public short NUM_COMMON_CPOOL_ENTRIES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[55]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[55], value);
		}
	}

	[JniSignatureAttribute("S", "protected final")]
	public short NUM_BOXING_CPOOL_ENTRIES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[56]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[56], value);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/Class;", "protected static final")]
	public static JavaArray<Dova.JDK.java.lang.Class> primitiveTypes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[57]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[57], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/reflect/ClassFileAssembler;", "private")]
	public Dova.JDK.jdk.@internal.reflect.ClassFileAssembler illegalArgumentCodeBuffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[58]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ClassFileAssembler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[58], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AccessorGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public AccessorGenerator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/reflect/AccessorGenerator;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(SS)S", "protected static")]
	public static short add(short arg0, short arg1)
	{
		var ret = DovaVM.Runtime.CallStaticShortMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "protected static")]
	public static bool isPrimitive(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool isStatic()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool isPrivate()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Z)Ljava/lang/String;", "protected static")]
	public static Dova.JDK.java.lang.String getClassName(Dova.JDK.java.lang.Class arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(SS)S", "protected static")]
	public static short sub(short arg0, short arg1)
	{
		var ret = DovaVM.Runtime.CallStaticShortMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(SILjdk/internal/reflect/ClassFileAssembler;Ljdk/internal/reflect/ClassFileAssembler;[S)V", "protected")]
	public void emitMethod(short arg0, int arg1, Dova.JDK.jdk.@internal.reflect.ClassFileAssembler arg2, Dova.JDK.jdk.@internal.reflect.ClassFileAssembler arg3, JavaArray<short> arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("()Ljdk/internal/reflect/ClassFileAssembler;", "protected")]
	public Dova.JDK.jdk.@internal.reflect.ClassFileAssembler illegalArgumentCodeBuffer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ClassFileAssembler>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void emitCommonConstantPoolEntries()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void emitBoxingContantPoolEntries()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void emitConstructor()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)S", "protected")]
	public short indexForPrimitiveType(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)S", "protected")]
	public short boxingMethodForPrimitiveType(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;)Z", "protected static")]
	public static bool canWidenTo(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/reflect/ClassFileAssembler;Ljava/lang/Class;Ljava/lang/Class;)V", "protected static")]
	public static void emitWideningBytecodeForPrimitiveConversion(Dova.JDK.jdk.@internal.reflect.ClassFileAssembler arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.Class arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)S", "protected")]
	public short unboxingMethodForPrimitiveType(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)I", "protected")]
	public int typeSizeInStackSlots(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String internalize(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
