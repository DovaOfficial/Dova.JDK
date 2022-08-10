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

namespace Dova.JDK.java.util.prefs;

[JniSignatureAttribute("Ljava/util/prefs/PreferencesFactory;", "public abstract interface")]
public partial interface PreferencesFactory
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PreferencesFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/prefs/PreferencesFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "userRoot", "()Ljava/util/prefs/Preferences;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "systemRoot", "()Ljava/util/prefs/Preferences;"));
	}

	[JniSignatureAttribute("()Ljava/util/prefs/Preferences;", "public abstract")]
	Dova.JDK.java.util.prefs.Preferences userRoot()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.prefs.Preferences>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/prefs/Preferences;", "public abstract")]
	Dova.JDK.java.util.prefs.Preferences systemRoot()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.prefs.Preferences>(ret);
	}
}
