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

namespace Dova.JDK.com.sun.tools.classfile;

[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public final")]
public partial class Opcode
	: Dova.JDK.java.lang.Enum
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Opcode()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/Opcode;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOP", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACONST_NULL", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ICONST_M1", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ICONST_0", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ICONST_1", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ICONST_2", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ICONST_3", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ICONST_4", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ICONST_5", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LCONST_0", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LCONST_1", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FCONST_0", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FCONST_1", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FCONST_2", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DCONST_0", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DCONST_1", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BIPUSH", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SIPUSH", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LDC", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LDC_W", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LDC2_W", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ILOAD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LLOAD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DLOAD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALOAD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ILOAD_0", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ILOAD_1", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ILOAD_2", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ILOAD_3", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LLOAD_0", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LLOAD_1", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LLOAD_2", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LLOAD_3", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAD_0", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAD_1", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAD_2", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAD_3", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DLOAD_0", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DLOAD_1", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DLOAD_2", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DLOAD_3", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALOAD_0", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALOAD_1", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALOAD_2", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALOAD_3", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IALOAD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LALOAD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FALOAD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DALOAD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AALOAD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BALOAD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CALOAD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SALOAD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISTORE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LSTORE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FSTORE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DSTORE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ASTORE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISTORE_0", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISTORE_1", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISTORE_2", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISTORE_3", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LSTORE_0", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LSTORE_1", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LSTORE_2", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LSTORE_3", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FSTORE_0", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FSTORE_1", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FSTORE_2", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FSTORE_3", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DSTORE_0", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DSTORE_1", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DSTORE_2", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DSTORE_3", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ASTORE_0", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ASTORE_1", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ASTORE_2", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ASTORE_3", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IASTORE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LASTORE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FASTORE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DASTORE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AASTORE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BASTORE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CASTORE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SASTORE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "POP", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "POP2", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DUP", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DUP_X1", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DUP_X2", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DUP2", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DUP2_X1", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DUP2_X2", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SWAP", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IADD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LADD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FADD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DADD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISUB", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LSUB", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FSUB", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DSUB", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMUL", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LMUL", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FMUL", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DMUL", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IDIV", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LDIV", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FDIV", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DDIV", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IREM", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LREM", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FREM", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DREM", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INEG", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LNEG", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FNEG", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DNEG", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISHL", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LSHL", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISHR", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LSHR", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IUSHR", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LUSHR", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IAND", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LAND", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IOR", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOR", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IXOR", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LXOR", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IINC", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "I2L", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "I2F", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "I2D", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "L2I", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "L2F", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "L2D", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "F2I", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "F2L", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "F2D", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "D2I", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "D2L", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "D2F", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "I2B", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "I2C", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "I2S", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LCMP", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FCMPL", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FCMPG", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DCMPL", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DCMPG", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IFEQ", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IFNE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IFLT", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IFGE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IFGT", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IFLE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IF_ICMPEQ", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IF_ICMPNE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IF_ICMPLT", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IF_ICMPGE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IF_ICMPGT", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IF_ICMPLE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IF_ACMPEQ", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IF_ACMPNE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GOTO", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JSR", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RET", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TABLESWITCH", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOOKUPSWITCH", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IRETURN", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LRETURN", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FRETURN", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DRETURN", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARETURN", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RETURN", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GETSTATIC", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUTSTATIC", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GETFIELD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUTFIELD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKEVIRTUAL", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKESPECIAL", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKESTATIC", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKEINTERFACE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKEDYNAMIC", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NEW", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NEWARRAY", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANEWARRAY", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAYLENGTH", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATHROW", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHECKCAST", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCEOF", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MONITORENTER", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MONITOREXIT", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MULTIANEWARRAY", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IFNULL", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IFNONNULL", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GOTO_W", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JSR_W", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ILOAD_W", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LLOAD_W", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAD_W", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DLOAD_W", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALOAD_W", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISTORE_W", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LSTORE_W", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FSTORE_W", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DSTORE_W", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ASTORE_W", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IINC_W", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RET_W", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOAD_UBYTE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOAD_BYTE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOAD_CHAR", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOAD_SHORT", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOAD_WORD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RET_FROM_SUB", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOAD_CHAR_OE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOAD_SHORT_OE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOAD_WORD_OE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NCLOAD_UBYTE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NCLOAD_BYTE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NCLOAD_CHAR", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NCLOAD_SHORT", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NCLOAD_WORD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NCLOAD_CHAR_OE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NCLOAD_SHORT_OE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NCLOAD_WORD_OE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CACHE_FLUSH", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STORE_BYTE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STORE_SHORT", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STORE_WORD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STORE_SHORT_OE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STORE_WORD_OE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NCSTORE_BYTE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NCSTORE_SHORT", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NCSTORE_WORD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NCSTORE_SHORT_OE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NCSTORE_WORD_OE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ZERO_LINE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENTER_SYNC_METHOD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_LOAD_UBYTE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_LOAD_BYTE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_LOAD_CHAR", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_LOAD_SHORT", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_LOAD_WORD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_RET_FROM_TRAP", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_DCACHE_TAG", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_DCACHE_DATA", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_LOAD_CHAR_OE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_LOAD_SHORT_OE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_LOAD_WORD_OE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_ICACHE_TAG", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_ICACHE_DATA", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_NCLOAD_UBYTE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_NCLOAD_BYTE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_NCLOAD_CHAR", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_NCLOAD_SHORT", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_NCLOAD_WORD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_POWERDOWN", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_SCACHE_DATA", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_NCLOAD_CHAR_OE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_NCLOAD_SHORT_OE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_NCLOAD_WORD_OE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_CACHE_FLUSH", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_CACHE_INDEX_FLUSH", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_STORE_BYTE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_STORE_SHORT", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_STORE_WORD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_DCACHE_TAG", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_DCACHE_DATA", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_STORE_SHORT_OE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_STORE_WORD_OE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_ICACHE_TAG", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_ICACHE_DATA", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_NCSTORE_BYTE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_NCSTORE_SHORT", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_NCSTORE_WORD", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_RESET", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_SCACHE_DATA", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_NCSTORE_SHORT_OE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_NCSTORE_WORD_OE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_ZERO_LINE", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_0", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_1", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_2", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_3", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_4", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_5", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_6", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_7", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_8", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_9", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_10", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_11", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_12", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_13", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_14", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_15", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_16", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_17", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_18", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_19", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_20", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_21", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_22", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_23", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_24", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_25", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_26", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_27", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_28", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_29", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_30", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_READ_REG_31", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_0", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_1", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_2", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_3", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_4", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_5", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_6", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_7", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_8", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_9", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_10", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_11", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_12", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_13", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_14", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_15", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_16", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_17", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_18", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_19", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_20", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_21", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_22", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_23", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_24", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_25", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_26", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_27", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_28", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_29", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_30", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV_WRITE_REG_31", "Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "set", "Lcom/sun/tools/classfile/Opcode$Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "opcode", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "kind", "Lcom/sun/tools/classfile/Instruction$Kind;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "stdOpcodes", "[Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "wideOpcodes", "[Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "nonPrivOpcodes", "[Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "privOpcodes", "[Lcom/sun/tools/classfile/Opcode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WIDE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NONPRIV", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIV", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/classfile/Opcode;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILcom/sun/tools/classfile/Opcode$Set;I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IILcom/sun/tools/classfile/Instruction$Kind;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;II)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILcom/sun/tools/classfile/Opcode$Set;ILcom/sun/tools/classfile/Instruction$Kind;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "get", "(II)Lcom/sun/tools/classfile/Opcode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "get", "(I)Lcom/sun/tools/classfile/Opcode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/classfile/Opcode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/classfile/Opcode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/classfile/Opcode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getOpcodeBlock", "(I)[Lcom/sun/tools/classfile/Opcode;"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode NOP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ACONST_NULL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ICONST_M1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ICONST_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ICONST_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ICONST_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ICONST_3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ICONST_4_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ICONST_5_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LCONST_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LCONST_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode FCONST_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode FCONST_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode FCONST_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DCONST_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DCONST_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode BIPUSH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode SIPUSH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LDC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LDC_W_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LDC2_W_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ILOAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LLOAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode FLOAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DLOAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ALOAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ILOAD_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ILOAD_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ILOAD_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ILOAD_3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LLOAD_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LLOAD_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LLOAD_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LLOAD_3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode FLOAD_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode FLOAD_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode FLOAD_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode FLOAD_3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DLOAD_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DLOAD_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DLOAD_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DLOAD_3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ALOAD_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ALOAD_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ALOAD_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ALOAD_3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IALOAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LALOAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode FALOAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[48]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[48], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DALOAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[49]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[49], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode AALOAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[50]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[50], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode BALOAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[51]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[51], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode CALOAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[52]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[52], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode SALOAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[53]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[53], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ISTORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[54]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[54], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LSTORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[55]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[55], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode FSTORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[56]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[56], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DSTORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[57]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[57], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ASTORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[58]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[58], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ISTORE_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[59]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[59], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ISTORE_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[60]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[60], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ISTORE_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[61]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[61], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ISTORE_3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[62]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[62], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LSTORE_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[63]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[63], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LSTORE_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[64]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[64], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LSTORE_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[65]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[65], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LSTORE_3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[66]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[66], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode FSTORE_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[67]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[67], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode FSTORE_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[68]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[68], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode FSTORE_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[69]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[69], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode FSTORE_3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[70]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[70], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DSTORE_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[71]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[71], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DSTORE_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[72]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[72], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DSTORE_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[73]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[73], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DSTORE_3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[74]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[74], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ASTORE_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[75]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[75], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ASTORE_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[76]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[76], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ASTORE_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[77]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[77], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ASTORE_3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[78]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[78], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IASTORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[79]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[79], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LASTORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[80]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[80], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode FASTORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[81]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[81], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DASTORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[82]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[82], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode AASTORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[83]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[83], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode BASTORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[84]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[84], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode CASTORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[85]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[85], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode SASTORE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[86]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[86], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode POP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[87]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[87], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode POP2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[88]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[88], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DUP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[89]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[89], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DUP_X1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[90]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[90], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DUP_X2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[91]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[91], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DUP2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[92]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[92], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DUP2_X1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[93]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[93], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DUP2_X2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[94]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[94], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode SWAP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[95]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[95], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IADD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[96]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[96], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LADD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[97]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[97], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode FADD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[98]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[98], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DADD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[99]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[99], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ISUB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[100]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[100], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LSUB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[101]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[101], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode FSUB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[102]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[102], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DSUB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[103]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[103], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IMUL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[104]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[104], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LMUL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[105]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[105], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode FMUL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[106]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[106], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DMUL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[107]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[107], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IDIV_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[108]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[108], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LDIV_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[109]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[109], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode FDIV_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[110]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[110], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DDIV_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[111]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[111], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IREM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[112]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[112], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LREM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[113]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[113], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode FREM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[114]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[114], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DREM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[115]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[115], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode INEG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[116]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[116], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LNEG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[117]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[117], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode FNEG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[118]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[118], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DNEG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[119]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[119], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ISHL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[120]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[120], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LSHL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[121]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[121], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ISHR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[122]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[122], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LSHR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[123]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[123], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IUSHR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[124]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[124], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LUSHR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[125]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[125], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IAND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[126]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[126], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LAND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[127]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[127], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[128]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[128], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[129]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[129], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IXOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[130]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[130], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LXOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[131]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[131], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IINC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[132]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[132], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode I2L_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[133]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[133], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode I2F_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[134]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[134], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode I2D_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[135]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[135], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode L2I_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[136]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[136], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode L2F_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[137]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[137], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode L2D_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[138]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[138], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode F2I_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[139]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[139], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode F2L_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[140]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[140], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode F2D_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[141]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[141], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode D2I_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[142]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[142], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode D2L_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[143]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[143], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode D2F_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[144]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[144], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode I2B_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[145]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[145], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode I2C_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[146]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[146], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode I2S_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[147]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[147], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LCMP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[148]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[148], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode FCMPL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[149]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[149], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode FCMPG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[150]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[150], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DCMPL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[151]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[151], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DCMPG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[152]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[152], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IFEQ_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[153]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[153], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IFNE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[154]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[154], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IFLT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[155]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[155], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IFGE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[156]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[156], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IFGT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[157]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[157], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IFLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[158]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[158], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IF_ICMPEQ_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[159]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[159], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IF_ICMPNE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[160]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[160], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IF_ICMPLT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[161]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[161], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IF_ICMPGE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[162]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[162], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IF_ICMPGT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[163]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[163], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IF_ICMPLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[164]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[164], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IF_ACMPEQ_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[165]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[165], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IF_ACMPNE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[166]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[166], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode GOTO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[167]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[167], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode JSR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[168]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[168], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode RET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[169]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[169], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode TABLESWITCH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[170]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[170], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LOOKUPSWITCH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[171]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[171], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IRETURN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[172]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[172], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LRETURN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[173]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[173], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode FRETURN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[174]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[174], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DRETURN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[175]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[175], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ARETURN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[176]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[176], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode RETURN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[177]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[177], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode GETSTATIC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[178]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[178], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PUTSTATIC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[179]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[179], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode GETFIELD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[180]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[180], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PUTFIELD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[181]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[181], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode INVOKEVIRTUAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[182]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[182], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode INVOKESPECIAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[183]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[183], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode INVOKESTATIC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[184]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[184], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode INVOKEINTERFACE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[185]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[185], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode INVOKEDYNAMIC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[186]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[186], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode NEW_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[187]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[187], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode NEWARRAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[188]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[188], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ANEWARRAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[189]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[189], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ARRAYLENGTH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[190]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[190], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ATHROW_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[191]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[191], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode CHECKCAST_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[192]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[192], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode INSTANCEOF_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[193]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[193], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode MONITORENTER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[194]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[194], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode MONITOREXIT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[195]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[195], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode MULTIANEWARRAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[196]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[196], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IFNULL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[197]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[197], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IFNONNULL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[198]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[198], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode GOTO_W_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[199]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[199], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode JSR_W_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[200]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[200], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ILOAD_W_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[201]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[201], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LLOAD_W_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[202]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[202], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode FLOAD_W_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[203]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[203], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DLOAD_W_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[204]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[204], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ALOAD_W_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[205]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[205], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ISTORE_W_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[206]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[206], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LSTORE_W_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[207]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[207], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode FSTORE_W_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[208]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[208], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode DSTORE_W_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[209]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[209], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ASTORE_W_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[210]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[210], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode IINC_W_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[211]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[211], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode RET_W_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[212]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[212], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LOAD_UBYTE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[213]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[213], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LOAD_BYTE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[214]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[214], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LOAD_CHAR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[215]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[215], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LOAD_SHORT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[216]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[216], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LOAD_WORD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[217]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[217], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode RET_FROM_SUB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[218]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[218], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LOAD_CHAR_OE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[219]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[219], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LOAD_SHORT_OE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[220]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[220], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode LOAD_WORD_OE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[221]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[221], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode NCLOAD_UBYTE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[222]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[222], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode NCLOAD_BYTE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[223]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[223], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode NCLOAD_CHAR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[224]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[224], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode NCLOAD_SHORT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[225]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[225], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode NCLOAD_WORD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[226]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[226], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode NCLOAD_CHAR_OE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[227]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[227], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode NCLOAD_SHORT_OE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[228]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[228], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode NCLOAD_WORD_OE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[229]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[229], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode CACHE_FLUSH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[230]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[230], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode STORE_BYTE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[231]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[231], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode STORE_SHORT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[232]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[232], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode STORE_WORD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[233]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[233], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode STORE_SHORT_OE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[234]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[234], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode STORE_WORD_OE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[235]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[235], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode NCSTORE_BYTE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[236]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[236], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode NCSTORE_SHORT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[237]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[237], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode NCSTORE_WORD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[238]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[238], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode NCSTORE_SHORT_OE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[239]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[239], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode NCSTORE_WORD_OE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[240]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[240], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ZERO_LINE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[241]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[241], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode ENTER_SYNC_METHOD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[242]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[242], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_LOAD_UBYTE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[243]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[243], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_LOAD_BYTE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[244]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[244], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_LOAD_CHAR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[245]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[245], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_LOAD_SHORT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[246]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[246], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_LOAD_WORD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[247]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[247], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_RET_FROM_TRAP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[248]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[248], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_DCACHE_TAG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[249]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[249], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_DCACHE_DATA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[250]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[250], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_LOAD_CHAR_OE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[251]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[251], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_LOAD_SHORT_OE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[252]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[252], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_LOAD_WORD_OE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[253]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[253], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_ICACHE_TAG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[254]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[254], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_ICACHE_DATA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[255]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[255], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_NCLOAD_UBYTE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[256]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[256], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_NCLOAD_BYTE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[257]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[257], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_NCLOAD_CHAR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[258]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[258], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_NCLOAD_SHORT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[259]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[259], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_NCLOAD_WORD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[260]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[260], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_POWERDOWN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[261]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[261], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_SCACHE_DATA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[262]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[262], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_NCLOAD_CHAR_OE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[263]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[263], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_NCLOAD_SHORT_OE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[264]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[264], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_NCLOAD_WORD_OE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[265]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[265], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_CACHE_FLUSH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[266]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[266], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_CACHE_INDEX_FLUSH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[267]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[267], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_STORE_BYTE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[268]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[268], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_STORE_SHORT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[269]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[269], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_STORE_WORD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[270]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[270], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_DCACHE_TAG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[271]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[271], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_DCACHE_DATA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[272]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[272], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_STORE_SHORT_OE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[273]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[273], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_STORE_WORD_OE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[274]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[274], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_ICACHE_TAG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[275]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[275], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_ICACHE_DATA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[276]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[276], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_NCSTORE_BYTE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[277]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[277], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_NCSTORE_SHORT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[278]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[278], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_NCSTORE_WORD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[279]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[279], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_RESET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[280]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[280], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_SCACHE_DATA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[281]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[281], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_NCSTORE_SHORT_OE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[282]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[282], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_NCSTORE_WORD_OE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[283]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[283], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_ZERO_LINE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[284]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[284], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[285]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[285], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[286]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[286], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[287]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[287], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[288]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[288], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_4_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[289]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[289], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_5_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[290]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[290], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_6_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[291]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[291], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_7_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[292]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[292], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_8_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[293]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[293], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_9_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[294]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[294], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_10_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[295]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[295], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_11_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[296]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[296], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_12_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[297]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[297], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_13_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[298]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[298], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_14_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[299]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[299], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_15_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[300]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[300], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_16_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[301]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[301], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_17_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[302]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[302], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_18_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[303]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[303], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_19_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[304]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[304], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_20_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[305]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[305], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_21_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[306]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[306], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_22_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[307]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[307], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_23_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[308]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[308], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_24_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[309]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[309], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_25_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[310]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[310], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_26_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[311]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[311], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_27_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[312]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[312], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_28_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[313]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[313], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_29_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[314]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[314], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_30_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[315]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[315], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_READ_REG_31_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[316]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[316], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[317]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[317], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[318]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[318], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[319]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[319], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[320]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[320], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_4_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[321]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[321], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_5_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[322]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[322], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_6_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[323]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[323], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_7_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[324]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[324], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_8_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[325]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[325], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_9_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[326]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[326], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_10_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[327]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[327], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_11_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[328]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[328], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_12_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[329]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[329], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_13_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[330]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[330], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_14_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[331]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[331], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_15_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[332]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[332], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_16_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[333]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[333], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_17_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[334]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[334], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_18_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[335]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[335], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_19_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[336]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[336], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_20_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[337]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[337], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_21_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[338]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[338], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_22_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[339]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[339], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_23_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[340]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[340], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_24_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[341]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[341], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_25_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[342]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[342], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_26_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[343]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[343], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_27_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[344]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[344], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_28_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[345]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[345], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_29_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[346]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[346], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_30_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[347]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[347], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode;", "public static final")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode PRIV_WRITE_REG_31_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[348]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[348], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode$Set;", "public final")]
	public Dova.JDK.com.sun.tools.classfile.Opcode.Set set__Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[349]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[349], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public final")]
	public int opcode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[350]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[350], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$Kind;", "public final")]
	public Dova.JDK.com.sun.tools.classfile.Instruction.Kind kind_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[351]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.Kind>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[351], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/tools/classfile/Opcode;", "private static final")]
	public static JavaArray<Dova.JDK.com.sun.tools.classfile.Opcode> stdOpcodes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[352]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.Opcode>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[352], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/tools/classfile/Opcode;", "private static final")]
	public static JavaArray<Dova.JDK.com.sun.tools.classfile.Opcode> wideOpcodes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[353]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.Opcode>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[353], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/tools/classfile/Opcode;", "private static final")]
	public static JavaArray<Dova.JDK.com.sun.tools.classfile.Opcode> nonPrivOpcodes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[354]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.Opcode>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[354], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/tools/classfile/Opcode;", "private static final")]
	public static JavaArray<Dova.JDK.com.sun.tools.classfile.Opcode> privOpcodes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[355]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.Opcode>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[355], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int WIDE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[356]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[356], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int NONPRIV_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[357]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[357], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int PRIV_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[358]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[358], value);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/tools/classfile/Opcode;", "private static final")]
	public static JavaArray<Dova.JDK.com.sun.tools.classfile.Opcode> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[359]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.Opcode>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[359], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Opcode(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILcom/sun/tools/classfile/Opcode$Set;I)V", "private")]
	public Opcode(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.com.sun.tools.classfile.Opcode.Set arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;IILcom/sun/tools/classfile/Instruction$Kind;)V", "private")]
	public Opcode(Dova.JDK.java.lang.String arg0, int arg1, int arg2, Dova.JDK.com.sun.tools.classfile.Instruction.Kind arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;II)V", "private")]
	public Opcode(Dova.JDK.java.lang.String arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILcom/sun/tools/classfile/Opcode$Set;ILcom/sun/tools/classfile/Instruction$Kind;)V", "private")]
	public Opcode(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.com.sun.tools.classfile.Opcode.Set arg2, int arg3, Dova.JDK.com.sun.tools.classfile.Instruction.Kind arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/Opcode;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(II)Lcom/sun/tools/classfile/Opcode;", "public static")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode get(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/tools/classfile/Opcode;", "public static")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode get(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
	}

	[JniSignatureAttribute("()[Lcom/sun/tools/classfile/Opcode;", "public static")]
	public static JavaArray<Dova.JDK.com.sun.tools.classfile.Opcode> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.Opcode>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/classfile/Opcode;", "public static")]
	public static Dova.JDK.com.sun.tools.classfile.Opcode valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
	}

	[JniSignatureAttribute("()[Lcom/sun/tools/classfile/Opcode;", "private static")]
	public static JavaArray<Dova.JDK.com.sun.tools.classfile.Opcode> _values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.Opcode>>(ret);
	}

	[JniSignatureAttribute("(I)[Lcom/sun/tools/classfile/Opcode;", "private static")]
	public static JavaArray<Dova.JDK.com.sun.tools.classfile.Opcode> getOpcodeBlock(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.Opcode>>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode$Set;", "public static final")]
	public partial class Set
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Set()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/Opcode$Set;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STANDARD", "Lcom/sun/tools/classfile/Opcode$Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PICOJAVA", "Lcom/sun/tools/classfile/Opcode$Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/classfile/Opcode$Set;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/classfile/Opcode$Set;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/classfile/Opcode$Set;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/classfile/Opcode$Set;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode$Set;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Opcode.Set STANDARD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Opcode$Set;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Opcode.Set PICOJAVA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/classfile/Opcode$Set;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.classfile.Opcode.Set> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.Opcode.Set>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Set(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Set(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/Opcode$Set;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/classfile/Opcode$Set;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.classfile.Opcode.Set> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.Opcode.Set>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/classfile/Opcode$Set;", "public static")]
		public static Dova.JDK.com.sun.tools.classfile.Opcode.Set valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode.Set>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/classfile/Opcode$Set;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.classfile.Opcode.Set> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.Opcode.Set>>(ret);
		}
	}
}
