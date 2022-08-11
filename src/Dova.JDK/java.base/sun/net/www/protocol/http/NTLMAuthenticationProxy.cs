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

namespace Dova.JDK.sun.net.www.protocol.http;

[JniSignatureAttribute("Lsun/net/www/protocol/http/NTLMAuthenticationProxy;", "")]
public partial class NTLMAuthenticationProxy
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NTLMAuthenticationProxy()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/net/www/protocol/http/NTLMAuthenticationProxy;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "supportsTA", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "isTrustedSite", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "clazzStr", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "supportsTAStr", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "isTrustedSiteStr", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "proxy", "Lsun/net/www/protocol/http/NTLMAuthenticationProxy;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "supported", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "supportsTransparentAuth", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fourArgCtr", "Ljava/lang/reflect/Constructor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sixArgCtr", "Ljava/lang/reflect/Constructor;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Constructor;Ljava/lang/reflect/Constructor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "create", "(ZLjava/net/URL;Ljava/net/PasswordAuthentication;Ljava/lang/String;)Lsun/net/www/protocol/http/AuthenticationInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "create", "(ZLjava/lang/String;ILjava/net/PasswordAuthentication;Ljava/lang/String;)Lsun/net/www/protocol/http/AuthenticationInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "finest", "(Ljava/lang/Exception;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "supportsTransparentAuth", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isTrustedSite", "(Ljava/net/URL;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "tryLoadNTLMAuthentication", "()Lsun/net/www/protocol/http/NTLMAuthenticationProxy;"));
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method supportsTA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method isTrustedSite_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String clazzStr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String supportsTAStr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String isTrustedSiteStr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/net/www/protocol/http/NTLMAuthenticationProxy;", "static final")]
	public static Dova.JDK.sun.net.www.protocol.http.NTLMAuthenticationProxy proxy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.protocol.http.NTLMAuthenticationProxy>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool supported_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool supportsTransparentAuth_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Constructor;", "private final")]
	public Dova.JDK.java.lang.reflect.Constructor fourArgCtr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Constructor;", "private final")]
	public Dova.JDK.java.lang.reflect.Constructor sixArgCtr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public NTLMAuthenticationProxy(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;Ljava/lang/reflect/Constructor;)V", "private")]
	public NTLMAuthenticationProxy(Dova.JDK.java.lang.reflect.Constructor arg0, Dova.JDK.java.lang.reflect.Constructor arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/net/www/protocol/http/NTLMAuthenticationProxy;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(ZLjava/net/URL;Ljava/net/PasswordAuthentication;Ljava/lang/String;)Lsun/net/www/protocol/http/AuthenticationInfo;", "")]
	public Dova.JDK.sun.net.www.protocol.http.AuthenticationInfo create(bool arg0, Dova.JDK.java.net.URL arg1, Dova.JDK.java.net.PasswordAuthentication arg2, Dova.JDK.java.lang.String arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.protocol.http.AuthenticationInfo>(ret);
	}

	[JniSignatureAttribute("(ZLjava/lang/String;ILjava/net/PasswordAuthentication;Ljava/lang/String;)Lsun/net/www/protocol/http/AuthenticationInfo;", "")]
	public Dova.JDK.sun.net.www.protocol.http.AuthenticationInfo create(bool arg0, Dova.JDK.java.lang.String arg1, int arg2, Dova.JDK.java.net.PasswordAuthentication arg3, Dova.JDK.java.lang.String arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.protocol.http.AuthenticationInfo>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Exception;)V", "static")]
	public static void finest(Dova.JDK.java.lang.Exception arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()Z", "private static")]
	public static bool supportsTransparentAuth()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/net/URL;)Z", "public static")]
	public static bool isTrustedSite(Dova.JDK.java.net.URL arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/net/www/protocol/http/NTLMAuthenticationProxy;", "private static")]
	public static Dova.JDK.sun.net.www.protocol.http.NTLMAuthenticationProxy tryLoadNTLMAuthentication()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.protocol.http.NTLMAuthenticationProxy>(ret);
	}
}
