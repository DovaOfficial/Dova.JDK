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

namespace Dova.JDK.sun.font;

[JniSignatureAttribute("Lsun/font/FontManagerForSGE;", "public abstract interface")]
public partial interface FontManagerForSGE
	: IJavaObject
	, Dova.JDK.sun.font.FontManager
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FontManagerForSGE()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/font/FontManagerForSGE;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "useAlternateFontforJALocales", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAllInstalledFonts", "()[Ljava/awt/Font;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCreatedFonts", "()[Ljava/awt/Font;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInstalledFontFamilyNames", "(Ljava/util/Locale;)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCreatedFontFamilyNames", "()Ljava/util/TreeMap;"));
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void useAlternateFontforJALocales()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()[Ljava/awt/Font;", "public abstract")]
	JavaArray<Dova.JDK.java.awt.Font> getAllInstalledFonts()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.Font>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/awt/Font;", "public abstract")]
	JavaArray<Dova.JDK.java.awt.Font> getCreatedFonts()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.Font>>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)[Ljava/lang/String;", "public abstract")]
	JavaArray<Dova.JDK.java.lang.String> getInstalledFontFamilyNames(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/TreeMap;", "public abstract")]
	Dova.JDK.java.util.TreeMap getCreatedFontFamilyNames()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.TreeMap>(ret);
	}
}
