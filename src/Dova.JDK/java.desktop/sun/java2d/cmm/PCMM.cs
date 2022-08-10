/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.java2d.cmm;

[JniSignatureAttribute("Lsun/java2d/cmm/PCMM;", "public abstract interface")]
public partial interface PCMM
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PCMM()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/cmm/PCMM;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createTransform", "([Lsun/java2d/cmm/ColorTransform;)Lsun/java2d/cmm/ColorTransform;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createTransform", "(Ljava/awt/color/ICC_Profile;II)Lsun/java2d/cmm/ColorTransform;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "loadProfile", "([B)Lsun/java2d/cmm/Profile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getProfileData", "(Lsun/java2d/cmm/Profile;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getTagData", "(Lsun/java2d/cmm/Profile;I)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setTagData", "(Lsun/java2d/cmm/Profile;I[B)V"));
	}

	[JniSignatureAttribute("([Lsun/java2d/cmm/ColorTransform;)Lsun/java2d/cmm/ColorTransform;", "public abstract")]
	Dova.JDK.sun.java2d.cmm.ColorTransform createTransform(JavaArray<Dova.JDK.sun.java2d.cmm.ColorTransform> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.cmm.ColorTransform>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/color/ICC_Profile;II)Lsun/java2d/cmm/ColorTransform;", "public abstract")]
	Dova.JDK.sun.java2d.cmm.ColorTransform createTransform(Dova.JDK.java.awt.color.ICC_Profile arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.cmm.ColorTransform>(ret);
	}

	[JniSignatureAttribute("([B)Lsun/java2d/cmm/Profile;", "public abstract")]
	Dova.JDK.sun.java2d.cmm.Profile loadProfile(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.cmm.Profile>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/cmm/Profile;)[B", "public abstract")]
	JavaArray<byte> getProfileData(Dova.JDK.sun.java2d.cmm.Profile arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/cmm/Profile;I)[B", "public abstract")]
	JavaArray<byte> getTagData(Dova.JDK.sun.java2d.cmm.Profile arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/cmm/Profile;I[B)V", "public abstract")]
	void setTagData(Dova.JDK.sun.java2d.cmm.Profile arg0, int arg1, JavaArray<byte> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
	}
}
