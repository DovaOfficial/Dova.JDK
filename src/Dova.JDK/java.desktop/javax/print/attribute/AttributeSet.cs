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

namespace Dova.JDK.javax.print.attribute;

[JniSignatureAttribute("Ljavax/print/attribute/AttributeSet;", "public abstract interface")]
public partial interface AttributeSet
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AttributeSet()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/print/attribute/AttributeSet;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "add", "(Ljavax/print/attribute/Attribute;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "remove", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "remove", "(Ljavax/print/attribute/Attribute;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get", "(Ljava/lang/Class;)Ljavax/print/attribute/Attribute;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "clear", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isEmpty", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "size", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toArray", "()[Ljavax/print/attribute/Attribute;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addAll", "(Ljavax/print/attribute/AttributeSet;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "containsKey", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "containsValue", "(Ljavax/print/attribute/Attribute;)Z"));
	}

	[JniSignatureAttribute("(Ljavax/print/attribute/Attribute;)Z", "public abstract")]
	bool add(Dova.JDK.javax.print.attribute.Attribute arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public abstract")]
	bool remove(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/print/attribute/Attribute;)Z", "public abstract")]
	bool remove(Dova.JDK.javax.print.attribute.Attribute arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljavax/print/attribute/Attribute;", "public abstract")]
	Dova.JDK.javax.print.attribute.Attribute get(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.Attribute>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public abstract")]
	bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int hashCode()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void clear()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isEmpty()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int size()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()[Ljavax/print/attribute/Attribute;", "public abstract")]
	JavaArray<Dova.JDK.javax.print.attribute.Attribute> toArray()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.print.attribute.Attribute>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/print/attribute/AttributeSet;)Z", "public abstract")]
	bool addAll(Dova.JDK.javax.print.attribute.AttributeSet arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public abstract")]
	bool containsKey(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/print/attribute/Attribute;)Z", "public abstract")]
	bool containsValue(Dova.JDK.javax.print.attribute.Attribute arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}
}