/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.org.apache.bcel.@internal.generic;

[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/EmptyVisitor;", "public abstract")]
public partial class EmptyVisitor
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Visitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static EmptyVisitor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/bcel/internal/generic/EmptyVisitor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "EmptyVisitor", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitSelect", "(Lcom/sun/org/apache/bcel/internal/generic/Select;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitNOP", "(Lcom/sun/org/apache/bcel/internal/generic/NOP;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitStackProducer", "(Lcom/sun/org/apache/bcel/internal/generic/StackProducer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitPushInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/PushInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitTypedInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/TypedInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitACONST_NULL", "(Lcom/sun/org/apache/bcel/internal/generic/ACONST_NULL;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitConstantPushInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/ConstantPushInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitICONST", "(Lcom/sun/org/apache/bcel/internal/generic/ICONST;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLCONST", "(Lcom/sun/org/apache/bcel/internal/generic/LCONST;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitFCONST", "(Lcom/sun/org/apache/bcel/internal/generic/FCONST;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDCONST", "(Lcom/sun/org/apache/bcel/internal/generic/DCONST;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitExceptionThrower", "(Lcom/sun/org/apache/bcel/internal/generic/ExceptionThrower;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitArrayInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/ArrayInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIALOAD", "(Lcom/sun/org/apache/bcel/internal/generic/IALOAD;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLALOAD", "(Lcom/sun/org/apache/bcel/internal/generic/LALOAD;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitFALOAD", "(Lcom/sun/org/apache/bcel/internal/generic/FALOAD;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitFieldInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/FieldInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitInvokeInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/InvokeInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitAllocationInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/AllocationInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLDC", "(Lcom/sun/org/apache/bcel/internal/generic/LDC;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLDC2_W", "(Lcom/sun/org/apache/bcel/internal/generic/LDC2_W;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitINSTANCEOF", "(Lcom/sun/org/apache/bcel/internal/generic/INSTANCEOF;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitCHECKCAST", "(Lcom/sun/org/apache/bcel/internal/generic/CHECKCAST;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitBranchInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/BranchInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitRET", "(Lcom/sun/org/apache/bcel/internal/generic/RET;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLoadClass", "(Lcom/sun/org/apache/bcel/internal/generic/LoadClass;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIfInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/IfInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitJsrInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/JsrInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitGotoInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/GotoInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitCPInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/CPInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitFieldOrMethod", "(Lcom/sun/org/apache/bcel/internal/generic/FieldOrMethod;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitVariableLengthInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/VariableLengthInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitGETSTATIC", "(Lcom/sun/org/apache/bcel/internal/generic/GETSTATIC;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIF_ICMPLT", "(Lcom/sun/org/apache/bcel/internal/generic/IF_ICMPLT;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIFLT", "(Lcom/sun/org/apache/bcel/internal/generic/IFLT;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLSTORE", "(Lcom/sun/org/apache/bcel/internal/generic/LSTORE;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitINVOKESTATIC", "(Lcom/sun/org/apache/bcel/internal/generic/INVOKESTATIC;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIFGE", "(Lcom/sun/org/apache/bcel/internal/generic/IFGE;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitINVOKESPECIAL", "(Lcom/sun/org/apache/bcel/internal/generic/INVOKESPECIAL;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitPUTFIELD", "(Lcom/sun/org/apache/bcel/internal/generic/PUTFIELD;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDLOAD", "(Lcom/sun/org/apache/bcel/internal/generic/DLOAD;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitNEW", "(Lcom/sun/org/apache/bcel/internal/generic/NEW;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIFNULL", "(Lcom/sun/org/apache/bcel/internal/generic/IFNULL;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitTABLESWITCH", "(Lcom/sun/org/apache/bcel/internal/generic/TABLESWITCH;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIINC", "(Lcom/sun/org/apache/bcel/internal/generic/IINC;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitFSTORE", "(Lcom/sun/org/apache/bcel/internal/generic/FSTORE;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIF_ICMPGE", "(Lcom/sun/org/apache/bcel/internal/generic/IF_ICMPGE;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitBIPUSH", "(Lcom/sun/org/apache/bcel/internal/generic/BIPUSH;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDSTORE", "(Lcom/sun/org/apache/bcel/internal/generic/DSTORE;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLLOAD", "(Lcom/sun/org/apache/bcel/internal/generic/LLOAD;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitJSR", "(Lcom/sun/org/apache/bcel/internal/generic/JSR;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitSIPUSH", "(Lcom/sun/org/apache/bcel/internal/generic/SIPUSH;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIF_ICMPGT", "(Lcom/sun/org/apache/bcel/internal/generic/IF_ICMPGT;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIF_ACMPNE", "(Lcom/sun/org/apache/bcel/internal/generic/IF_ACMPNE;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIFEQ", "(Lcom/sun/org/apache/bcel/internal/generic/IFEQ;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitNEWARRAY", "(Lcom/sun/org/apache/bcel/internal/generic/NEWARRAY;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitINVOKEINTERFACE", "(Lcom/sun/org/apache/bcel/internal/generic/INVOKEINTERFACE;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitJSR_W", "(Lcom/sun/org/apache/bcel/internal/generic/JSR_W;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitMULTIANEWARRAY", "(Lcom/sun/org/apache/bcel/internal/generic/MULTIANEWARRAY;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIFNONNULL", "(Lcom/sun/org/apache/bcel/internal/generic/IFNONNULL;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIFNE", "(Lcom/sun/org/apache/bcel/internal/generic/IFNE;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIF_ICMPLE", "(Lcom/sun/org/apache/bcel/internal/generic/IF_ICMPLE;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitGETFIELD", "(Lcom/sun/org/apache/bcel/internal/generic/GETFIELD;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIFLE", "(Lcom/sun/org/apache/bcel/internal/generic/IFLE;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIF_ACMPEQ", "(Lcom/sun/org/apache/bcel/internal/generic/IF_ACMPEQ;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIMPDEP1", "(Lcom/sun/org/apache/bcel/internal/generic/IMPDEP1;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIMPDEP2", "(Lcom/sun/org/apache/bcel/internal/generic/IMPDEP2;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIFGT", "(Lcom/sun/org/apache/bcel/internal/generic/IFGT;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitINVOKEVIRTUAL", "(Lcom/sun/org/apache/bcel/internal/generic/INVOKEVIRTUAL;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIF_ICMPNE", "(Lcom/sun/org/apache/bcel/internal/generic/IF_ICMPNE;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitFLOAD", "(Lcom/sun/org/apache/bcel/internal/generic/FLOAD;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitPUTSTATIC", "(Lcom/sun/org/apache/bcel/internal/generic/PUTSTATIC;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIF_ICMPEQ", "(Lcom/sun/org/apache/bcel/internal/generic/IF_ICMPEQ;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitGOTO_W", "(Lcom/sun/org/apache/bcel/internal/generic/GOTO_W;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitGOTO", "(Lcom/sun/org/apache/bcel/internal/generic/GOTO;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLOOKUPSWITCH", "(Lcom/sun/org/apache/bcel/internal/generic/LOOKUPSWITCH;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitANEWARRAY", "(Lcom/sun/org/apache/bcel/internal/generic/ANEWARRAY;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitBREAKPOINT", "(Lcom/sun/org/apache/bcel/internal/generic/BREAKPOINT;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitINVOKEDYNAMIC", "(Lcom/sun/org/apache/bcel/internal/generic/INVOKEDYNAMIC;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDALOAD", "(Lcom/sun/org/apache/bcel/internal/generic/DALOAD;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitAALOAD", "(Lcom/sun/org/apache/bcel/internal/generic/AALOAD;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitBALOAD", "(Lcom/sun/org/apache/bcel/internal/generic/BALOAD;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitCALOAD", "(Lcom/sun/org/apache/bcel/internal/generic/CALOAD;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitSALOAD", "(Lcom/sun/org/apache/bcel/internal/generic/SALOAD;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitStackConsumer", "(Lcom/sun/org/apache/bcel/internal/generic/StackConsumer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIASTORE", "(Lcom/sun/org/apache/bcel/internal/generic/IASTORE;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLASTORE", "(Lcom/sun/org/apache/bcel/internal/generic/LASTORE;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitFASTORE", "(Lcom/sun/org/apache/bcel/internal/generic/FASTORE;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDASTORE", "(Lcom/sun/org/apache/bcel/internal/generic/DASTORE;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitAASTORE", "(Lcom/sun/org/apache/bcel/internal/generic/AASTORE;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitBASTORE", "(Lcom/sun/org/apache/bcel/internal/generic/BASTORE;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitCASTORE", "(Lcom/sun/org/apache/bcel/internal/generic/CASTORE;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitSASTORE", "(Lcom/sun/org/apache/bcel/internal/generic/SASTORE;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitPopInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/PopInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitStackInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/StackInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitPOP", "(Lcom/sun/org/apache/bcel/internal/generic/POP;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitPOP2", "(Lcom/sun/org/apache/bcel/internal/generic/POP2;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDUP", "(Lcom/sun/org/apache/bcel/internal/generic/DUP;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDUP_X1", "(Lcom/sun/org/apache/bcel/internal/generic/DUP_X1;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDUP_X2", "(Lcom/sun/org/apache/bcel/internal/generic/DUP_X2;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDUP2", "(Lcom/sun/org/apache/bcel/internal/generic/DUP2;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDUP2_X1", "(Lcom/sun/org/apache/bcel/internal/generic/DUP2_X1;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDUP2_X2", "(Lcom/sun/org/apache/bcel/internal/generic/DUP2_X2;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitSWAP", "(Lcom/sun/org/apache/bcel/internal/generic/SWAP;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitArithmeticInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/ArithmeticInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIADD", "(Lcom/sun/org/apache/bcel/internal/generic/IADD;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLADD", "(Lcom/sun/org/apache/bcel/internal/generic/LADD;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitFADD", "(Lcom/sun/org/apache/bcel/internal/generic/FADD;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDADD", "(Lcom/sun/org/apache/bcel/internal/generic/DADD;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitISUB", "(Lcom/sun/org/apache/bcel/internal/generic/ISUB;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLSUB", "(Lcom/sun/org/apache/bcel/internal/generic/LSUB;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitFSUB", "(Lcom/sun/org/apache/bcel/internal/generic/FSUB;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDSUB", "(Lcom/sun/org/apache/bcel/internal/generic/DSUB;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIMUL", "(Lcom/sun/org/apache/bcel/internal/generic/IMUL;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLMUL", "(Lcom/sun/org/apache/bcel/internal/generic/LMUL;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitFMUL", "(Lcom/sun/org/apache/bcel/internal/generic/FMUL;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDMUL", "(Lcom/sun/org/apache/bcel/internal/generic/DMUL;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIDIV", "(Lcom/sun/org/apache/bcel/internal/generic/IDIV;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLDIV", "(Lcom/sun/org/apache/bcel/internal/generic/LDIV;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitFDIV", "(Lcom/sun/org/apache/bcel/internal/generic/FDIV;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDDIV", "(Lcom/sun/org/apache/bcel/internal/generic/DDIV;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIREM", "(Lcom/sun/org/apache/bcel/internal/generic/IREM;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLREM", "(Lcom/sun/org/apache/bcel/internal/generic/LREM;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitFREM", "(Lcom/sun/org/apache/bcel/internal/generic/FREM;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDREM", "(Lcom/sun/org/apache/bcel/internal/generic/DREM;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitINEG", "(Lcom/sun/org/apache/bcel/internal/generic/INEG;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLNEG", "(Lcom/sun/org/apache/bcel/internal/generic/LNEG;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitFNEG", "(Lcom/sun/org/apache/bcel/internal/generic/FNEG;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDNEG", "(Lcom/sun/org/apache/bcel/internal/generic/DNEG;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitISHL", "(Lcom/sun/org/apache/bcel/internal/generic/ISHL;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLSHL", "(Lcom/sun/org/apache/bcel/internal/generic/LSHL;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitISHR", "(Lcom/sun/org/apache/bcel/internal/generic/ISHR;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLSHR", "(Lcom/sun/org/apache/bcel/internal/generic/LSHR;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIUSHR", "(Lcom/sun/org/apache/bcel/internal/generic/IUSHR;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLUSHR", "(Lcom/sun/org/apache/bcel/internal/generic/LUSHR;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIAND", "(Lcom/sun/org/apache/bcel/internal/generic/IAND;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLAND", "(Lcom/sun/org/apache/bcel/internal/generic/LAND;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIOR", "(Lcom/sun/org/apache/bcel/internal/generic/IOR;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLOR", "(Lcom/sun/org/apache/bcel/internal/generic/LOR;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIXOR", "(Lcom/sun/org/apache/bcel/internal/generic/IXOR;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLXOR", "(Lcom/sun/org/apache/bcel/internal/generic/LXOR;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitConversionInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/ConversionInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitI2L", "(Lcom/sun/org/apache/bcel/internal/generic/I2L;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitI2F", "(Lcom/sun/org/apache/bcel/internal/generic/I2F;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitI2D", "(Lcom/sun/org/apache/bcel/internal/generic/I2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitL2I", "(Lcom/sun/org/apache/bcel/internal/generic/L2I;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitL2F", "(Lcom/sun/org/apache/bcel/internal/generic/L2F;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitL2D", "(Lcom/sun/org/apache/bcel/internal/generic/L2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitF2I", "(Lcom/sun/org/apache/bcel/internal/generic/F2I;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitF2L", "(Lcom/sun/org/apache/bcel/internal/generic/F2L;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitF2D", "(Lcom/sun/org/apache/bcel/internal/generic/F2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitD2I", "(Lcom/sun/org/apache/bcel/internal/generic/D2I;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitD2L", "(Lcom/sun/org/apache/bcel/internal/generic/D2L;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitD2F", "(Lcom/sun/org/apache/bcel/internal/generic/D2F;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitI2B", "(Lcom/sun/org/apache/bcel/internal/generic/I2B;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitI2C", "(Lcom/sun/org/apache/bcel/internal/generic/I2C;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitI2S", "(Lcom/sun/org/apache/bcel/internal/generic/I2S;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLCMP", "(Lcom/sun/org/apache/bcel/internal/generic/LCMP;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitFCMPL", "(Lcom/sun/org/apache/bcel/internal/generic/FCMPL;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitFCMPG", "(Lcom/sun/org/apache/bcel/internal/generic/FCMPG;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDCMPL", "(Lcom/sun/org/apache/bcel/internal/generic/DCMPL;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDCMPG", "(Lcom/sun/org/apache/bcel/internal/generic/DCMPG;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitReturnInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/ReturnInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIRETURN", "(Lcom/sun/org/apache/bcel/internal/generic/IRETURN;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLRETURN", "(Lcom/sun/org/apache/bcel/internal/generic/LRETURN;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitFRETURN", "(Lcom/sun/org/apache/bcel/internal/generic/FRETURN;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDRETURN", "(Lcom/sun/org/apache/bcel/internal/generic/DRETURN;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitARETURN", "(Lcom/sun/org/apache/bcel/internal/generic/ARETURN;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitRETURN", "(Lcom/sun/org/apache/bcel/internal/generic/RETURN;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitARRAYLENGTH", "(Lcom/sun/org/apache/bcel/internal/generic/ARRAYLENGTH;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitUnconditionalBranch", "(Lcom/sun/org/apache/bcel/internal/generic/UnconditionalBranch;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitATHROW", "(Lcom/sun/org/apache/bcel/internal/generic/ATHROW;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitMONITORENTER", "(Lcom/sun/org/apache/bcel/internal/generic/MONITORENTER;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitMONITOREXIT", "(Lcom/sun/org/apache/bcel/internal/generic/MONITOREXIT;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitALOAD", "(Lcom/sun/org/apache/bcel/internal/generic/ALOAD;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLocalVariableInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/LocalVariableInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLoadInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/LoadInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitILOAD", "(Lcom/sun/org/apache/bcel/internal/generic/ILOAD;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitASTORE", "(Lcom/sun/org/apache/bcel/internal/generic/ASTORE;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitStoreInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/StoreInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitISTORE", "(Lcom/sun/org/apache/bcel/internal/generic/ISTORE;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public EmptyVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public EmptyVisitor() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/bcel/internal/generic/EmptyVisitor;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/Select;)V", "public")]
	public void visitSelect(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Select arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/NOP;)V", "public")]
	public void visitNOP(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.NOP arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/StackProducer;)V", "public")]
	public void visitStackProducer(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.StackProducer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/PushInstruction;)V", "public")]
	public void visitPushInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.PushInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/TypedInstruction;)V", "public")]
	public void visitTypedInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.TypedInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ACONST_NULL;)V", "public")]
	public void visitACONST_NULL(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ACONST_NULL arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ConstantPushInstruction;)V", "public")]
	public void visitConstantPushInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPushInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ICONST;)V", "public")]
	public void visitICONST(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ICONST arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LCONST;)V", "public")]
	public void visitLCONST(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LCONST arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/FCONST;)V", "public")]
	public void visitFCONST(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.FCONST arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/DCONST;)V", "public")]
	public void visitDCONST(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.DCONST arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ExceptionThrower;)V", "public")]
	public void visitExceptionThrower(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ExceptionThrower arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ArrayInstruction;)V", "public")]
	public void visitArrayInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ArrayInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IALOAD;)V", "public")]
	public void visitIALOAD(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IALOAD arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LALOAD;)V", "public")]
	public void visitLALOAD(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LALOAD arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/FALOAD;)V", "public")]
	public void visitFALOAD(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.FALOAD arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/FieldInstruction;)V", "public")]
	public void visitFieldInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.FieldInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/InvokeInstruction;)V", "public")]
	public void visitInvokeInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InvokeInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/AllocationInstruction;)V", "public")]
	public void visitAllocationInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.AllocationInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LDC;)V", "public")]
	public void visitLDC(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LDC arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LDC2_W;)V", "public")]
	public void visitLDC2_W(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LDC2_W arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/INSTANCEOF;)V", "public")]
	public void visitINSTANCEOF(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.INSTANCEOF arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/CHECKCAST;)V", "public")]
	public void visitCHECKCAST(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.CHECKCAST arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/BranchInstruction;)V", "public")]
	public void visitBranchInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.BranchInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/RET;)V", "public")]
	public void visitRET(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.RET arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LoadClass;)V", "public")]
	public void visitLoadClass(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LoadClass arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IfInstruction;)V", "public")]
	public void visitIfInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IfInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/JsrInstruction;)V", "public")]
	public void visitJsrInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.JsrInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/GotoInstruction;)V", "public")]
	public void visitGotoInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.GotoInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/CPInstruction;)V", "public")]
	public void visitCPInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.CPInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/FieldOrMethod;)V", "public")]
	public void visitFieldOrMethod(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.FieldOrMethod arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/VariableLengthInstruction;)V", "public")]
	public void visitVariableLengthInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.VariableLengthInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/GETSTATIC;)V", "public")]
	public void visitGETSTATIC(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.GETSTATIC arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IF_ICMPLT;)V", "public")]
	public void visitIF_ICMPLT(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IF_ICMPLT arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IFLT;)V", "public")]
	public void visitIFLT(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IFLT arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LSTORE;)V", "public")]
	public void visitLSTORE(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LSTORE arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/INVOKESTATIC;)V", "public")]
	public void visitINVOKESTATIC(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.INVOKESTATIC arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IFGE;)V", "public")]
	public void visitIFGE(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IFGE arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/INVOKESPECIAL;)V", "public")]
	public void visitINVOKESPECIAL(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.INVOKESPECIAL arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/PUTFIELD;)V", "public")]
	public void visitPUTFIELD(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.PUTFIELD arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/DLOAD;)V", "public")]
	public void visitDLOAD(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.DLOAD arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/NEW;)V", "public")]
	public void visitNEW(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.NEW arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IFNULL;)V", "public")]
	public void visitIFNULL(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IFNULL arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/TABLESWITCH;)V", "public")]
	public void visitTABLESWITCH(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.TABLESWITCH arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IINC;)V", "public")]
	public void visitIINC(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IINC arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/FSTORE;)V", "public")]
	public void visitFSTORE(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.FSTORE arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IF_ICMPGE;)V", "public")]
	public void visitIF_ICMPGE(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IF_ICMPGE arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/BIPUSH;)V", "public")]
	public void visitBIPUSH(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.BIPUSH arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/DSTORE;)V", "public")]
	public void visitDSTORE(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.DSTORE arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LLOAD;)V", "public")]
	public void visitLLOAD(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LLOAD arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/JSR;)V", "public")]
	public void visitJSR(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.JSR arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/SIPUSH;)V", "public")]
	public void visitSIPUSH(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.SIPUSH arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IF_ICMPGT;)V", "public")]
	public void visitIF_ICMPGT(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IF_ICMPGT arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IF_ACMPNE;)V", "public")]
	public void visitIF_ACMPNE(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IF_ACMPNE arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IFEQ;)V", "public")]
	public void visitIFEQ(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IFEQ arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/NEWARRAY;)V", "public")]
	public void visitNEWARRAY(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.NEWARRAY arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/INVOKEINTERFACE;)V", "public")]
	public void visitINVOKEINTERFACE(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.INVOKEINTERFACE arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/JSR_W;)V", "public")]
	public void visitJSR_W(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.JSR_W arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/MULTIANEWARRAY;)V", "public")]
	public void visitMULTIANEWARRAY(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.MULTIANEWARRAY arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IFNONNULL;)V", "public")]
	public void visitIFNONNULL(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IFNONNULL arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IFNE;)V", "public")]
	public void visitIFNE(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IFNE arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IF_ICMPLE;)V", "public")]
	public void visitIF_ICMPLE(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IF_ICMPLE arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/GETFIELD;)V", "public")]
	public void visitGETFIELD(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.GETFIELD arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IFLE;)V", "public")]
	public void visitIFLE(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IFLE arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IF_ACMPEQ;)V", "public")]
	public void visitIF_ACMPEQ(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IF_ACMPEQ arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[64], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IMPDEP1;)V", "public")]
	public void visitIMPDEP1(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IMPDEP1 arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IMPDEP2;)V", "public")]
	public void visitIMPDEP2(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IMPDEP2 arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[66], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IFGT;)V", "public")]
	public void visitIFGT(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IFGT arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[67], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/INVOKEVIRTUAL;)V", "public")]
	public void visitINVOKEVIRTUAL(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.INVOKEVIRTUAL arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[68], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IF_ICMPNE;)V", "public")]
	public void visitIF_ICMPNE(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IF_ICMPNE arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[69], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/FLOAD;)V", "public")]
	public void visitFLOAD(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.FLOAD arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[70], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/PUTSTATIC;)V", "public")]
	public void visitPUTSTATIC(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.PUTSTATIC arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[71], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IF_ICMPEQ;)V", "public")]
	public void visitIF_ICMPEQ(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IF_ICMPEQ arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[72], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/GOTO_W;)V", "public")]
	public void visitGOTO_W(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.GOTO_W arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[73], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/GOTO;)V", "public")]
	public void visitGOTO(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.GOTO arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[74], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LOOKUPSWITCH;)V", "public")]
	public void visitLOOKUPSWITCH(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LOOKUPSWITCH arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[75], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ANEWARRAY;)V", "public")]
	public void visitANEWARRAY(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ANEWARRAY arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[76], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/BREAKPOINT;)V", "public")]
	public void visitBREAKPOINT(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.BREAKPOINT arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[77], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/INVOKEDYNAMIC;)V", "public")]
	public void visitINVOKEDYNAMIC(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.INVOKEDYNAMIC arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[78], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/DALOAD;)V", "public")]
	public void visitDALOAD(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.DALOAD arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[79], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/AALOAD;)V", "public")]
	public void visitAALOAD(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.AALOAD arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[80], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/BALOAD;)V", "public")]
	public void visitBALOAD(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.BALOAD arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[81], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/CALOAD;)V", "public")]
	public void visitCALOAD(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.CALOAD arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[82], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/SALOAD;)V", "public")]
	public void visitSALOAD(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.SALOAD arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[83], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/StackConsumer;)V", "public")]
	public void visitStackConsumer(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.StackConsumer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[84], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IASTORE;)V", "public")]
	public void visitIASTORE(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IASTORE arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[85], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LASTORE;)V", "public")]
	public void visitLASTORE(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LASTORE arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[86], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/FASTORE;)V", "public")]
	public void visitFASTORE(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.FASTORE arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[87], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/DASTORE;)V", "public")]
	public void visitDASTORE(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.DASTORE arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[88], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/AASTORE;)V", "public")]
	public void visitAASTORE(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.AASTORE arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[89], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/BASTORE;)V", "public")]
	public void visitBASTORE(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.BASTORE arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[90], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/CASTORE;)V", "public")]
	public void visitCASTORE(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.CASTORE arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[91], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/SASTORE;)V", "public")]
	public void visitSASTORE(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.SASTORE arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[92], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/PopInstruction;)V", "public")]
	public void visitPopInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.PopInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[93], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/StackInstruction;)V", "public")]
	public void visitStackInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.StackInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[94], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/POP;)V", "public")]
	public void visitPOP(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.POP arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[95], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/POP2;)V", "public")]
	public void visitPOP2(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.POP2 arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[96], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/DUP;)V", "public")]
	public void visitDUP(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.DUP arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[97], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/DUP_X1;)V", "public")]
	public void visitDUP_X1(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.DUP_X1 arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[98], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/DUP_X2;)V", "public")]
	public void visitDUP_X2(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.DUP_X2 arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[99], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/DUP2;)V", "public")]
	public void visitDUP2(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.DUP2 arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[100], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/DUP2_X1;)V", "public")]
	public void visitDUP2_X1(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.DUP2_X1 arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[101], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/DUP2_X2;)V", "public")]
	public void visitDUP2_X2(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.DUP2_X2 arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[102], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/SWAP;)V", "public")]
	public void visitSWAP(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.SWAP arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[103], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ArithmeticInstruction;)V", "public")]
	public void visitArithmeticInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ArithmeticInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[104], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IADD;)V", "public")]
	public void visitIADD(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IADD arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[105], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LADD;)V", "public")]
	public void visitLADD(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LADD arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[106], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/FADD;)V", "public")]
	public void visitFADD(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.FADD arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[107], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/DADD;)V", "public")]
	public void visitDADD(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.DADD arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[108], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ISUB;)V", "public")]
	public void visitISUB(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ISUB arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[109], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LSUB;)V", "public")]
	public void visitLSUB(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LSUB arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[110], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/FSUB;)V", "public")]
	public void visitFSUB(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.FSUB arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[111], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/DSUB;)V", "public")]
	public void visitDSUB(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.DSUB arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[112], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IMUL;)V", "public")]
	public void visitIMUL(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IMUL arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[113], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LMUL;)V", "public")]
	public void visitLMUL(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LMUL arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[114], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/FMUL;)V", "public")]
	public void visitFMUL(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.FMUL arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[115], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/DMUL;)V", "public")]
	public void visitDMUL(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.DMUL arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[116], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IDIV;)V", "public")]
	public void visitIDIV(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IDIV arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[117], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LDIV;)V", "public")]
	public void visitLDIV(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LDIV arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[118], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/FDIV;)V", "public")]
	public void visitFDIV(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.FDIV arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[119], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/DDIV;)V", "public")]
	public void visitDDIV(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.DDIV arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[120], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IREM;)V", "public")]
	public void visitIREM(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IREM arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[121], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LREM;)V", "public")]
	public void visitLREM(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LREM arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[122], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/FREM;)V", "public")]
	public void visitFREM(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.FREM arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[123], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/DREM;)V", "public")]
	public void visitDREM(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.DREM arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[124], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/INEG;)V", "public")]
	public void visitINEG(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.INEG arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[125], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LNEG;)V", "public")]
	public void visitLNEG(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LNEG arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[126], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/FNEG;)V", "public")]
	public void visitFNEG(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.FNEG arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[127], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/DNEG;)V", "public")]
	public void visitDNEG(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.DNEG arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[128], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ISHL;)V", "public")]
	public void visitISHL(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ISHL arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[129], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LSHL;)V", "public")]
	public void visitLSHL(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LSHL arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[130], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ISHR;)V", "public")]
	public void visitISHR(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ISHR arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[131], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LSHR;)V", "public")]
	public void visitLSHR(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LSHR arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[132], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IUSHR;)V", "public")]
	public void visitIUSHR(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IUSHR arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[133], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LUSHR;)V", "public")]
	public void visitLUSHR(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LUSHR arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[134], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IAND;)V", "public")]
	public void visitIAND(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IAND arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[135], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LAND;)V", "public")]
	public void visitLAND(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LAND arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[136], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IOR;)V", "public")]
	public void visitIOR(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IOR arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[137], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LOR;)V", "public")]
	public void visitLOR(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LOR arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[138], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IXOR;)V", "public")]
	public void visitIXOR(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IXOR arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[139], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LXOR;)V", "public")]
	public void visitLXOR(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LXOR arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[140], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ConversionInstruction;)V", "public")]
	public void visitConversionInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConversionInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[141], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/I2L;)V", "public")]
	public void visitI2L(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.I2L arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[142], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/I2F;)V", "public")]
	public void visitI2F(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.I2F arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[143], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/I2D;)V", "public")]
	public void visitI2D(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.I2D arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[144], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/L2I;)V", "public")]
	public void visitL2I(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.L2I arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[145], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/L2F;)V", "public")]
	public void visitL2F(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.L2F arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[146], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/L2D;)V", "public")]
	public void visitL2D(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.L2D arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[147], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/F2I;)V", "public")]
	public void visitF2I(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.F2I arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[148], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/F2L;)V", "public")]
	public void visitF2L(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.F2L arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[149], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/F2D;)V", "public")]
	public void visitF2D(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.F2D arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[150], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/D2I;)V", "public")]
	public void visitD2I(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.D2I arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[151], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/D2L;)V", "public")]
	public void visitD2L(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.D2L arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[152], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/D2F;)V", "public")]
	public void visitD2F(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.D2F arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[153], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/I2B;)V", "public")]
	public void visitI2B(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.I2B arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[154], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/I2C;)V", "public")]
	public void visitI2C(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.I2C arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[155], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/I2S;)V", "public")]
	public void visitI2S(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.I2S arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[156], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LCMP;)V", "public")]
	public void visitLCMP(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LCMP arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[157], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/FCMPL;)V", "public")]
	public void visitFCMPL(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.FCMPL arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[158], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/FCMPG;)V", "public")]
	public void visitFCMPG(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.FCMPG arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[159], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/DCMPL;)V", "public")]
	public void visitDCMPL(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.DCMPL arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[160], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/DCMPG;)V", "public")]
	public void visitDCMPG(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.DCMPG arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[161], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ReturnInstruction;)V", "public")]
	public void visitReturnInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ReturnInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[162], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/IRETURN;)V", "public")]
	public void visitIRETURN(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.IRETURN arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[163], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LRETURN;)V", "public")]
	public void visitLRETURN(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LRETURN arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[164], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/FRETURN;)V", "public")]
	public void visitFRETURN(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.FRETURN arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[165], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/DRETURN;)V", "public")]
	public void visitDRETURN(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.DRETURN arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[166], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ARETURN;)V", "public")]
	public void visitARETURN(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ARETURN arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[167], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/RETURN;)V", "public")]
	public void visitRETURN(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.RETURN arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[168], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ARRAYLENGTH;)V", "public")]
	public void visitARRAYLENGTH(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ARRAYLENGTH arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[169], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/UnconditionalBranch;)V", "public")]
	public void visitUnconditionalBranch(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.UnconditionalBranch arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[170], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ATHROW;)V", "public")]
	public void visitATHROW(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ATHROW arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[171], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/MONITORENTER;)V", "public")]
	public void visitMONITORENTER(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.MONITORENTER arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[172], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/MONITOREXIT;)V", "public")]
	public void visitMONITOREXIT(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.MONITOREXIT arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[173], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ALOAD;)V", "public")]
	public void visitALOAD(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ALOAD arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[174], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LocalVariableInstruction;)V", "public")]
	public void visitLocalVariableInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LocalVariableInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[175], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LoadInstruction;)V", "public")]
	public void visitLoadInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LoadInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[176], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ILOAD;)V", "public")]
	public void visitILOAD(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ILOAD arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[177], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ASTORE;)V", "public")]
	public void visitASTORE(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ASTORE arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[178], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/StoreInstruction;)V", "public")]
	public void visitStoreInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.StoreInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[179], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ISTORE;)V", "public")]
	public void visitISTORE(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ISTORE arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[180], arg0);
	}
}
