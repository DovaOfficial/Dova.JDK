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

[JniSignatureAttribute("Lsun/font/FcFontConfiguration;", "public")]
public partial class FcFontConfiguration
	: Dova.JDK.sun.awt.FontConfiguration
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FcFontConfiguration()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/font/FcFontConfiguration;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "fileVersion", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fcInfoFileName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fcCompFonts", "[Lsun/font/FontConfigManager$FcCompFont;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/font/SunFontManager;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/font/SunFontManager;ZZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEncoding", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "warning", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileNameFromPlatformName", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "needToSearchForFile", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFallbackFamilyName", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNumberCoreFonts", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPlatformFontNames", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get2DCompositeFontInfo", "()[Lsun/font/CompositeFontDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExtraFontPath", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOsNameAndVersion", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVersionString", "(Ljava/io/File;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "extractOsInfo", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initReorderMap", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultFontCharset", "(Ljava/lang/String;)Ljava/nio/charset/Charset;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFaceNameFromComponentFontName", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileNameFromComponentFontName", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildFontDescriptors", "(II)[Lsun/awt/FontDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readFcInfo", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeFcInfo", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFcFontList", "([Lsun/font/FontConfigManager$FcCompFont;Ljava/lang/String;I)[Lsun/font/FontConfigManager$FontConfigFont;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFcInfoFile", "()Ljava/io/File;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String fileVersion_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String fcInfoFileName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/font/FontConfigManager$FcCompFont;", "private")]
	public JavaArray<Dova.JDK.sun.font.FontConfigManager.FcCompFont> fcCompFonts_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.font.FontConfigManager.FcCompFont>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public FcFontConfiguration(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/font/SunFontManager;)V", "public")]
	public FcFontConfiguration(Dova.JDK.sun.font.SunFontManager arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Lsun/font/SunFontManager;ZZ)V", "public")]
	public FcFontConfiguration(Dova.JDK.sun.font.SunFontManager arg0, bool arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/font/FcFontConfiguration;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Z", "public synchronized")]
	public bool init()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String getEncoding(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private static")]
	public static void warning(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getFileNameFromPlatformName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
	public bool needToSearchForFile(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getFallbackFamilyName(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getNumberCoreFonts()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getPlatformFontNames()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("()[Lsun/font/CompositeFontDescriptor;", "public")]
	public JavaArray<Dova.JDK.sun.font.CompositeFontDescriptor> get2DCompositeFontInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.font.CompositeFontDescriptor>>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getExtraFontPath()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void setOsNameAndVersion()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getVersionString(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String extractOsInfo(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void initReorderMap()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/nio/charset/Charset;", "protected")]
	public Dova.JDK.java.nio.charset.Charset getDefaultFontCharset(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.Charset>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String getFaceNameFromComponentFontName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String getFileNameFromComponentFontName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(II)[Lsun/awt/FontDescriptor;", "protected")]
	public JavaArray<Dova.JDK.sun.awt.FontDescriptor> buildFontDescriptors(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.awt.FontDescriptor>>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void readFcInfo()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void writeFcInfo()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19]);
	}

	[JniSignatureAttribute("([Lsun/font/FontConfigManager$FcCompFont;Ljava/lang/String;I)[Lsun/font/FontConfigManager$FontConfigFont;", "private")]
	public JavaArray<Dova.JDK.sun.font.FontConfigManager.FontConfigFont> getFcFontList(JavaArray<Dova.JDK.sun.font.FontConfigManager.FcCompFont> arg0, Dova.JDK.java.lang.String arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.font.FontConfigManager.FontConfigFont>>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/File;", "private")]
	public Dova.JDK.java.io.File getFcInfoFile()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
	}
}
