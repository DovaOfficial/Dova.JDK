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

namespace Dova.JDK.com.sun.org.apache.bcel.@internal.util;

[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/util/MethodHTML;", "final")]
public partial class MethodHTML
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MethodHTML()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/bcel/internal/util/MethodHTML;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "className", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "file", "Ljava/io/PrintWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constantHtml", "Lcom/sun/org/apache/bcel/internal/util/ConstantHTML;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attribute_html", "Lcom/sun/org/apache/bcel/internal/util/AttributeHTML;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/String;[Lcom/sun/org/apache/bcel/internal/classfile/Method;[Lcom/sun/org/apache/bcel/internal/classfile/Field;Lcom/sun/org/apache/bcel/internal/util/ConstantHTML;Lcom/sun/org/apache/bcel/internal/util/AttributeHTML;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeField", "(Lcom/sun/org/apache/bcel/internal/classfile/Field;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeMethod", "(Lcom/sun/org/apache/bcel/internal/classfile/Method;I)V"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String className_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/PrintWriter;", "private final")]
	public Dova.JDK.java.io.PrintWriter file_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/util/ConstantHTML;", "private final")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.util.ConstantHTML constantHtml_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.util.ConstantHTML>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/util/AttributeHTML;", "private final")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.util.AttributeHTML attribute_html_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.util.AttributeHTML>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MethodHTML(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;[Lcom/sun/org/apache/bcel/internal/classfile/Method;[Lcom/sun/org/apache/bcel/internal/classfile/Field;Lcom/sun/org/apache/bcel/internal/util/ConstantHTML;Lcom/sun/org/apache/bcel/internal/util/AttributeHTML;)V", "")]
	public MethodHTML(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Method> arg2, JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Field> arg3, Dova.JDK.com.sun.org.apache.bcel.@internal.util.ConstantHTML arg4, Dova.JDK.com.sun.org.apache.bcel.@internal.util.AttributeHTML arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/bcel/internal/util/MethodHTML;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/Field;)V", "private")]
	public void writeField(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Field arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/Method;I)V", "private")]
	public void writeMethod(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Method arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}
}
