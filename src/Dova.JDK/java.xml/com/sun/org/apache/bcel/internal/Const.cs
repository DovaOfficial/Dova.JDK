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

namespace Dova.JDK.com.sun.org.apache.bcel.@internal;

[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/Const;", "public final")]
public partial class Const
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Const()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/bcel/internal/Const;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JVM_CLASSFILE_MAGIC", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAJOR_1_1", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MINOR_1_1", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAJOR_1_2", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MINOR_1_2", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAJOR_1_3", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MINOR_1_3", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAJOR_1_4", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MINOR_1_4", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAJOR_1_5", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MINOR_1_5", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAJOR_1_6", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MINOR_1_6", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAJOR_1_7", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MINOR_1_7", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAJOR_1_8", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MINOR_1_8", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAJOR_9", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MINOR_9", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAJOR_1_9", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MINOR_1_9", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAJOR_10", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MINOR_10", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAJOR_11", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MINOR_11", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAJOR_12", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MINOR_12", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAJOR_13", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MINOR_13", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAJOR_14", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MINOR_14", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAJOR", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MINOR", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_SHORT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_BYTE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACC_PUBLIC", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACC_PRIVATE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACC_PROTECTED", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACC_STATIC", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACC_FINAL", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACC_OPEN", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACC_SUPER", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACC_SYNCHRONIZED", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACC_TRANSITIVE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACC_BRIDGE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACC_STATIC_PHASE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACC_VOLATILE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACC_TRANSIENT", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACC_VARARGS", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACC_NATIVE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACC_INTERFACE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACC_ABSTRACT", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACC_STRICT", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACC_SYNTHETIC", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACC_ANNOTATION", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACC_ENUM", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACC_MANDATED", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACC_MODULE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_ACC_FLAG", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_ACC_FLAG_I", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_NAMES", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_NAMES_LENGTH", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_Utf8", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_Integer", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_Float", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_Long", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_Double", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_Class", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_Fieldref", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_String", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_Methodref", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_InterfaceMethodref", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_NameAndType", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_MethodHandle", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_MethodType", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_Dynamic", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_InvokeDynamic", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_Module", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_Package", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_NAMES", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STATIC_INITIALIZER_NAME", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTRUCTOR_NAME", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTERFACES_IMPLEMENTED_BY_ARRAYS", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_CP_ENTRIES", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_CODE_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_ARRAY_DIMENSIONS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOP", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACONST_NULL", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ICONST_M1", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ICONST_0", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ICONST_1", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ICONST_2", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ICONST_3", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ICONST_4", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ICONST_5", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LCONST_0", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LCONST_1", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FCONST_0", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FCONST_1", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FCONST_2", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DCONST_0", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DCONST_1", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BIPUSH", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SIPUSH", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LDC", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LDC_W", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LDC2_W", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ILOAD", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LLOAD", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAD", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DLOAD", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALOAD", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ILOAD_0", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ILOAD_1", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ILOAD_2", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ILOAD_3", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LLOAD_0", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LLOAD_1", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LLOAD_2", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LLOAD_3", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAD_0", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAD_1", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAD_2", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAD_3", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DLOAD_0", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DLOAD_1", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DLOAD_2", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DLOAD_3", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALOAD_0", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALOAD_1", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALOAD_2", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALOAD_3", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IALOAD", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LALOAD", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FALOAD", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DALOAD", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AALOAD", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BALOAD", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CALOAD", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SALOAD", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISTORE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LSTORE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FSTORE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DSTORE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ASTORE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISTORE_0", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISTORE_1", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISTORE_2", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISTORE_3", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LSTORE_0", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LSTORE_1", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LSTORE_2", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LSTORE_3", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FSTORE_0", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FSTORE_1", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FSTORE_2", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FSTORE_3", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DSTORE_0", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DSTORE_1", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DSTORE_2", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DSTORE_3", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ASTORE_0", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ASTORE_1", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ASTORE_2", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ASTORE_3", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IASTORE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LASTORE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FASTORE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DASTORE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AASTORE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BASTORE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CASTORE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SASTORE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "POP", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "POP2", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DUP", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DUP_X1", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DUP_X2", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DUP2", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DUP2_X1", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DUP2_X2", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SWAP", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IADD", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LADD", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FADD", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DADD", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISUB", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LSUB", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FSUB", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DSUB", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMUL", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LMUL", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FMUL", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DMUL", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IDIV", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LDIV", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FDIV", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DDIV", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IREM", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LREM", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FREM", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DREM", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INEG", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LNEG", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FNEG", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DNEG", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISHL", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LSHL", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISHR", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LSHR", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IUSHR", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LUSHR", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IAND", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LAND", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IOR", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOR", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IXOR", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LXOR", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IINC", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "I2L", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "I2F", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "I2D", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "L2I", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "L2F", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "L2D", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "F2I", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "F2L", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "F2D", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "D2I", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "D2L", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "D2F", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "I2B", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INT2BYTE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "I2C", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INT2CHAR", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "I2S", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INT2SHORT", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LCMP", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FCMPL", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FCMPG", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DCMPL", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DCMPG", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IFEQ", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IFNE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IFLT", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IFGE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IFGT", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IFLE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IF_ICMPEQ", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IF_ICMPNE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IF_ICMPLT", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IF_ICMPGE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IF_ICMPGT", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IF_ICMPLE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IF_ACMPEQ", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IF_ACMPNE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GOTO", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JSR", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RET", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TABLESWITCH", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOOKUPSWITCH", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IRETURN", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LRETURN", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FRETURN", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DRETURN", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARETURN", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RETURN", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GETSTATIC", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUTSTATIC", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GETFIELD", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUTFIELD", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKEVIRTUAL", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKESPECIAL", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKENONVIRTUAL", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKESTATIC", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKEINTERFACE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKEDYNAMIC", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NEW", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NEWARRAY", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANEWARRAY", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAYLENGTH", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATHROW", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHECKCAST", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCEOF", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MONITORENTER", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MONITOREXIT", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WIDE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MULTIANEWARRAY", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IFNULL", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IFNONNULL", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GOTO_W", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JSR_W", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BREAKPOINT", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LDC_QUICK", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LDC_W_QUICK", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LDC2_W_QUICK", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GETFIELD_QUICK", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUTFIELD_QUICK", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GETFIELD2_QUICK", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUTFIELD2_QUICK", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GETSTATIC_QUICK", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUTSTATIC_QUICK", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GETSTATIC2_QUICK", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUTSTATIC2_QUICK", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKEVIRTUAL_QUICK", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKENONVIRTUAL_QUICK", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKESUPER_QUICK", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKESTATIC_QUICK", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKEINTERFACE_QUICK", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKEVIRTUALOBJECT_QUICK", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NEW_QUICK", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANEWARRAY_QUICK", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MULTIANEWARRAY_QUICK", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHECKCAST_QUICK", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCEOF_QUICK", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKEVIRTUAL_QUICK_W", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GETFIELD_QUICK_W", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUTFIELD_QUICK_W", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMPDEP1", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMPDEP2", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUSH", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SWITCH", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNDEFINED", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNPREDICTABLE", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RESERVED", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ILLEGAL_OPCODE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ILLEGAL_TYPE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_BOOLEAN", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_CHAR", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_FLOAT", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_DOUBLE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_BYTE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_SHORT", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_INT", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_LONG", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_VOID", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_ARRAY", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_OBJECT", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_REFERENCE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_UNKNOWN", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_ADDRESS", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_NAMES", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_TYPE_NAMES", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHORT_TYPE_NAMES", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_OF_OPERANDS", "[S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_OF_OPERANDS", "[[S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OPCODE_NAMES", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OPCODE_NAMES_LENGTH", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSUME_STACK", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRODUCE_STACK", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_UNKNOWN", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_SOURCE_FILE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_CONSTANT_VALUE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_CODE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_EXCEPTIONS", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_LINE_NUMBER_TABLE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_LOCAL_VARIABLE_TABLE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_INNER_CLASSES", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_SYNTHETIC", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_DEPRECATED", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_PMG", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_SIGNATURE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_STACK_MAP", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_RUNTIME_VISIBLE_ANNOTATIONS", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_RUNTIME_INVISIBLE_ANNOTATIONS", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_RUNTIME_VISIBLE_PARAMETER_ANNOTATIONS", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_RUNTIME_INVISIBLE_PARAMETER_ANNOTATIONS", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_ANNOTATION_DEFAULT", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_LOCAL_VARIABLE_TYPE_TABLE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_ENCLOSING_METHOD", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_STACK_MAP_TABLE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_BOOTSTRAP_METHODS", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_METHOD_PARAMETERS", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_MODULE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_MODULE_PACKAGES", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_MODULE_MAIN_CLASS", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_NEST_HOST", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTR_NEST_MEMBERS", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KNOWN_ATTRIBUTES", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTRIBUTE_NAMES", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ITEM_Bogus", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ITEM_Integer", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ITEM_Float", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ITEM_Double", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ITEM_Long", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ITEM_Null", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ITEM_InitObject", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ITEM_Object", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ITEM_NewObject", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ITEM_NAMES", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SAME_FRAME", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SAME_LOCALS_1_STACK_ITEM_FRAME", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SAME_LOCALS_1_STACK_ITEM_FRAME_EXTENDED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHOP_FRAME", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SAME_FRAME_EXTENDED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "APPEND_FRAME", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FULL_FRAME", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SAME_FRAME_MAX", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SAME_LOCALS_1_STACK_ITEM_FRAME_MAX", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHOP_FRAME_MAX", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "APPEND_FRAME_MAX", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REF_getField", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REF_getStatic", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REF_putField", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REF_putStatic", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REF_invokeVirtual", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REF_invokeStatic", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REF_invokeSpecial", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REF_newInvokeSpecial", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REF_invokeInterface", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHODHANDLE_NAMES", "[Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getTypeName", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAccessName", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInterfacesImplementedByArrays", "()Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getClassTypeName", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getShortTypeName", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getNoOfOperands", "(I)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getOperandType", "(II)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getOperandTypeCount", "(I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getItemName", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAttributeName", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getOpcodeName", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getConsumeStack", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getProduceStack", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMethodHandleName", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getConstantName", "(I)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int JVM_CLASSFILE_MAGIC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MAJOR_1_1_Property
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

	[JniSignatureAttribute("S", "public static final")]
	public static short MINOR_1_1_Property
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

	[JniSignatureAttribute("S", "public static final")]
	public static short MAJOR_1_2_Property
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

	[JniSignatureAttribute("S", "public static final")]
	public static short MINOR_1_2_Property
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

	[JniSignatureAttribute("S", "public static final")]
	public static short MAJOR_1_3_Property
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

	[JniSignatureAttribute("S", "public static final")]
	public static short MINOR_1_3_Property
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

	[JniSignatureAttribute("S", "public static final")]
	public static short MAJOR_1_4_Property
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

	[JniSignatureAttribute("S", "public static final")]
	public static short MINOR_1_4_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MAJOR_1_5_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MINOR_1_5_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MAJOR_1_6_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MINOR_1_6_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MAJOR_1_7_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MINOR_1_7_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MAJOR_1_8_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MINOR_1_8_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MAJOR_9_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MINOR_9_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MAJOR_1_9_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MINOR_1_9_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MAJOR_10_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MINOR_10_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MAJOR_11_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MINOR_11_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[24]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[24], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MAJOR_12_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[25]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[25], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MINOR_12_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[26]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[26], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MAJOR_13_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[27]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[27], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MINOR_13_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[28]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[28], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MAJOR_14_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[29]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[29], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MINOR_14_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[30]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[30], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MAJOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[31]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[31], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MINOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[32]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[32], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int MAX_SHORT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[33]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[33], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int MAX_BYTE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[34]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[34], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ACC_PUBLIC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[35]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[35], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ACC_PRIVATE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[36]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[36], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ACC_PROTECTED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[37]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[37], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ACC_STATIC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[38]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[38], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ACC_FINAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[39]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[39], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ACC_OPEN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[40]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[40], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ACC_SUPER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[41]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[41], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ACC_SYNCHRONIZED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[42]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[42], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ACC_TRANSITIVE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[43]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[43], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ACC_BRIDGE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[44]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[44], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ACC_STATIC_PHASE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[45]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[45], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ACC_VOLATILE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[46]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[46], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ACC_TRANSIENT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[47]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[47], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ACC_VARARGS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[48]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[48], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ACC_NATIVE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[49]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[49], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ACC_INTERFACE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[50]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[50], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ACC_ABSTRACT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[51]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[51], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ACC_STRICT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[52]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[52], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ACC_SYNTHETIC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[53]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[53], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ACC_ANNOTATION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[54]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[54], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ACC_ENUM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[55]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[55], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ACC_MANDATED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[56]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[56], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ACC_MODULE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[57]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[57], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MAX_ACC_FLAG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[58]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[58], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int MAX_ACC_FLAG_I_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[59]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[59], value);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> ACCESS_NAMES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[60]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[60], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ACCESS_NAMES_LENGTH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[61]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[61], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte CONSTANT_Utf8_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[62]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[62], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte CONSTANT_Integer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[63]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[63], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte CONSTANT_Float_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[64]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[64], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte CONSTANT_Long_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[65]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[65], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte CONSTANT_Double_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[66]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[66], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte CONSTANT_Class_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[67]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[67], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte CONSTANT_Fieldref_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[68]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[68], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte CONSTANT_String_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[69]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[69], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte CONSTANT_Methodref_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[70]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[70], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte CONSTANT_InterfaceMethodref_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[71]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[71], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte CONSTANT_NameAndType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[72]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[72], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte CONSTANT_MethodHandle_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[73]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[73], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte CONSTANT_MethodType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[74]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[74], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte CONSTANT_Dynamic_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[75]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[75], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte CONSTANT_InvokeDynamic_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[76]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[76], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte CONSTANT_Module_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[77]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[77], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte CONSTANT_Package_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[78]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[78], value);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> CONSTANT_NAMES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[79]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[79], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String STATIC_INITIALIZER_NAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[80]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[80], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String CONSTRUCTOR_NAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[81]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[81], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> INTERFACES_IMPLEMENTED_BY_ARRAYS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[82]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[82], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int MAX_CP_ENTRIES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[83]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[83], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int MAX_CODE_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[84]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[84], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int MAX_ARRAY_DIMENSIONS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[85]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[85], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short NOP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[86]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[86], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ACONST_NULL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[87]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[87], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ICONST_M1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[88]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[88], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ICONST_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[89]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[89], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ICONST_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[90]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[90], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ICONST_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[91]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[91], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ICONST_3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[92]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[92], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ICONST_4_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[93]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[93], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ICONST_5_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[94]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[94], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LCONST_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[95]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[95], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LCONST_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[96]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[96], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short FCONST_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[97]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[97], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short FCONST_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[98]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[98], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short FCONST_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[99]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[99], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DCONST_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[100]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[100], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DCONST_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[101]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[101], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short BIPUSH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[102]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[102], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short SIPUSH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[103]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[103], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LDC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[104]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[104], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LDC_W_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[105]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[105], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LDC2_W_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[106]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[106], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ILOAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[107]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[107], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LLOAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[108]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[108], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short FLOAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[109]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[109], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DLOAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[110]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[110], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ALOAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[111]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[111], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ILOAD_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[112]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[112], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ILOAD_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[113]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[113], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ILOAD_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[114]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[114], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ILOAD_3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[115]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[115], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LLOAD_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[116]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[116], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LLOAD_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[117]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[117], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LLOAD_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[118]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[118], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LLOAD_3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[119]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[119], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short FLOAD_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[120]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[120], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short FLOAD_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[121]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[121], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short FLOAD_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[122]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[122], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short FLOAD_3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[123]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[123], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DLOAD_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[124]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[124], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DLOAD_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[125]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[125], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DLOAD_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[126]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[126], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DLOAD_3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[127]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[127], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ALOAD_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[128]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[128], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ALOAD_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[129]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[129], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ALOAD_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[130]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[130], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ALOAD_3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[131]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[131], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IALOAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[132]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[132], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LALOAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[133]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[133], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short FALOAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[134]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[134], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DALOAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[135]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[135], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short AALOAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[136]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[136], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short BALOAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[137]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[137], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short CALOAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[138]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[138], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short SALOAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[139]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[139], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ISTORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[140]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[140], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LSTORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[141]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[141], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short FSTORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[142]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[142], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DSTORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[143]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[143], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ASTORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[144]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[144], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ISTORE_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[145]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[145], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ISTORE_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[146]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[146], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ISTORE_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[147]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[147], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ISTORE_3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[148]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[148], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LSTORE_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[149]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[149], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LSTORE_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[150]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[150], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LSTORE_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[151]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[151], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LSTORE_3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[152]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[152], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short FSTORE_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[153]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[153], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short FSTORE_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[154]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[154], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short FSTORE_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[155]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[155], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short FSTORE_3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[156]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[156], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DSTORE_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[157]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[157], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DSTORE_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[158]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[158], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DSTORE_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[159]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[159], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DSTORE_3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[160]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[160], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ASTORE_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[161]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[161], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ASTORE_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[162]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[162], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ASTORE_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[163]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[163], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ASTORE_3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[164]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[164], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IASTORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[165]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[165], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LASTORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[166]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[166], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short FASTORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[167]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[167], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DASTORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[168]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[168], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short AASTORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[169]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[169], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short BASTORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[170]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[170], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short CASTORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[171]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[171], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short SASTORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[172]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[172], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short POP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[173]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[173], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short POP2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[174]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[174], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DUP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[175]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[175], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DUP_X1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[176]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[176], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DUP_X2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[177]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[177], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DUP2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[178]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[178], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DUP2_X1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[179]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[179], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DUP2_X2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[180]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[180], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short SWAP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[181]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[181], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IADD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[182]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[182], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LADD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[183]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[183], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short FADD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[184]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[184], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DADD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[185]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[185], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ISUB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[186]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[186], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LSUB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[187]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[187], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short FSUB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[188]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[188], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DSUB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[189]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[189], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IMUL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[190]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[190], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LMUL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[191]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[191], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short FMUL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[192]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[192], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DMUL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[193]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[193], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IDIV_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[194]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[194], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LDIV_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[195]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[195], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short FDIV_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[196]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[196], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DDIV_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[197]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[197], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IREM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[198]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[198], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LREM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[199]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[199], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short FREM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[200]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[200], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DREM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[201]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[201], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short INEG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[202]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[202], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LNEG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[203]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[203], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short FNEG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[204]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[204], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DNEG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[205]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[205], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ISHL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[206]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[206], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LSHL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[207]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[207], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ISHR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[208]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[208], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LSHR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[209]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[209], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IUSHR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[210]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[210], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LUSHR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[211]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[211], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IAND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[212]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[212], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LAND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[213]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[213], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[214]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[214], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[215]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[215], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IXOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[216]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[216], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LXOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[217]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[217], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IINC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[218]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[218], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short I2L_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[219]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[219], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short I2F_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[220]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[220], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short I2D_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[221]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[221], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short L2I_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[222]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[222], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short L2F_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[223]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[223], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short L2D_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[224]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[224], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short F2I_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[225]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[225], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short F2L_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[226]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[226], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short F2D_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[227]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[227], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short D2I_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[228]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[228], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short D2L_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[229]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[229], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short D2F_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[230]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[230], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short I2B_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[231]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[231], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short INT2BYTE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[232]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[232], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short I2C_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[233]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[233], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short INT2CHAR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[234]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[234], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short I2S_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[235]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[235], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short INT2SHORT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[236]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[236], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LCMP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[237]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[237], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short FCMPL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[238]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[238], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short FCMPG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[239]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[239], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DCMPL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[240]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[240], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DCMPG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[241]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[241], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IFEQ_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[242]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[242], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IFNE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[243]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[243], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IFLT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[244]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[244], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IFGE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[245]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[245], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IFGT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[246]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[246], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IFLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[247]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[247], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IF_ICMPEQ_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[248]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[248], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IF_ICMPNE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[249]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[249], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IF_ICMPLT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[250]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[250], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IF_ICMPGE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[251]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[251], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IF_ICMPGT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[252]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[252], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IF_ICMPLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[253]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[253], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IF_ACMPEQ_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[254]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[254], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IF_ACMPNE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[255]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[255], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short GOTO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[256]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[256], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short JSR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[257]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[257], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short RET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[258]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[258], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short TABLESWITCH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[259]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[259], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LOOKUPSWITCH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[260]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[260], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IRETURN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[261]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[261], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LRETURN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[262]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[262], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short FRETURN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[263]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[263], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short DRETURN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[264]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[264], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ARETURN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[265]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[265], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short RETURN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[266]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[266], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short GETSTATIC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[267]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[267], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short PUTSTATIC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[268]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[268], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short GETFIELD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[269]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[269], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short PUTFIELD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[270]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[270], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short INVOKEVIRTUAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[271]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[271], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short INVOKESPECIAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[272]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[272], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short INVOKENONVIRTUAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[273]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[273], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short INVOKESTATIC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[274]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[274], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short INVOKEINTERFACE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[275]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[275], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short INVOKEDYNAMIC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[276]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[276], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short NEW_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[277]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[277], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short NEWARRAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[278]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[278], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ANEWARRAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[279]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[279], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ARRAYLENGTH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[280]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[280], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ATHROW_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[281]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[281], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short CHECKCAST_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[282]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[282], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short INSTANCEOF_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[283]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[283], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MONITORENTER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[284]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[284], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MONITOREXIT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[285]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[285], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short WIDE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[286]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[286], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MULTIANEWARRAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[287]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[287], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IFNULL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[288]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[288], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IFNONNULL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[289]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[289], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short GOTO_W_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[290]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[290], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short JSR_W_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[291]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[291], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short BREAKPOINT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[292]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[292], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LDC_QUICK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[293]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[293], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LDC_W_QUICK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[294]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[294], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short LDC2_W_QUICK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[295]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[295], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short GETFIELD_QUICK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[296]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[296], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short PUTFIELD_QUICK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[297]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[297], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short GETFIELD2_QUICK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[298]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[298], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short PUTFIELD2_QUICK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[299]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[299], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short GETSTATIC_QUICK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[300]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[300], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short PUTSTATIC_QUICK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[301]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[301], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short GETSTATIC2_QUICK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[302]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[302], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short PUTSTATIC2_QUICK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[303]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[303], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short INVOKEVIRTUAL_QUICK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[304]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[304], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short INVOKENONVIRTUAL_QUICK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[305]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[305], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short INVOKESUPER_QUICK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[306]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[306], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short INVOKESTATIC_QUICK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[307]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[307], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short INVOKEINTERFACE_QUICK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[308]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[308], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short INVOKEVIRTUALOBJECT_QUICK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[309]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[309], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short NEW_QUICK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[310]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[310], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short ANEWARRAY_QUICK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[311]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[311], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short MULTIANEWARRAY_QUICK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[312]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[312], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short CHECKCAST_QUICK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[313]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[313], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short INSTANCEOF_QUICK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[314]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[314], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short INVOKEVIRTUAL_QUICK_W_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[315]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[315], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short GETFIELD_QUICK_W_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[316]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[316], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short PUTFIELD_QUICK_W_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[317]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[317], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IMPDEP1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[318]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[318], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short IMPDEP2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[319]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[319], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short PUSH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[320]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[320], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short SWITCH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[321]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[321], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short UNDEFINED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[322]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[322], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short UNPREDICTABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[323]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[323], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short RESERVED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[324]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[324], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String ILLEGAL_OPCODE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[325]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[325], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String ILLEGAL_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[326]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[326], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte T_BOOLEAN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[327]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[327], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte T_CHAR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[328]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[328], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte T_FLOAT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[329]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[329], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte T_DOUBLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[330]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[330], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte T_BYTE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[331]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[331], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte T_SHORT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[332]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[332], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte T_INT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[333]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[333], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte T_LONG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[334]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[334], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte T_VOID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[335]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[335], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte T_ARRAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[336]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[336], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte T_OBJECT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[337]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[337], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte T_REFERENCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[338]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[338], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte T_UNKNOWN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[339]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[339], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte T_ADDRESS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[340]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[340], value);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> TYPE_NAMES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[341]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[341], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> CLASS_TYPE_NAMES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[342]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[342], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> SHORT_TYPE_NAMES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[343]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[343], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[S", "private static final")]
	public static JavaArray<short> NO_OF_OPERANDS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[344]);
			return DovaInterfaceFactory.Get<JavaArray<short>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[344], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[[S", "private static final")]
	public static JavaArray<JavaArray<short>> TYPE_OF_OPERANDS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[345]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<short>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[345], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> OPCODE_NAMES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[346]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[346], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int OPCODE_NAMES_LENGTH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[347]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[347], value);
		}
	}

	[JniSignatureAttribute("[I", "private static final")]
	public static JavaArray<int> CONSUME_STACK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[348]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[348], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "private static final")]
	public static JavaArray<int> PRODUCE_STACK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[349]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[349], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_UNKNOWN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[350]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[350], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_SOURCE_FILE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[351]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[351], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_CONSTANT_VALUE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[352]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[352], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_CODE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[353]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[353], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_EXCEPTIONS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[354]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[354], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_LINE_NUMBER_TABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[355]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[355], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_LOCAL_VARIABLE_TABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[356]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[356], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_INNER_CLASSES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[357]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[357], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_SYNTHETIC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[358]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[358], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_DEPRECATED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[359]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[359], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_PMG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[360]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[360], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_SIGNATURE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[361]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[361], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_STACK_MAP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[362]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[362], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_RUNTIME_VISIBLE_ANNOTATIONS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[363]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[363], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_RUNTIME_INVISIBLE_ANNOTATIONS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[364]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[364], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_RUNTIME_VISIBLE_PARAMETER_ANNOTATIONS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[365]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[365], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_RUNTIME_INVISIBLE_PARAMETER_ANNOTATIONS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[366]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[366], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_ANNOTATION_DEFAULT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[367]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[367], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_LOCAL_VARIABLE_TYPE_TABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[368]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[368], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_ENCLOSING_METHOD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[369]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[369], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_STACK_MAP_TABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[370]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[370], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_BOOTSTRAP_METHODS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[371]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[371], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_METHOD_PARAMETERS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[372]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[372], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_MODULE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[373]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[373], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_MODULE_PACKAGES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[374]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[374], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_MODULE_MAIN_CLASS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[375]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[375], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_NEST_HOST_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[376]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[376], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ATTR_NEST_MEMBERS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[377]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[377], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short KNOWN_ATTRIBUTES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[378]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[378], value);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> ATTRIBUTE_NAMES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[379]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[379], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ITEM_Bogus_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[380]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[380], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ITEM_Integer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[381]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[381], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ITEM_Float_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[382]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[382], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ITEM_Double_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[383]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[383], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ITEM_Long_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[384]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[384], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ITEM_Null_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[385]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[385], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ITEM_InitObject_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[386]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[386], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ITEM_Object_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[387]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[387], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte ITEM_NewObject_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[388]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[388], value);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> ITEM_NAMES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[389]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[389], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int SAME_FRAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[390]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[390], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int SAME_LOCALS_1_STACK_ITEM_FRAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[391]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[391], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int SAME_LOCALS_1_STACK_ITEM_FRAME_EXTENDED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[392]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[392], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CHOP_FRAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[393]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[393], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int SAME_FRAME_EXTENDED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[394]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[394], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int APPEND_FRAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[395]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[395], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int FULL_FRAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[396]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[396], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int SAME_FRAME_MAX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[397]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[397], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int SAME_LOCALS_1_STACK_ITEM_FRAME_MAX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[398]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[398], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CHOP_FRAME_MAX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[399]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[399], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int APPEND_FRAME_MAX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[400]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[400], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte REF_getField_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[401]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[401], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte REF_getStatic_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[402]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[402], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte REF_putField_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[403]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[403], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte REF_putStatic_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[404]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[404], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte REF_invokeVirtual_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[405]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[405], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte REF_invokeStatic_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[406]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[406], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte REF_invokeSpecial_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[407]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[407], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte REF_newInvokeSpecial_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[408]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[408], value);
		}
	}

	[JniSignatureAttribute("B", "public static final")]
	public static byte REF_invokeInterface_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[409]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[409], value);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> METHODHANDLE_NAMES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[410]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[410], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Const(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public Const() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/bcel/internal/Const;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getTypeName(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getAccessName(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Iterable;", "public static")]
	public static Dova.JDK.java.lang.Iterable getInterfacesImplementedByArrays()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getClassTypeName(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getShortTypeName(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)S", "public static")]
	public static short getNoOfOperands(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticShortMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)S", "public static")]
	public static short getOperandType(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticShortMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)J", "public static")]
	public static long getOperandTypeCount(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getItemName(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getAttributeName(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getOpcodeName(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)I", "public static")]
	public static int getConsumeStack(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public static")]
	public static int getProduceStack(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getMethodHandleName(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getConstantName(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
