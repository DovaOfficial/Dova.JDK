/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.tools.classfile;

[JniSignatureAttribute("Lcom/sun/tools/classfile/DefaultAttribute;", "public")]
public partial class DefaultAttribute
	: Dova.JDK.com.sun.tools.classfile.Attribute
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DefaultAttribute()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/DefaultAttribute;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "info", "[B"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "reason", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DefaultAttribute", "(Lcom/sun/tools/classfile/ConstantPool;I[BLjava/lang/String;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DefaultAttribute", "(Lcom/sun/tools/classfile/ConstantPool;I[B)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DefaultAttribute", "(Lcom/sun/tools/classfile/ClassReader;I[BLjava/lang/String;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DefaultAttribute", "(Lcom/sun/tools/classfile/ClassReader;I[B)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accept", "(Lcom/sun/tools/classfile/Attribute$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("[B", "public final")]
	public JavaArray<byte> info_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public final")]
	public Dova.JDK.java.lang.String reason_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DefaultAttribute(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;I[BLjava/lang/String;)V", "public")]
	public DefaultAttribute(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, int arg1, JavaArray<byte> arg2, Dova.JDK.java.lang.String arg3) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;I[B)V", "public")]
	public DefaultAttribute(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, int arg1, JavaArray<byte> arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassReader;I[BLjava/lang/String;)V", "")]
	public DefaultAttribute(Dova.JDK.com.sun.tools.classfile.ClassReader arg0, int arg1, JavaArray<byte> arg2, Dova.JDK.java.lang.String arg3) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassReader;I[B)V", "")]
	public DefaultAttribute(Dova.JDK.com.sun.tools.classfile.ClassReader arg0, int arg1, JavaArray<byte> arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[3], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/DefaultAttribute;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Attribute$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.classfile.Attribute.Visitor arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}
}
