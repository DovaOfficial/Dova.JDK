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

namespace Dova.JDK.javax.swing.colorchooser;

[JniSignatureAttribute("Ljavax/swing/colorchooser/ColorModelHSV;", "final")]
public partial class ColorModelHSV
	: Dova.JDK.javax.swing.colorchooser.ColorModel
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ColorModelHSV()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/colorchooser/ColorModelHSV;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefault", "(I)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaximum", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setColor", "(I[F)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColor", "([F)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "RGBtoHSV", "([F[F)[F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "HSVtoRGB", "([F[F)[F"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ColorModelHSV(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public ColorModelHSV() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/colorchooser/ColorModelHSV;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)F", "")]
	public float getDefault(int arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "")]
	public int getMaximum(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I[F)V", "")]
	public void setColor(int arg0, JavaArray<float> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("([F)I", "")]
	public int getColor(JavaArray<float> arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("([F[F)[F", "private static")]
	public static JavaArray<float> RGBtoHSV(JavaArray<float> arg0, JavaArray<float> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
	}

	[JniSignatureAttribute("([F[F)[F", "private static")]
	public static JavaArray<float> HSVtoRGB(JavaArray<float> arg0, JavaArray<float> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
	}
}
