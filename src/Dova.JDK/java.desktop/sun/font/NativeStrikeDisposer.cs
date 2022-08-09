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

namespace Dova.JDK.sun.font;

[JniSignatureAttribute("Lsun/font/NativeStrikeDisposer;", "")]
public partial class NativeStrikeDisposer
	: Dova.JDK.sun.font.FontStrikeDisposer
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NativeStrikeDisposer()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/font/NativeStrikeDisposer;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "pNativeScalerContext", "J"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "NativeStrikeDisposer", "(Lsun/font/Font2D;Lsun/font/FontStrikeDesc;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "NativeStrikeDisposer", "(Lsun/font/Font2D;Lsun/font/FontStrikeDesc;J)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "NativeStrikeDisposer", "(Lsun/font/Font2D;Lsun/font/FontStrikeDesc;J[J)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "NativeStrikeDisposer", "(Lsun/font/Font2D;Lsun/font/FontStrikeDesc;J[I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "dispose", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "freeNativeScalerContext", "(J)V"));
	}

	[JniSignatureAttribute("J", "")]
	public long pNativeScalerContext_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public NativeStrikeDisposer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/font/Font2D;Lsun/font/FontStrikeDesc;)V", "public")]
	public NativeStrikeDisposer(Dova.JDK.sun.font.Font2D arg0, Dova.JDK.sun.font.FontStrikeDesc arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lsun/font/Font2D;Lsun/font/FontStrikeDesc;J)V", "public")]
	public NativeStrikeDisposer(Dova.JDK.sun.font.Font2D arg0, Dova.JDK.sun.font.FontStrikeDesc arg1, long arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Lsun/font/Font2D;Lsun/font/FontStrikeDesc;J[J)V", "public")]
	public NativeStrikeDisposer(Dova.JDK.sun.font.Font2D arg0, Dova.JDK.sun.font.FontStrikeDesc arg1, long arg2, JavaArray<long> arg3) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Lsun/font/Font2D;Lsun/font/FontStrikeDesc;J[I)V", "public")]
	public NativeStrikeDisposer(Dova.JDK.sun.font.Font2D arg0, Dova.JDK.sun.font.FontStrikeDesc arg1, long arg2, JavaArray<int> arg3) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[3], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/font/NativeStrikeDisposer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public synchronized")]
	public void dispose()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(J)V", "private native")]
	public void freeNativeScalerContext(long arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}
}
