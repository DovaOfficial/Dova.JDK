/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.jdk.@internal.net.http.frame;

[JniSignatureAttribute("Ljdk/internal/net/http/frame/OutgoingHeaders;", "public")]
public partial class OutgoingHeaders
	: Dova.JDK.jdk.@internal.net.http.frame.Http2Frame
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static OutgoingHeaders()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/frame/OutgoingHeaders;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "streamDependency", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "weight", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exclusive", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attachment", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIORITY", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "user", "Ljava/net/http/HttpHeaders;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "system", "Ljava/net/http/HttpHeaders;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/net/http/HttpHeaders;Ljava/net/http/HttpHeaders;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPriority", "(IZI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExclusive", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStreamDependency", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUserHeaders", "()Ljava/net/http/HttpHeaders;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttachment", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSystemHeaders", "()Ljava/net/http/HttpHeaders;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWeight", "()I"));
	}

	[JniSignatureAttribute("I", "")]
	public int streamDependency_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int weight_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool exclusive_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object attachment_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int PRIORITY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("Ljava/net/http/HttpHeaders;", "")]
	public Dova.JDK.java.net.http.HttpHeaders user_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpHeaders>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/http/HttpHeaders;", "")]
	public Dova.JDK.java.net.http.HttpHeaders system_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpHeaders>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public OutgoingHeaders(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/net/http/HttpHeaders;Ljava/net/http/HttpHeaders;Ljava/lang/Object;)V", "public")]
	public OutgoingHeaders(Dova.JDK.java.net.http.HttpHeaders arg0, Dova.JDK.java.net.http.HttpHeaders arg1, Dova.JDK.java.lang.Object arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/net/http/frame/OutgoingHeaders;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(IZI)V", "public")]
	public void setPriority(int arg0, bool arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getExclusive()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getStreamDependency()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpHeaders;", "public")]
	public Dova.JDK.java.net.http.HttpHeaders getUserHeaders()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpHeaders>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getAttachment()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/http/HttpHeaders;", "public")]
	public Dova.JDK.java.net.http.HttpHeaders getSystemHeaders()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.http.HttpHeaders>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getWeight()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}
}
