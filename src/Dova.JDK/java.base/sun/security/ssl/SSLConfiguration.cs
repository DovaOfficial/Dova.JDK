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

namespace Dova.JDK.sun.security.ssl;

[JniSignatureAttribute("Lsun/security/ssl/SSLConfiguration;", "final")]
public partial class SSLConfiguration
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.lang.Cloneable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SSLConfiguration()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLConfiguration;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "userSpecifiedAlgorithmConstraints", "Ljava/security/AlgorithmConstraints;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enabledProtocols", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enabledCipherSuites", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clientAuthType", "Lsun/security/ssl/ClientAuthType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "identificationProtocol", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serverNames", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sniMatchers", "Ljava/util/Collection;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "applicationProtocols", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "preferLocalCipherSuites", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enableRetransmissions", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maximumPacketSize", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signatureSchemes", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maximumProtocolVersion", "Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isClientMode", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enableSessionCreation", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "socketAPSelector", "Ljava/util/function/BiFunction;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "engineAPSelector", "Ljava/util/function/BiFunction;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handshakeListeners", "Ljava/util/HashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "noSniExtension", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "noSniMatcher", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "useExtendedMasterSecret", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "allowLegacyResumption", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "allowLegacyMasterSecret", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "useCompatibilityMode", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "acknowledgeCloseNotify", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "maxHandshakeMessageSize", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "maxCertificateChainLength", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/SSLContextImpl;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExclusiveExtensions", "(Lsun/security/ssl/SSLHandshake;Ljava/util/List;)[Lsun/security/ssl/SSLExtension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toggleClientMode", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSSLParameters", "(Ljavax/net/ssl/SSLParameters;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addHandshakeCompletedListener", "(Ljavax/net/ssl/HandshakeCompletedListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSSLParameters", "()Ljavax/net/ssl/SSLParameters;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCustomizedSignatureScheme", "(Ljava/lang/String;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnabledExtensions", "(Lsun/security/ssl/SSLHandshake;)[Lsun/security/ssl/SSLExtension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnabledExtensions", "(Lsun/security/ssl/SSLHandshake;Ljava/util/List;)[Lsun/security/ssl/SSLExtension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnabledExtensions", "(Lsun/security/ssl/SSLHandshake;Lsun/security/ssl/ProtocolVersion;)[Lsun/security/ssl/SSLExtension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeHandshakeCompletedListener", "(Ljavax/net/ssl/HandshakeCompletedListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAvailable", "(Lsun/security/ssl/SSLExtension;Lsun/security/ssl/ProtocolVersion;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAvailable", "(Lsun/security/ssl/SSLExtension;)Z"));
	}

	[JniSignatureAttribute("Ljava/security/AlgorithmConstraints;", "")]
	public Dova.JDK.java.security.AlgorithmConstraints userSpecifiedAlgorithmConstraints_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.AlgorithmConstraints>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "")]
	public Dova.JDK.java.util.List enabledProtocols_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "")]
	public Dova.JDK.java.util.List enabledCipherSuites_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/ClientAuthType;", "")]
	public Dova.JDK.sun.security.ssl.ClientAuthType clientAuthType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.ClientAuthType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String identificationProtocol_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "")]
	public Dova.JDK.java.util.List serverNames_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Collection;", "")]
	public Dova.JDK.java.util.Collection sniMatchers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "")]
	public JavaArray<Dova.JDK.java.lang.String> applicationProtocols_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool preferLocalCipherSuites_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool enableRetransmissions_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int maximumPacketSize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "")]
	public Dova.JDK.java.util.List signatureSchemes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/ProtocolVersion;", "")]
	public Dova.JDK.sun.security.ssl.ProtocolVersion maximumProtocolVersion_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.ProtocolVersion>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool isClientMode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool enableSessionCreation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/function/BiFunction;", "")]
	public Dova.JDK.java.util.function.BiFunction socketAPSelector_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BiFunction>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/function/BiFunction;", "")]
	public Dova.JDK.java.util.function.BiFunction engineAPSelector_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BiFunction>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/HashMap;", "")]
	public Dova.JDK.java.util.HashMap handshakeListeners_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool noSniExtension_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool noSniMatcher_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool useExtendedMasterSecret_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool allowLegacyResumption_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool allowLegacyMasterSecret_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool useCompatibilityMode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool acknowledgeCloseNotify_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[24]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[24], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int maxHandshakeMessageSize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[25]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[25], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int maxCertificateChainLength_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[26]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[26], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SSLConfiguration(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/ssl/SSLContextImpl;Z)V", "")]
	public SSLConfiguration(Dova.JDK.sun.security.ssl.SSLContextImpl arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLConfiguration;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object clone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/SSLHandshake;Ljava/util/List;)[Lsun/security/ssl/SSLExtension;", "")]
	public JavaArray<Dova.JDK.sun.security.ssl.SSLExtension> getExclusiveExtensions(Dova.JDK.sun.security.ssl.SSLHandshake arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.SSLExtension>>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void toggleClientMode()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLParameters;)V", "")]
	public void setSSLParameters(Dova.JDK.javax.net.ssl.SSLParameters arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/HandshakeCompletedListener;)V", "")]
	public void addHandshakeCompletedListener(Dova.JDK.javax.net.ssl.HandshakeCompletedListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()Ljavax/net/ssl/SSLParameters;", "")]
	public Dova.JDK.javax.net.ssl.SSLParameters getSSLParameters()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLParameters>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List getCustomizedSignatureScheme(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/SSLHandshake;)[Lsun/security/ssl/SSLExtension;", "")]
	public JavaArray<Dova.JDK.sun.security.ssl.SSLExtension> getEnabledExtensions(Dova.JDK.sun.security.ssl.SSLHandshake arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.SSLExtension>>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/SSLHandshake;Ljava/util/List;)[Lsun/security/ssl/SSLExtension;", "")]
	public JavaArray<Dova.JDK.sun.security.ssl.SSLExtension> getEnabledExtensions(Dova.JDK.sun.security.ssl.SSLHandshake arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.SSLExtension>>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/SSLHandshake;Lsun/security/ssl/ProtocolVersion;)[Lsun/security/ssl/SSLExtension;", "")]
	public JavaArray<Dova.JDK.sun.security.ssl.SSLExtension> getEnabledExtensions(Dova.JDK.sun.security.ssl.SSLHandshake arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.SSLExtension>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/HandshakeCompletedListener;)V", "")]
	public void removeHandshakeCompletedListener(Dova.JDK.javax.net.ssl.HandshakeCompletedListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/SSLExtension;Lsun/security/ssl/ProtocolVersion;)Z", "")]
	public bool isAvailable(Dova.JDK.sun.security.ssl.SSLExtension arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/security/ssl/SSLExtension;)Z", "")]
	public bool isAvailable(Dova.JDK.sun.security.ssl.SSLExtension arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLConfiguration$CustomizedClientSignatureSchemes;", "private static final")]
	public partial class CustomizedClientSignatureSchemes
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CustomizedClientSignatureSchemes()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLConfiguration$CustomizedClientSignatureSchemes;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "signatureSchemes", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private static final")]
		public static Dova.JDK.java.util.List signatureSchemes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CustomizedClientSignatureSchemes(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public CustomizedClientSignatureSchemes() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLConfiguration$CustomizedClientSignatureSchemes;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLConfiguration$CustomizedServerSignatureSchemes;", "private static final")]
	public partial class CustomizedServerSignatureSchemes
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CustomizedServerSignatureSchemes()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLConfiguration$CustomizedServerSignatureSchemes;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "signatureSchemes", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private static final")]
		public static Dova.JDK.java.util.List signatureSchemes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CustomizedServerSignatureSchemes(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public CustomizedServerSignatureSchemes() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLConfiguration$CustomizedServerSignatureSchemes;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
