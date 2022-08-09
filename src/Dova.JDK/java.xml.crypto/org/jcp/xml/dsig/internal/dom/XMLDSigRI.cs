/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.org.jcp.xml.dsig.@internal.dom;

[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;", "public final")]
public partial class XMLDSigRI
	: Dova.JDK.java.security.Provider
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XMLDSigRI()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "INFO", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "VER", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "XMLDSigRI", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "access$800", "(Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;Ljava/security/Provider$Service;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "access$900", "(Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;Ljava/security/Provider$Service;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "access$1000", "(Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;Ljava/security/Provider$Service;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "access$1100", "(Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;Ljava/security/Provider$Service;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "access$1200", "(Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;Ljava/security/Provider$Service;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "access$400", "(Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;Ljava/security/Provider$Service;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "access$500", "(Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;Ljava/security/Provider$Service;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "access$600", "(Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;Ljava/security/Provider$Service;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "access$700", "(Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;Ljava/security/Provider$Service;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "access$000", "(Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;Ljava/security/Provider$Service;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "access$100", "(Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;Ljava/security/Provider$Service;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "access$200", "(Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;Ljava/security/Provider$Service;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "access$300", "(Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;Ljava/security/Provider$Service;)V"));
	}

	[JniSignatureAttribute("J", "static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String INFO_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String VER_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XMLDSigRI(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public XMLDSigRI() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;Ljava/security/Provider$Service;)V", "static")]
	public static void access_800(Dova.JDK.org.jcp.xml.dsig.@internal.dom.XMLDSigRI arg0, Dova.JDK.java.security.Provider.Service arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;Ljava/security/Provider$Service;)V", "static")]
	public static void access_900(Dova.JDK.org.jcp.xml.dsig.@internal.dom.XMLDSigRI arg0, Dova.JDK.java.security.Provider.Service arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;Ljava/security/Provider$Service;)V", "static")]
	public static void access_1000(Dova.JDK.org.jcp.xml.dsig.@internal.dom.XMLDSigRI arg0, Dova.JDK.java.security.Provider.Service arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;Ljava/security/Provider$Service;)V", "static")]
	public static void access_1100(Dova.JDK.org.jcp.xml.dsig.@internal.dom.XMLDSigRI arg0, Dova.JDK.java.security.Provider.Service arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;Ljava/security/Provider$Service;)V", "static")]
	public static void access_1200(Dova.JDK.org.jcp.xml.dsig.@internal.dom.XMLDSigRI arg0, Dova.JDK.java.security.Provider.Service arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;Ljava/security/Provider$Service;)V", "static")]
	public static void access_400(Dova.JDK.org.jcp.xml.dsig.@internal.dom.XMLDSigRI arg0, Dova.JDK.java.security.Provider.Service arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;Ljava/security/Provider$Service;)V", "static")]
	public static void access_500(Dova.JDK.org.jcp.xml.dsig.@internal.dom.XMLDSigRI arg0, Dova.JDK.java.security.Provider.Service arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;Ljava/security/Provider$Service;)V", "static")]
	public static void access_600(Dova.JDK.org.jcp.xml.dsig.@internal.dom.XMLDSigRI arg0, Dova.JDK.java.security.Provider.Service arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;Ljava/security/Provider$Service;)V", "static")]
	public static void access_700(Dova.JDK.org.jcp.xml.dsig.@internal.dom.XMLDSigRI arg0, Dova.JDK.java.security.Provider.Service arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;Ljava/security/Provider$Service;)V", "static")]
	public static void access_000(Dova.JDK.org.jcp.xml.dsig.@internal.dom.XMLDSigRI arg0, Dova.JDK.java.security.Provider.Service arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
	}

	[JniSignatureAttribute("(Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;Ljava/security/Provider$Service;)V", "static")]
	public static void access_100(Dova.JDK.org.jcp.xml.dsig.@internal.dom.XMLDSigRI arg0, Dova.JDK.java.security.Provider.Service arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("(Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;Ljava/security/Provider$Service;)V", "static")]
	public static void access_200(Dova.JDK.org.jcp.xml.dsig.@internal.dom.XMLDSigRI arg0, Dova.JDK.java.security.Provider.Service arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI;Ljava/security/Provider$Service;)V", "static")]
	public static void access_300(Dova.JDK.org.jcp.xml.dsig.@internal.dom.XMLDSigRI arg0, Dova.JDK.java.security.Provider.Service arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
	}

	[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI$ProviderService;", "private static final")]
	public partial class ProviderService
		: Dova.JDK.java.security.Provider.Service
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ProviderService()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI$ProviderService;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ProviderService", "(Ljava/security/Provider;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/util/Map;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ProviderService", "(Ljava/security/Provider;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ProviderService", "(Ljava/security/Provider;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newInstance", "(Ljava/lang/Object;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ProviderService(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/security/Provider;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/util/Map;)V", "")]
		public ProviderService(Dova.JDK.java.security.Provider arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, JavaArray<Dova.JDK.java.lang.String> arg4, Dova.JDK.java.util.Map arg5) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		[JniSignatureAttribute("(Ljava/security/Provider;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V", "")]
		public ProviderService(Dova.JDK.java.security.Provider arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, JavaArray<Dova.JDK.java.lang.String> arg4) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
		{
		}

		[JniSignatureAttribute("(Ljava/security/Provider;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public ProviderService(Dova.JDK.java.security.Provider arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lorg/jcp/xml/dsig/internal/dom/XMLDSigRI$ProviderService;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object newInstance(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}
}