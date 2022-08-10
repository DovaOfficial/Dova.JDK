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

namespace Dova.JDK.jdk.@internal.org.objectweb.asm;

[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/AnnotationWriter;", "final")]
public partial class AnnotationWriter
	: Dova.JDK.jdk.@internal.org.objectweb.asm.AnnotationVisitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AnnotationWriter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/objectweb/asm/AnnotationWriter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "symbolTable", "Ljdk/internal/org/objectweb/asm/SymbolTable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "useNamedValues", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "annotation", "Ljdk/internal/org/objectweb/asm/ByteVector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "numElementValuePairsOffset", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "numElementValuePairs", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "previousAnnotation", "Ljdk/internal/org/objectweb/asm/AnnotationWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "nextAnnotation", "Ljdk/internal/org/objectweb/asm/AnnotationWriter;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AnnotationWriter", "(Ljdk/internal/org/objectweb/asm/SymbolTable;ZLjdk/internal/org/objectweb/asm/ByteVector;Ljdk/internal/org/objectweb/asm/AnnotationWriter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "create", "(Ljdk/internal/org/objectweb/asm/SymbolTable;ILjdk/internal/org/objectweb/asm/TypePath;Ljava/lang/String;Ljdk/internal/org/objectweb/asm/AnnotationWriter;)Ljdk/internal/org/objectweb/asm/AnnotationWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "create", "(Ljdk/internal/org/objectweb/asm/SymbolTable;Ljava/lang/String;Ljdk/internal/org/objectweb/asm/AnnotationWriter;)Ljdk/internal/org/objectweb/asm/AnnotationWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visit", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitAnnotation", "(Ljava/lang/String;Ljava/lang/String;)Ljdk/internal/org/objectweb/asm/AnnotationVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitEnd", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitEnum", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitArray", "(Ljava/lang/String;)Ljdk/internal/org/objectweb/asm/AnnotationVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "computeAnnotationsSize", "(Ljdk/internal/org/objectweb/asm/AnnotationWriter;Ljdk/internal/org/objectweb/asm/AnnotationWriter;Ljdk/internal/org/objectweb/asm/AnnotationWriter;Ljdk/internal/org/objectweb/asm/AnnotationWriter;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "computeAnnotationsSize", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "putAnnotations", "(Ljdk/internal/org/objectweb/asm/SymbolTable;Ljdk/internal/org/objectweb/asm/AnnotationWriter;Ljdk/internal/org/objectweb/asm/AnnotationWriter;Ljdk/internal/org/objectweb/asm/AnnotationWriter;Ljdk/internal/org/objectweb/asm/AnnotationWriter;Ljdk/internal/org/objectweb/asm/ByteVector;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putAnnotations", "(ILjdk/internal/org/objectweb/asm/ByteVector;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "computeParameterAnnotationsSize", "(Ljava/lang/String;[Ljdk/internal/org/objectweb/asm/AnnotationWriter;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "putParameterAnnotations", "(I[Ljdk/internal/org/objectweb/asm/AnnotationWriter;ILjdk/internal/org/objectweb/asm/ByteVector;)V"));
	}

	[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/SymbolTable;", "private final")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.SymbolTable symbolTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.SymbolTable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool useNamedValues_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/ByteVector;", "private final")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.ByteVector annotation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.ByteVector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int numElementValuePairsOffset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int numElementValuePairs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/AnnotationWriter;", "private final")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.AnnotationWriter previousAnnotation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.AnnotationWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/AnnotationWriter;", "private")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.AnnotationWriter nextAnnotation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.AnnotationWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AnnotationWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/SymbolTable;ZLjdk/internal/org/objectweb/asm/ByteVector;Ljdk/internal/org/objectweb/asm/AnnotationWriter;)V", "")]
	public AnnotationWriter(Dova.JDK.jdk.@internal.org.objectweb.asm.SymbolTable arg0, bool arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.ByteVector arg2, Dova.JDK.jdk.@internal.org.objectweb.asm.AnnotationWriter arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/org/objectweb/asm/AnnotationWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/SymbolTable;ILjdk/internal/org/objectweb/asm/TypePath;Ljava/lang/String;Ljdk/internal/org/objectweb/asm/AnnotationWriter;)Ljdk/internal/org/objectweb/asm/AnnotationWriter;", "static")]
	public static Dova.JDK.jdk.@internal.org.objectweb.asm.AnnotationWriter create(Dova.JDK.jdk.@internal.org.objectweb.asm.SymbolTable arg0, int arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.TypePath arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.jdk.@internal.org.objectweb.asm.AnnotationWriter arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.AnnotationWriter>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/SymbolTable;Ljava/lang/String;Ljdk/internal/org/objectweb/asm/AnnotationWriter;)Ljdk/internal/org/objectweb/asm/AnnotationWriter;", "static")]
	public static Dova.JDK.jdk.@internal.org.objectweb.asm.AnnotationWriter create(Dova.JDK.jdk.@internal.org.objectweb.asm.SymbolTable arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.AnnotationWriter arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.AnnotationWriter>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public")]
	public void visit(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljdk/internal/org/objectweb/asm/AnnotationVisitor;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.AnnotationVisitor visitAnnotation(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.AnnotationVisitor>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void visitEnd()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void visitEnum(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/org/objectweb/asm/AnnotationVisitor;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.AnnotationVisitor visitArray(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.AnnotationVisitor>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/AnnotationWriter;Ljdk/internal/org/objectweb/asm/AnnotationWriter;Ljdk/internal/org/objectweb/asm/AnnotationWriter;Ljdk/internal/org/objectweb/asm/AnnotationWriter;)I", "static")]
	public static int computeAnnotationsSize(Dova.JDK.jdk.@internal.org.objectweb.asm.AnnotationWriter arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.AnnotationWriter arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.AnnotationWriter arg2, Dova.JDK.jdk.@internal.org.objectweb.asm.AnnotationWriter arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "")]
	public int computeAnnotationsSize(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/SymbolTable;Ljdk/internal/org/objectweb/asm/AnnotationWriter;Ljdk/internal/org/objectweb/asm/AnnotationWriter;Ljdk/internal/org/objectweb/asm/AnnotationWriter;Ljdk/internal/org/objectweb/asm/AnnotationWriter;Ljdk/internal/org/objectweb/asm/ByteVector;)V", "static")]
	public static void putAnnotations(Dova.JDK.jdk.@internal.org.objectweb.asm.SymbolTable arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.AnnotationWriter arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.AnnotationWriter arg2, Dova.JDK.jdk.@internal.org.objectweb.asm.AnnotationWriter arg3, Dova.JDK.jdk.@internal.org.objectweb.asm.AnnotationWriter arg4, Dova.JDK.jdk.@internal.org.objectweb.asm.ByteVector arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(ILjdk/internal/org/objectweb/asm/ByteVector;)V", "")]
	public void putAnnotations(int arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.ByteVector arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljdk/internal/org/objectweb/asm/AnnotationWriter;I)I", "static")]
	public static int computeParameterAnnotationsSize(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.jdk.@internal.org.objectweb.asm.AnnotationWriter> arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(I[Ljdk/internal/org/objectweb/asm/AnnotationWriter;ILjdk/internal/org/objectweb/asm/ByteVector;)V", "static")]
	public static void putParameterAnnotations(int arg0, JavaArray<Dova.JDK.jdk.@internal.org.objectweb.asm.AnnotationWriter> arg1, int arg2, Dova.JDK.jdk.@internal.org.objectweb.asm.ByteVector arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
	}
}
