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

namespace Dova.JDK.jdk.@internal.org.objectweb.asm.commons;

[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/commons/InstructionAdapter;", "public")]
public partial class InstructionAdapter
	: Dova.JDK.jdk.@internal.org.objectweb.asm.MethodVisitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static InstructionAdapter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/objectweb/asm/commons/InstructionAdapter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OBJECT_TYPE", "Ljdk/internal/org/objectweb/asm/Type;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/org/objectweb/asm/MethodVisitor;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjdk/internal/org/objectweb/asm/MethodVisitor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Ljdk/internal/org/objectweb/asm/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cast", "(Ljdk/internal/org/objectweb/asm/Type;Ljdk/internal/org/objectweb/asm/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "cast", "(Ljdk/internal/org/objectweb/asm/MethodVisitor;Ljdk/internal/org/objectweb/asm/Type;Ljdk/internal/org/objectweb/asm/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "(ILjdk/internal/org/objectweb/asm/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "store", "(ILjdk/internal/org/objectweb/asm/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ret", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mark", "(Ljdk/internal/org/objectweb/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rem", "(Ljdk/internal/org/objectweb/asm/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "swap", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "or", "(Ljdk/internal/org/objectweb/asm/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pop", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sub", "(Ljdk/internal/org/objectweb/asm/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFieldInsn", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInsn", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitVarInsn", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodInsn", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeInsn", "(ILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIntInsn", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLdcInsn", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iconst", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInvokeDynamicInsn", "(Ljava/lang/String;Ljava/lang/String;Ljdk/internal/org/objectweb/asm/Handle;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitJumpInsn", "(ILjdk/internal/org/objectweb/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLabel", "(Ljdk/internal/org/objectweb/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIincInsn", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTableSwitchInsn", "(IILjdk/internal/org/objectweb/asm/Label;[Ljdk/internal/org/objectweb/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLookupSwitchInsn", "(Ljdk/internal/org/objectweb/asm/Label;[I[Ljdk/internal/org/objectweb/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMultiANewArrayInsn", "(Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "aload", "(Ljdk/internal/org/objectweb/asm/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "and", "(Ljdk/internal/org/objectweb/asm/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "xor", "(Ljdk/internal/org/objectweb/asm/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "div", "(Ljdk/internal/org/objectweb/asm/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "neg", "(Ljdk/internal/org/objectweb/asm/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mul", "(Ljdk/internal/org/objectweb/asm/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pop2", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup2", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "astore", "(Ljdk/internal/org/objectweb/asm/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nop", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "jsr", "(Ljdk/internal/org/objectweb/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tableswitch", "(IILjdk/internal/org/objectweb/asm/Label;[Ljdk/internal/org/objectweb/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupswitch", "(Ljdk/internal/org/objectweb/asm/Label;[I[Ljdk/internal/org/objectweb/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "areturn", "(Ljdk/internal/org/objectweb/asm/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getstatic", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putstatic", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getfield", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putfield", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokevirtual", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokevirtual", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokespecial", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokespecial", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokestatic", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokestatic", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeinterface", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokedynamic", "(Ljava/lang/String;Ljava/lang/String;Ljdk/internal/org/objectweb/asm/Handle;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newarray", "(Ljdk/internal/org/objectweb/asm/MethodVisitor;Ljdk/internal/org/objectweb/asm/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newarray", "(Ljdk/internal/org/objectweb/asm/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "arraylength", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "athrow", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkcast", "(Ljdk/internal/org/objectweb/asm/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "monitorenter", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "monitorexit", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "multianewarray", "(Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iinc", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ifeq", "(Ljdk/internal/org/objectweb/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ifne", "(Ljdk/internal/org/objectweb/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iflt", "(Ljdk/internal/org/objectweb/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ifge", "(Ljdk/internal/org/objectweb/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ifgt", "(Ljdk/internal/org/objectweb/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ifle", "(Ljdk/internal/org/objectweb/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "aconst", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lconst", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fconst", "(F)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dconst", "(D)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dupX1", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dupX2", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup2X1", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup2X2", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shl", "(Ljdk/internal/org/objectweb/asm/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shr", "(Ljdk/internal/org/objectweb/asm/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ushr", "(Ljdk/internal/org/objectweb/asm/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cmpl", "(Ljdk/internal/org/objectweb/asm/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cmpg", "(Ljdk/internal/org/objectweb/asm/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "anew", "(Ljdk/internal/org/objectweb/asm/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ificmpeq", "(Ljdk/internal/org/objectweb/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ificmpne", "(Ljdk/internal/org/objectweb/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ificmplt", "(Ljdk/internal/org/objectweb/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ificmpge", "(Ljdk/internal/org/objectweb/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ificmpgt", "(Ljdk/internal/org/objectweb/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ificmple", "(Ljdk/internal/org/objectweb/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ifacmpeq", "(Ljdk/internal/org/objectweb/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ifacmpne", "(Ljdk/internal/org/objectweb/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "goTo", "(Ljdk/internal/org/objectweb/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ifnull", "(Ljdk/internal/org/objectweb/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ifnonnull", "(Ljdk/internal/org/objectweb/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tconst", "(Ljdk/internal/org/objectweb/asm/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hconst", "(Ljdk/internal/org/objectweb/asm/Handle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cconst", "(Ljdk/internal/org/objectweb/asm/ConstantDynamic;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lcmp", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instanceOf", "(Ljdk/internal/org/objectweb/asm/Type;)V"));
	}

	[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/Type;", "public static final")]
	public static Dova.JDK.jdk.@internal.org.objectweb.asm.Type OBJECT_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public InstructionAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/MethodVisitor;)V", "public")]
	public InstructionAdapter(Dova.JDK.jdk.@internal.org.objectweb.asm.MethodVisitor arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(ILjdk/internal/org/objectweb/asm/MethodVisitor;)V", "protected")]
	public InstructionAdapter(int arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.MethodVisitor arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/org/objectweb/asm/commons/InstructionAdapter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)V", "public")]
	public void add(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;Ljdk/internal/org/objectweb/asm/Type;)V", "public")]
	public void cast(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/MethodVisitor;Ljdk/internal/org/objectweb/asm/Type;Ljdk/internal/org/objectweb/asm/Type;)V", "static")]
	public static void cast(Dova.JDK.jdk.@internal.org.objectweb.asm.MethodVisitor arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjdk/internal/org/objectweb/asm/Type;)V", "public")]
	public void load(int arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjdk/internal/org/objectweb/asm/Type;)V", "public")]
	public void store(int arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void ret(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Label;)V", "public")]
	public void mark(Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)V", "public")]
	public void rem(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void swap()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)V", "public")]
	public void or(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void pop()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)V", "public")]
	public void sub(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void visitFieldInsn(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void visitInsn(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void visitVarInsn(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "public")]
	public void visitMethodInsn(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, bool arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(ILjava/lang/String;)V", "public")]
	public void visitTypeInsn(int arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void visitIntInsn(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
	public void visitLdcInsn(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void iconst(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljdk/internal/org/objectweb/asm/Handle;[Ljava/lang/Object;)V", "public transient")]
	public void visitInvokeDynamicInsn(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.Handle arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(ILjdk/internal/org/objectweb/asm/Label;)V", "public")]
	public void visitJumpInsn(int arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Label;)V", "public")]
	public void visitLabel(Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void visitIincInsn(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
	}

	[JniSignatureAttribute("(IILjdk/internal/org/objectweb/asm/Label;[Ljdk/internal/org/objectweb/asm/Label;)V", "public transient")]
	public void visitTableSwitchInsn(int arg0, int arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg2, JavaArray<Dova.JDK.jdk.@internal.org.objectweb.asm.Label> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Label;[I[Ljdk/internal/org/objectweb/asm/Label;)V", "public")]
	public void visitLookupSwitchInsn(Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg0, JavaArray<int> arg1, JavaArray<Dova.JDK.jdk.@internal.org.objectweb.asm.Label> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "public")]
	public void visitMultiANewArrayInsn(Dova.JDK.java.lang.String arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "public")]
	public void dup()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27]);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)V", "public")]
	public void aload(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)V", "public")]
	public void and(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)V", "public")]
	public void xor(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)V", "public")]
	public void div(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)V", "public")]
	public void neg(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)V", "public")]
	public void mul(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void pop2()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void dup2()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35]);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)V", "public")]
	public void astore(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void nop()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37]);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Label;)V", "public")]
	public void jsr(Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("(IILjdk/internal/org/objectweb/asm/Label;[Ljdk/internal/org/objectweb/asm/Label;)V", "public transient")]
	public void tableswitch(int arg0, int arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg2, JavaArray<Dova.JDK.jdk.@internal.org.objectweb.asm.Label> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Label;[I[Ljdk/internal/org/objectweb/asm/Label;)V", "public")]
	public void lookupswitch(Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg0, JavaArray<int> arg1, JavaArray<Dova.JDK.jdk.@internal.org.objectweb.asm.Label> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)V", "public")]
	public void areturn(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void getstatic(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void putstatic(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void getfield(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void putfield(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "public")]
	public void invokevirtual(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void invokevirtual(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void invokespecial(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "public")]
	public void invokespecial(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "public")]
	public void invokestatic(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void invokestatic(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void invokeinterface(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljdk/internal/org/objectweb/asm/Handle;[Ljava/lang/Object;)V", "public")]
	public void invokedynamic(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.Handle arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/MethodVisitor;Ljdk/internal/org/objectweb/asm/Type;)V", "static")]
	public static void newarray(Dova.JDK.jdk.@internal.org.objectweb.asm.MethodVisitor arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[54], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)V", "public")]
	public void newarray(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void arraylength()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void athrow()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[57]);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)V", "public")]
	public void checkcast(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void monitorenter()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[59]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void monitorexit()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[60]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "public")]
	public void multianewarray(Dova.JDK.java.lang.String arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[61], arg0, arg1);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void iinc(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[62], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Label;)V", "public")]
	public void ifeq(Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Label;)V", "public")]
	public void ifne(Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[64], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Label;)V", "public")]
	public void iflt(Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Label;)V", "public")]
	public void ifge(Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[66], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Label;)V", "public")]
	public void ifgt(Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[67], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Label;)V", "public")]
	public void ifle(Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[68], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
	public void aconst(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[69], arg0);
	}

	[JniSignatureAttribute("(J)V", "public")]
	public void lconst(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[70], arg0);
	}

	[JniSignatureAttribute("(F)V", "public")]
	public void fconst(float arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[71], arg0);
	}

	[JniSignatureAttribute("(D)V", "public")]
	public void dconst(double arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[72], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void dupX1()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[73]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void dupX2()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[74]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void dup2X1()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[75]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void dup2X2()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[76]);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)V", "public")]
	public void shl(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[77], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)V", "public")]
	public void shr(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[78], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)V", "public")]
	public void ushr(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[79], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)V", "public")]
	public void cmpl(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[80], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)V", "public")]
	public void cmpg(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[81], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)V", "public")]
	public void anew(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[82], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Label;)V", "public")]
	public void ificmpeq(Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[83], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Label;)V", "public")]
	public void ificmpne(Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[84], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Label;)V", "public")]
	public void ificmplt(Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[85], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Label;)V", "public")]
	public void ificmpge(Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[86], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Label;)V", "public")]
	public void ificmpgt(Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[87], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Label;)V", "public")]
	public void ificmple(Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[88], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Label;)V", "public")]
	public void ifacmpeq(Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[89], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Label;)V", "public")]
	public void ifacmpne(Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[90], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Label;)V", "public")]
	public void goTo(Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[91], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Label;)V", "public")]
	public void ifnull(Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[92], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Label;)V", "public")]
	public void ifnonnull(Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[93], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)V", "public")]
	public void tconst(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[94], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Handle;)V", "public")]
	public void hconst(Dova.JDK.jdk.@internal.org.objectweb.asm.Handle arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[95], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/ConstantDynamic;)V", "public")]
	public void cconst(Dova.JDK.jdk.@internal.org.objectweb.asm.ConstantDynamic arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[96], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void lcmp()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[97]);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)V", "public")]
	public void instanceOf(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[98], arg0);
	}
}
