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

namespace Dova.JDK.javax.annotation.processing;

[JniSignatureAttribute("Ljavax/annotation/processing/ProcessingEnvironment;", "public abstract interface")]
public partial interface ProcessingEnvironment
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ProcessingEnvironment()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/annotation/processing/ProcessingEnvironment;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocale", "()Ljava/util/Locale;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeUtils", "()Ljavax/lang/model/util/Types;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSourceVersion", "()Ljavax/lang/model/SourceVersion;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFiler", "()Ljavax/annotation/processing/Filer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOptions", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMessager", "()Ljavax/annotation/processing/Messager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPreviewEnabled", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElementUtils", "()Ljavax/lang/model/util/Elements;"));
	}

	[JniSignatureAttribute("()Ljava/util/Locale;", "public abstract")]
	Dova.JDK.java.util.Locale getLocale()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/util/Types;", "public abstract")]
	Dova.JDK.javax.lang.model.util.Types getTypeUtils()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.Types>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/SourceVersion;", "public abstract")]
	Dova.JDK.javax.lang.model.SourceVersion getSourceVersion()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.SourceVersion>(ret);
	}

	[JniSignatureAttribute("()Ljavax/annotation/processing/Filer;", "public abstract")]
	Dova.JDK.javax.annotation.processing.Filer getFiler()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.annotation.processing.Filer>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "public abstract")]
	Dova.JDK.java.util.Map getOptions()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()Ljavax/annotation/processing/Messager;", "public abstract")]
	Dova.JDK.javax.annotation.processing.Messager getMessager()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.annotation.processing.Messager>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	bool isPreviewEnabled()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/lang/model/util/Elements;", "public abstract")]
	Dova.JDK.javax.lang.model.util.Elements getElementUtils()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.Elements>(ret);
	}
}
