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

namespace Dova.JDK.java.lang;

[JniSignatureAttribute("Ljava/lang/NumberFormatException;", "public")]
public partial class NumberFormatException
	: Dova.JDK.java.lang.IllegalArgumentException
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NumberFormatException()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/lang/NumberFormatException;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "NumberFormatException", "()V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "NumberFormatException", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "forInputString", "(Ljava/lang/String;I)Ljava/lang/NumberFormatException;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "forCharSequence", "(Ljava/lang/CharSequence;III)Ljava/lang/NumberFormatException;"));
	}

	[JniSignatureAttribute("J", "static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public NumberFormatException(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public NumberFormatException() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public NumberFormatException(Dova.JDK.java.lang.String arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/lang/NumberFormatException;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;I)Ljava/lang/NumberFormatException;", "static")]
	public static Dova.JDK.java.lang.NumberFormatException forInputString(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.NumberFormatException>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;III)Ljava/lang/NumberFormatException;", "static")]
	public static Dova.JDK.java.lang.NumberFormatException forCharSequence(Dova.JDK.java.lang.CharSequence arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.NumberFormatException>(ret);
	}
}
