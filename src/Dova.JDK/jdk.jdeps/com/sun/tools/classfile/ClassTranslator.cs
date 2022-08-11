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

[JniSignatureAttribute("Lcom/sun/tools/classfile/ClassTranslator;", "public")]
public partial class ClassTranslator
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.tools.classfile.ConstantPool.Visitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ClassTranslator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/ClassTranslator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "equal", "([Ljava/lang/Object;[Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModule", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Module_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModule", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Module_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPackage", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Package_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPackage", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Package_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClass", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Class_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClass", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Class_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateAttributes", "(Lcom/sun/tools/classfile/Attributes;Lcom/sun/tools/classfile/ConstantPool;Ljava/util/Map;)Lcom/sun/tools/classfile/Attributes;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInterfaceMethodref", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InterfaceMethodref_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInterfaceMethodref", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InterfaceMethodref_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFieldref", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Fieldref_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFieldref", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Fieldref_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDouble", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Double_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDouble", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Double_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLong", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Long_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLong", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Long_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateMethods", "([Lcom/sun/tools/classfile/Method;Lcom/sun/tools/classfile/ConstantPool;Ljava/util/Map;)[Lcom/sun/tools/classfile/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitString", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_String_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitString", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_String_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodref", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Methodref_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodref", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Methodref_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNameAndType", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNameAndType", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodHandle", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodHandle_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodHandle", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodHandle_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFloat", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Float_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFloat", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Float_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUtf8", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Utf8_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUtf8", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Utf8_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInvokeDynamic", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InvokeDynamic_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInvokeDynamic", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InvokeDynamic_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInteger", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Integer_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInteger", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Integer_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodType", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodType_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodType", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodType_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDynamicConstant", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Dynamic_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDynamicConstant", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Dynamic_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translate", "(Lcom/sun/tools/classfile/Field;Lcom/sun/tools/classfile/ConstantPool;Ljava/util/Map;)Lcom/sun/tools/classfile/Field;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translate", "(Lcom/sun/tools/classfile/Method;Lcom/sun/tools/classfile/ConstantPool;Ljava/util/Map;)Lcom/sun/tools/classfile/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translate", "([Lcom/sun/tools/classfile/Field;Lcom/sun/tools/classfile/ConstantPool;Ljava/util/Map;)[Lcom/sun/tools/classfile/Field;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translate", "(Lcom/sun/tools/classfile/Attribute;Ljava/util/Map;)Lcom/sun/tools/classfile/Attribute;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translate", "(Lcom/sun/tools/classfile/ClassFile;Ljava/util/Map;)Lcom/sun/tools/classfile/ClassFile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translate", "(Lcom/sun/tools/classfile/ConstantPool$CPInfo;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translate", "(Lcom/sun/tools/classfile/ConstantPool;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ClassTranslator(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ClassTranslator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ClassTranslator;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Ljava/lang/Object;[Ljava/lang/Object;)Z", "private static")]
	public static bool equal(JavaArray<Dova.JDK.java.lang.Object> arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Module_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;", "public")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo visitModule(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Module_info arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Module_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitModule(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Module_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Package_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitPackage(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Package_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Package_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;", "public")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo visitPackage(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Package_info arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Class_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;", "public")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo visitClass(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Class_info arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Class_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitClass(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Class_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Attributes;Lcom/sun/tools/classfile/ConstantPool;Ljava/util/Map;)Lcom/sun/tools/classfile/Attributes;", "")]
	public Dova.JDK.com.sun.tools.classfile.Attributes translateAttributes(Dova.JDK.com.sun.tools.classfile.Attributes arg0, Dova.JDK.com.sun.tools.classfile.ConstantPool arg1, Dova.JDK.java.util.Map arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Attributes>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InterfaceMethodref_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;", "public")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo visitInterfaceMethodref(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_InterfaceMethodref_info arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InterfaceMethodref_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitInterfaceMethodref(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_InterfaceMethodref_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Fieldref_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;", "public")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo visitFieldref(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Fieldref_info arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Fieldref_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitFieldref(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Fieldref_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Double_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitDouble(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Double_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Double_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;", "public")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo visitDouble(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Double_info arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Long_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;", "public")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo visitLong(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Long_info arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Long_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitLong(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Long_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("([Lcom/sun/tools/classfile/Method;Lcom/sun/tools/classfile/ConstantPool;Ljava/util/Map;)[Lcom/sun/tools/classfile/Method;", "")]
	public JavaArray<Dova.JDK.com.sun.tools.classfile.Method> translateMethods(JavaArray<Dova.JDK.com.sun.tools.classfile.Method> arg0, Dova.JDK.com.sun.tools.classfile.ConstantPool arg1, Dova.JDK.java.util.Map arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.Method>>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_String_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitString(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_String_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_String_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;", "public")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo visitString(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_String_info arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Methodref_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;", "public")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo visitMethodref(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Methodref_info arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Methodref_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitMethodref(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Methodref_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;", "public")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo visitNameAndType(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_NameAndType_info arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitNameAndType(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_NameAndType_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodHandle_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitMethodHandle(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_MethodHandle_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodHandle_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;", "public")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo visitMethodHandle(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_MethodHandle_info arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Float_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitFloat(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Float_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Float_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;", "public")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo visitFloat(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Float_info arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Utf8_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;", "public")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo visitUtf8(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Utf8_info arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Utf8_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitUtf8(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Utf8_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InvokeDynamic_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitInvokeDynamic(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_InvokeDynamic_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InvokeDynamic_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;", "public")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo visitInvokeDynamic(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_InvokeDynamic_info arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Integer_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;", "public")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo visitInteger(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Integer_info arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Integer_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitInteger(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Integer_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodType_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitMethodType(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_MethodType_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodType_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;", "public")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo visitMethodType(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_MethodType_info arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Dynamic_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitDynamicConstant(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Dynamic_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Dynamic_info;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;", "public")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo visitDynamicConstant(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Dynamic_info arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Field;Lcom/sun/tools/classfile/ConstantPool;Ljava/util/Map;)Lcom/sun/tools/classfile/Field;", "")]
	public Dova.JDK.com.sun.tools.classfile.Field translate(Dova.JDK.com.sun.tools.classfile.Field arg0, Dova.JDK.com.sun.tools.classfile.ConstantPool arg1, Dova.JDK.java.util.Map arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Field>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Method;Lcom/sun/tools/classfile/ConstantPool;Ljava/util/Map;)Lcom/sun/tools/classfile/Method;", "")]
	public Dova.JDK.com.sun.tools.classfile.Method translate(Dova.JDK.com.sun.tools.classfile.Method arg0, Dova.JDK.com.sun.tools.classfile.ConstantPool arg1, Dova.JDK.java.util.Map arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Method>(ret);
	}

	[JniSignatureAttribute("([Lcom/sun/tools/classfile/Field;Lcom/sun/tools/classfile/ConstantPool;Ljava/util/Map;)[Lcom/sun/tools/classfile/Field;", "")]
	public JavaArray<Dova.JDK.com.sun.tools.classfile.Field> translate(JavaArray<Dova.JDK.com.sun.tools.classfile.Field> arg0, Dova.JDK.com.sun.tools.classfile.ConstantPool arg1, Dova.JDK.java.util.Map arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.Field>>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Attribute;Ljava/util/Map;)Lcom/sun/tools/classfile/Attribute;", "")]
	public Dova.JDK.com.sun.tools.classfile.Attribute translate(Dova.JDK.com.sun.tools.classfile.Attribute arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Attribute>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassFile;Ljava/util/Map;)Lcom/sun/tools/classfile/ClassFile;", "public")]
	public Dova.JDK.com.sun.tools.classfile.ClassFile translate(Dova.JDK.com.sun.tools.classfile.ClassFile arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ClassFile>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CPInfo;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool$CPInfo;", "")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo translate(Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;Ljava/util/Map;)Lcom/sun/tools/classfile/ConstantPool;", "")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool translate(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool>(ret);
	}
}
