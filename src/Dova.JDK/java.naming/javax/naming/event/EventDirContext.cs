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

namespace Dova.JDK.javax.naming.@event;

[JniSignatureAttribute("Ljavax/naming/event/EventDirContext;", "public abstract interface")]
public partial interface EventDirContext
	: IJavaObject
	, Dova.JDK.javax.naming.@event.EventContext
	, Dova.JDK.javax.naming.directory.DirContext
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static EventDirContext()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/naming/event/EventDirContext;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNamingListener", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljavax/naming/directory/SearchControls;Ljavax/naming/event/NamingListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNamingListener", "(Ljavax/naming/Name;Ljava/lang/String;[Ljava/lang/Object;Ljavax/naming/directory/SearchControls;Ljavax/naming/event/NamingListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNamingListener", "(Ljava/lang/String;Ljava/lang/String;Ljavax/naming/directory/SearchControls;Ljavax/naming/event/NamingListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNamingListener", "(Ljavax/naming/Name;Ljava/lang/String;Ljavax/naming/directory/SearchControls;Ljavax/naming/event/NamingListener;)V"));
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljavax/naming/directory/SearchControls;Ljavax/naming/event/NamingListener;)V", "public abstract")]
	void addNamingListener(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, Dova.JDK.javax.naming.directory.SearchControls arg3, Dova.JDK.javax.naming.@event.NamingListener arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/String;[Ljava/lang/Object;Ljavax/naming/directory/SearchControls;Ljavax/naming/event/NamingListener;)V", "public abstract")]
	void addNamingListener(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, Dova.JDK.javax.naming.directory.SearchControls arg3, Dova.JDK.javax.naming.@event.NamingListener arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljavax/naming/directory/SearchControls;Ljavax/naming/event/NamingListener;)V", "public abstract")]
	void addNamingListener(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.naming.directory.SearchControls arg2, Dova.JDK.javax.naming.@event.NamingListener arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/String;Ljavax/naming/directory/SearchControls;Ljavax/naming/event/NamingListener;)V", "public abstract")]
	void addNamingListener(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.naming.directory.SearchControls arg2, Dova.JDK.javax.naming.@event.NamingListener arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
	}
}
