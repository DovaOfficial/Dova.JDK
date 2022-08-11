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

namespace Dova.JDK.com.sun.org.apache.bcel.@internal.generic;

[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/AnnotationEntryGen;", "public")]
public partial class AnnotationEntryGen
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AnnotationEntryGen()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/bcel/internal/generic/AnnotationEntryGen;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "evs", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cpool", "Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isRuntimeVisible", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/bcel/internal/generic/ObjectType;Ljava/util/List;ZLcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/bcel/internal/classfile/AnnotationEntry;Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotation", "()Lcom/sun/org/apache/bcel/internal/classfile/AnnotationEntry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "read", "(Ljava/io/DataInput;Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;Z)Lcom/sun/org/apache/bcel/internal/generic/AnnotationEntryGen;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toShortString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRuntimeVisible", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRuntimeVisible", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyValues", "([Lcom/sun/org/apache/bcel/internal/classfile/ElementValuePair;Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;Z)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addElementNameValuePair", "(Lcom/sun/org/apache/bcel/internal/generic/ElementValuePairGen;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dump", "(Ljava/io/DataOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeIndex", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValues", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAnnotationAttributes", "(Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;[Lcom/sun/org/apache/bcel/internal/generic/AnnotationEntryGen;)[Lcom/sun/org/apache/bcel/internal/classfile/Attribute;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getParameterAnnotationAttributes", "(Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;[Ljava/util/List;)[Lcom/sun/org/apache/bcel/internal/classfile/Attribute;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeSignature", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("I", "private")]
	public int typeIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List evs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;", "private final")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen cpool_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool isRuntimeVisible_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AnnotationEntryGen(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ObjectType;Ljava/util/List;ZLcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)V", "public")]
	public AnnotationEntryGen(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ObjectType arg0, Dova.JDK.java.util.List arg1, bool arg2, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)V", "private")]
	public AnnotationEntryGen(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/AnnotationEntry;Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;Z)V", "public")]
	public AnnotationEntryGen(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.AnnotationEntry arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/bcel/internal/generic/AnnotationEntryGen;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public final")]
	public Dova.JDK.java.lang.String getTypeName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/classfile/AnnotationEntry;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.AnnotationEntry getAnnotation()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.AnnotationEntry>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/DataInput;Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;Z)Lcom/sun/org/apache/bcel/internal/generic/AnnotationEntryGen;", "public static")]
	public static Dova.JDK.com.sun.org.apache.bcel.@internal.generic.AnnotationEntryGen read(Dova.JDK.java.io.DataInput arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.AnnotationEntryGen>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toShortString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Z)V", "private")]
	public void isRuntimeVisible(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isRuntimeVisible()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("([Lcom/sun/org/apache/bcel/internal/classfile/ElementValuePair;Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;Z)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List copyValues(JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ElementValuePair> arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ElementValuePairGen;)V", "public")]
	public void addElementNameValuePair(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ElementValuePairGen arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/DataOutputStream;)V", "public")]
	public void dump(Dova.JDK.java.io.DataOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getTypeIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getValues()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;[Lcom/sun/org/apache/bcel/internal/generic/AnnotationEntryGen;)[Lcom/sun/org/apache/bcel/internal/classfile/Attribute;", "static")]
	public static JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Attribute> getAnnotationAttributes(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen arg0, JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.AnnotationEntryGen> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Attribute>>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;[Ljava/util/List;)[Lcom/sun/org/apache/bcel/internal/classfile/Attribute;", "static")]
	public static JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Attribute> getParameterAnnotationAttributes(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen arg0, JavaArray<Dova.JDK.java.util.List> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Attribute>>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public final")]
	public Dova.JDK.java.lang.String getTypeSignature()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
