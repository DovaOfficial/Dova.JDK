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

namespace Dova.JDK.java.util.prefs;

[JniSignatureAttribute("Ljava/util/prefs/FileSystemPreferencesFactory;", "")]
public partial class FileSystemPreferencesFactory
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.util.prefs.PreferencesFactory
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FileSystemPreferencesFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/prefs/FileSystemPreferencesFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "userRoot", "()Ljava/util/prefs/Preferences;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "systemRoot", "()Ljava/util/prefs/Preferences;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public FileSystemPreferencesFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public FileSystemPreferencesFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/prefs/FileSystemPreferencesFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/util/prefs/Preferences;", "public")]
	public Dova.JDK.java.util.prefs.Preferences userRoot()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.prefs.Preferences>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/prefs/Preferences;", "public")]
	public Dova.JDK.java.util.prefs.Preferences systemRoot()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.prefs.Preferences>(ret);
	}
}
