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

namespace Dova.JDK.sun.net.www.http;

[JniSignatureAttribute("Lsun/net/www/http/KeepAliveCleanerEntry;", "")]
public partial class KeepAliveCleanerEntry
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static KeepAliveCleanerEntry()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/net/www/http/KeepAliveCleanerEntry;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "kas", "Lsun/net/www/http/KeepAliveStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hc", "Lsun/net/www/http/HttpClient;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/net/www/http/KeepAliveStream;Lsun/net/www/http/HttpClient;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeepAliveStream", "()Lsun/net/www/http/KeepAliveStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHttpClient", "()Lsun/net/www/http/HttpClient;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setQueuedForCleanup", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getQueuedForCleanup", "()Z"));
	}

	[JniSignatureAttribute("Lsun/net/www/http/KeepAliveStream;", "")]
	public Dova.JDK.sun.net.www.http.KeepAliveStream kas_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.http.KeepAliveStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/net/www/http/HttpClient;", "")]
	public Dova.JDK.sun.net.www.http.HttpClient hc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.http.HttpClient>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public KeepAliveCleanerEntry(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/net/www/http/KeepAliveStream;Lsun/net/www/http/HttpClient;)V", "public")]
	public KeepAliveCleanerEntry(Dova.JDK.sun.net.www.http.KeepAliveStream arg0, Dova.JDK.sun.net.www.http.HttpClient arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/net/www/http/KeepAliveCleanerEntry;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lsun/net/www/http/KeepAliveStream;", "protected")]
	public Dova.JDK.sun.net.www.http.KeepAliveStream getKeepAliveStream()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.http.KeepAliveStream>(ret);
	}

	[JniSignatureAttribute("()Lsun/net/www/http/HttpClient;", "protected")]
	public Dova.JDK.sun.net.www.http.HttpClient getHttpClient()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.http.HttpClient>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void setQueuedForCleanup()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool getQueuedForCleanup()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}
}
