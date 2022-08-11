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

namespace Dova.JDK.com.sun.tools.jdeprscan.scan;

[JniSignatureAttribute("Lcom/sun/tools/jdeprscan/scan/CPSelector;", "")]
public partial class CPSelector
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.tools.classfile.ConstantPool.Visitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CPSelector()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdeprscan/scan/CPSelector;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModule", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Module_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModule", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Module_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPackage", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Package_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPackage", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Package_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDynamicConstant", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Dynamic_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDynamicConstant", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Dynamic_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInterfaceMethodref", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InterfaceMethodref_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInterfaceMethodref", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InterfaceMethodref_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodType", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodType_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodType", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodType_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodHandle", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodHandle_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodHandle", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodHandle_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodref", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Methodref_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodref", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Methodref_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLong", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Long_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLong", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Long_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInvokeDynamic", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InvokeDynamic_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInvokeDynamic", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InvokeDynamic_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInteger", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Integer_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInteger", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Integer_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFloat", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Float_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFloat", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Float_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFieldref", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Fieldref_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFieldref", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Fieldref_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDouble", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Double_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDouble", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Double_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUtf8", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Utf8_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUtf8", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Utf8_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitString", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_String_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitString", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_String_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNameAndType", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNameAndType", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClass", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Class_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClass", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Class_info;Ljava/lang/Object;)Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CPSelector(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public CPSelector() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/jdeprscan/scan/CPSelector;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Module_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitModule(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Module_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Module_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitModule(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Module_info arg0, Dova.JDK.com.sun.tools.jdeprscan.scan.CPEntries arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Package_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitPackage(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Package_info arg0, Dova.JDK.com.sun.tools.jdeprscan.scan.CPEntries arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Package_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitPackage(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Package_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Dynamic_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitDynamicConstant(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Dynamic_info arg0, Dova.JDK.com.sun.tools.jdeprscan.scan.CPEntries arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Dynamic_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitDynamicConstant(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Dynamic_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InterfaceMethodref_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitInterfaceMethodref(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_InterfaceMethodref_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InterfaceMethodref_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitInterfaceMethodref(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_InterfaceMethodref_info arg0, Dova.JDK.com.sun.tools.jdeprscan.scan.CPEntries arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodType_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitMethodType(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_MethodType_info arg0, Dova.JDK.com.sun.tools.jdeprscan.scan.CPEntries arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodType_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitMethodType(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_MethodType_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodHandle_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitMethodHandle(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_MethodHandle_info arg0, Dova.JDK.com.sun.tools.jdeprscan.scan.CPEntries arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodHandle_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitMethodHandle(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_MethodHandle_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Methodref_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitMethodref(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Methodref_info arg0, Dova.JDK.com.sun.tools.jdeprscan.scan.CPEntries arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Methodref_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitMethodref(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Methodref_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Long_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitLong(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Long_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Long_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitLong(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Long_info arg0, Dova.JDK.com.sun.tools.jdeprscan.scan.CPEntries arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InvokeDynamic_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitInvokeDynamic(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_InvokeDynamic_info arg0, Dova.JDK.com.sun.tools.jdeprscan.scan.CPEntries arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InvokeDynamic_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitInvokeDynamic(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_InvokeDynamic_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Integer_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitInteger(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Integer_info arg0, Dova.JDK.com.sun.tools.jdeprscan.scan.CPEntries arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Integer_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitInteger(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Integer_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Float_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitFloat(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Float_info arg0, Dova.JDK.com.sun.tools.jdeprscan.scan.CPEntries arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Float_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitFloat(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Float_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Fieldref_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitFieldref(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Fieldref_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Fieldref_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitFieldref(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Fieldref_info arg0, Dova.JDK.com.sun.tools.jdeprscan.scan.CPEntries arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Double_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitDouble(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Double_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Double_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitDouble(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Double_info arg0, Dova.JDK.com.sun.tools.jdeprscan.scan.CPEntries arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Utf8_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitUtf8(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Utf8_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Utf8_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitUtf8(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Utf8_info arg0, Dova.JDK.com.sun.tools.jdeprscan.scan.CPEntries arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_String_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitString(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_String_info arg0, Dova.JDK.com.sun.tools.jdeprscan.scan.CPEntries arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_String_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitString(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_String_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitNameAndType(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_NameAndType_info arg0, Dova.JDK.com.sun.tools.jdeprscan.scan.CPEntries arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitNameAndType(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_NameAndType_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Class_info;Lcom/sun/tools/jdeprscan/scan/CPEntries;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitClass(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Class_info arg0, Dova.JDK.com.sun.tools.jdeprscan.scan.CPEntries arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Class_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitClass(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Class_info arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}
}
