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

[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantValue_attribute;", "public")]
public partial class ConstantValue_attribute
	: Dova.JDK.com.sun.tools.classfile.Attribute
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ConstantValue_attribute()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/ConstantValue_attribute;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "constantvalue_index", "I"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ConstantValue_attribute", "(II)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ConstantValue_attribute", "(Lcom/sun/tools/classfile/ConstantPool;I)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ConstantValue_attribute", "(Lcom/sun/tools/classfile/ClassReader;II)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accept", "(Lcom/sun/tools/classfile/Attribute$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("I", "public final")]
	public int constantvalue_index_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ConstantValue_attribute(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(II)V", "public")]
	public ConstantValue_attribute(int arg0, int arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;I)V", "public")]
	public ConstantValue_attribute(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, int arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassReader;II)V", "")]
	public ConstantValue_attribute(Dova.JDK.com.sun.tools.classfile.ClassReader arg0, int arg1, int arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ConstantValue_attribute;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Attribute$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.classfile.Attribute.Visitor arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}
}