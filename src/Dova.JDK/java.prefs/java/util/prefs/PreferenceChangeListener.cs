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

[JniSignatureAttribute("Ljava/util/prefs/PreferenceChangeListener;", "public abstract interface")]
public partial interface PreferenceChangeListener
	: IJavaObject
	, Dova.JDK.java.util.EventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PreferenceChangeListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/prefs/PreferenceChangeListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "preferenceChange", "(Ljava/util/prefs/PreferenceChangeEvent;)V"));
	}

	[JniSignatureAttribute("(Ljava/util/prefs/PreferenceChangeEvent;)V", "public abstract")]
	void preferenceChange(Dova.JDK.java.util.prefs.PreferenceChangeEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}
}
