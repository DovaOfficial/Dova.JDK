/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.javax.xml.catalog;

[JniSignatureAttribute("Ljavax/xml/catalog/CatalogManager;", "public final")]
public partial class CatalogManager
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CatalogManager()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/xml/catalog/CatalogManager;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CatalogManager", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "catalog", "(Ljavax/xml/catalog/CatalogFeatures;[Ljava/net/URI;)Ljavax/xml/catalog/Catalog;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "catalogResolver", "(Ljavax/xml/catalog/CatalogFeatures;[Ljava/net/URI;)Ljavax/xml/catalog/CatalogResolver;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "catalogResolver", "(Ljavax/xml/catalog/Catalog;)Ljavax/xml/catalog/CatalogResolver;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CatalogManager(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public CatalogManager() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/xml/catalog/CatalogManager;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/xml/catalog/CatalogFeatures;[Ljava/net/URI;)Ljavax/xml/catalog/Catalog;", "public static transient")]
	public static Dova.JDK.javax.xml.catalog.Catalog catalog(Dova.JDK.javax.xml.catalog.CatalogFeatures arg0, JavaArray<Dova.JDK.java.net.URI> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.catalog.Catalog>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/catalog/CatalogFeatures;[Ljava/net/URI;)Ljavax/xml/catalog/CatalogResolver;", "public static transient")]
	public static Dova.JDK.javax.xml.catalog.CatalogResolver catalogResolver(Dova.JDK.javax.xml.catalog.CatalogFeatures arg0, JavaArray<Dova.JDK.java.net.URI> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.catalog.CatalogResolver>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/catalog/Catalog;)Ljavax/xml/catalog/CatalogResolver;", "public static")]
	public static Dova.JDK.javax.xml.catalog.CatalogResolver catalogResolver(Dova.JDK.javax.xml.catalog.Catalog arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.catalog.CatalogResolver>(ret);
	}
}
