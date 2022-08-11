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

namespace Dova.JDK.jdk.@internal.access;

[JniSignatureAttribute("Ljdk/internal/access/SharedSecrets;", "public")]
public partial class SharedSecrets
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SharedSecrets()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/access/SharedSecrets;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaAWTAccess", "Ljdk/internal/access/JavaAWTAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaAWTFontAccess", "Ljdk/internal/access/JavaAWTFontAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaBeansAccess", "Ljdk/internal/access/JavaBeansAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaLangAccess", "Ljdk/internal/access/JavaLangAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaLangInvokeAccess", "Ljdk/internal/access/JavaLangInvokeAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaLangModuleAccess", "Ljdk/internal/access/JavaLangModuleAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaLangRefAccess", "Ljdk/internal/access/JavaLangRefAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaLangReflectAccess", "Ljdk/internal/access/JavaLangReflectAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaIOAccess", "Ljdk/internal/access/JavaIOAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaIOFileDescriptorAccess", "Ljdk/internal/access/JavaIOFileDescriptorAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaIOFilePermissionAccess", "Ljdk/internal/access/JavaIOFilePermissionAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaIORandomAccessFileAccess", "Ljdk/internal/access/JavaIORandomAccessFileAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaObjectInputStreamReadString", "Ljdk/internal/access/JavaObjectInputStreamReadString;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaObjectInputStreamAccess", "Ljdk/internal/access/JavaObjectInputStreamAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaObjectInputFilterAccess", "Ljdk/internal/access/JavaObjectInputFilterAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaNetInetAddressAccess", "Ljdk/internal/access/JavaNetInetAddressAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaNetHttpCookieAccess", "Ljdk/internal/access/JavaNetHttpCookieAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaNetUriAccess", "Ljdk/internal/access/JavaNetUriAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaNetURLAccess", "Ljdk/internal/access/JavaNetURLAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaNioAccess", "Ljdk/internal/access/JavaNioAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaUtilCollectionAccess", "Ljdk/internal/access/JavaUtilCollectionAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaUtilJarAccess", "Ljdk/internal/access/JavaUtilJarAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaUtilZipFileAccess", "Ljdk/internal/access/JavaUtilZipFileAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaUtilResourceBundleAccess", "Ljdk/internal/access/JavaUtilResourceBundleAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaSecurityAccess", "Ljdk/internal/access/JavaSecurityAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaSecuritySignatureAccess", "Ljdk/internal/access/JavaSecuritySignatureAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaSecuritySpecAccess", "Ljdk/internal/access/JavaSecuritySpecAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaxCryptoSealedObjectAccess", "Ljdk/internal/access/JavaxCryptoSealedObjectAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaxCryptoSpecAccess", "Ljdk/internal/access/JavaxCryptoSpecAccess;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaIOAccess", "()Ljdk/internal/access/JavaIOAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaLangAccess", "(Ljdk/internal/access/JavaLangAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ensureClassInitialized", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaSecurityAccess", "(Ljdk/internal/access/JavaSecurityAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaLangRefAccess", "(Ljdk/internal/access/JavaLangRefAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaObjectInputStreamAccess", "()Ljdk/internal/access/JavaObjectInputStreamAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaLangReflectAccess", "(Ljdk/internal/access/JavaLangReflectAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaLangAccess", "()Ljdk/internal/access/JavaLangAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaLangModuleAccess", "()Ljdk/internal/access/JavaLangModuleAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaNetURLAccess", "(Ljdk/internal/access/JavaNetURLAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "javaUtilJarAccess", "()Ljdk/internal/access/JavaUtilJarAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaNioAccess", "(Ljdk/internal/access/JavaNioAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaLangInvokeAccess", "()Ljdk/internal/access/JavaLangInvokeAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaUtilCollectionAccess", "(Ljdk/internal/access/JavaUtilCollectionAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaUtilCollectionAccess", "()Ljdk/internal/access/JavaUtilCollectionAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaUtilJarAccess", "(Ljdk/internal/access/JavaUtilJarAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaLangInvokeAccess", "(Ljdk/internal/access/JavaLangInvokeAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaLangModuleAccess", "(Ljdk/internal/access/JavaLangModuleAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaLangRefAccess", "()Ljdk/internal/access/JavaLangRefAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaLangReflectAccess", "()Ljdk/internal/access/JavaLangReflectAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaNetUriAccess", "(Ljdk/internal/access/JavaNetUriAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaNetUriAccess", "()Ljdk/internal/access/JavaNetUriAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaNetURLAccess", "()Ljdk/internal/access/JavaNetURLAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaNetInetAddressAccess", "(Ljdk/internal/access/JavaNetInetAddressAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaNetInetAddressAccess", "()Ljdk/internal/access/JavaNetInetAddressAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaNetHttpCookieAccess", "(Ljdk/internal/access/JavaNetHttpCookieAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaNetHttpCookieAccess", "()Ljdk/internal/access/JavaNetHttpCookieAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaNioAccess", "()Ljdk/internal/access/JavaNioAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaIOAccess", "(Ljdk/internal/access/JavaIOAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaIOFileDescriptorAccess", "(Ljdk/internal/access/JavaIOFileDescriptorAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaIOFilePermissionAccess", "()Ljdk/internal/access/JavaIOFilePermissionAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaIOFilePermissionAccess", "(Ljdk/internal/access/JavaIOFilePermissionAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaIOFileDescriptorAccess", "()Ljdk/internal/access/JavaIOFileDescriptorAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaSecurityAccess", "()Ljdk/internal/access/JavaSecurityAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaUtilZipFileAccess", "()Ljdk/internal/access/JavaUtilZipFileAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaUtilZipFileAccess", "(Ljdk/internal/access/JavaUtilZipFileAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaAWTAccess", "(Ljdk/internal/access/JavaAWTAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaAWTAccess", "()Ljdk/internal/access/JavaAWTAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaAWTFontAccess", "(Ljdk/internal/access/JavaAWTFontAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaAWTFontAccess", "()Ljdk/internal/access/JavaAWTFontAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaBeansAccess", "()Ljdk/internal/access/JavaBeansAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaBeansAccess", "(Ljdk/internal/access/JavaBeansAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaUtilResourceBundleAccess", "()Ljdk/internal/access/JavaUtilResourceBundleAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaUtilResourceBundleAccess", "(Ljdk/internal/access/JavaUtilResourceBundleAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaObjectInputStreamReadString", "()Ljdk/internal/access/JavaObjectInputStreamReadString;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaObjectInputStreamReadString", "(Ljdk/internal/access/JavaObjectInputStreamReadString;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaObjectInputStreamAccess", "(Ljdk/internal/access/JavaObjectInputStreamAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaObjectInputFilterAccess", "()Ljdk/internal/access/JavaObjectInputFilterAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaObjectInputFilterAccess", "(Ljdk/internal/access/JavaObjectInputFilterAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaIORandomAccessFileAccess", "(Ljdk/internal/access/JavaIORandomAccessFileAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaIORandomAccessFileAccess", "()Ljdk/internal/access/JavaIORandomAccessFileAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaSecuritySignatureAccess", "(Ljdk/internal/access/JavaSecuritySignatureAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaSecuritySignatureAccess", "()Ljdk/internal/access/JavaSecuritySignatureAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaSecuritySpecAccess", "(Ljdk/internal/access/JavaSecuritySpecAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaSecuritySpecAccess", "()Ljdk/internal/access/JavaSecuritySpecAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaxCryptoSpecAccess", "(Ljdk/internal/access/JavaxCryptoSpecAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaxCryptoSpecAccess", "()Ljdk/internal/access/JavaxCryptoSpecAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaxCryptoSealedObjectAccess", "(Ljdk/internal/access/JavaxCryptoSealedObjectAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaxCryptoSealedObjectAccess", "()Ljdk/internal/access/JavaxCryptoSealedObjectAccess;"));
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaAWTAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaAWTAccess javaAWTAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaAWTAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaAWTFontAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaAWTFontAccess javaAWTFontAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaAWTFontAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaBeansAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaBeansAccess javaBeansAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaBeansAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaLangAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaLangAccess javaLangAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaLangAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaLangInvokeAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaLangInvokeAccess javaLangInvokeAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaLangInvokeAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaLangModuleAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaLangModuleAccess javaLangModuleAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaLangModuleAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaLangRefAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaLangRefAccess javaLangRefAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaLangRefAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaLangReflectAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaLangReflectAccess javaLangReflectAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaLangReflectAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaIOAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaIOAccess javaIOAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaIOAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaIOFileDescriptorAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaIOFileDescriptorAccess javaIOFileDescriptorAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaIOFileDescriptorAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaIOFilePermissionAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaIOFilePermissionAccess javaIOFilePermissionAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaIOFilePermissionAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaIORandomAccessFileAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaIORandomAccessFileAccess javaIORandomAccessFileAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaIORandomAccessFileAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaObjectInputStreamReadString;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaObjectInputStreamReadString javaObjectInputStreamReadString_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaObjectInputStreamReadString>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaObjectInputStreamAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaObjectInputStreamAccess javaObjectInputStreamAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaObjectInputStreamAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaObjectInputFilterAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaObjectInputFilterAccess javaObjectInputFilterAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaObjectInputFilterAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaNetInetAddressAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaNetInetAddressAccess javaNetInetAddressAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaNetInetAddressAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaNetHttpCookieAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaNetHttpCookieAccess javaNetHttpCookieAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaNetHttpCookieAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaNetUriAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaNetUriAccess javaNetUriAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaNetUriAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaNetURLAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaNetURLAccess javaNetURLAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaNetURLAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaNioAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaNioAccess javaNioAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaNioAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaUtilCollectionAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaUtilCollectionAccess javaUtilCollectionAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaUtilCollectionAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaUtilJarAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaUtilJarAccess javaUtilJarAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaUtilJarAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaUtilZipFileAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaUtilZipFileAccess javaUtilZipFileAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaUtilZipFileAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaUtilResourceBundleAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaUtilResourceBundleAccess javaUtilResourceBundleAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaUtilResourceBundleAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaSecurityAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaSecurityAccess javaSecurityAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaSecurityAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaSecuritySignatureAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaSecuritySignatureAccess javaSecuritySignatureAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaSecuritySignatureAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaSecuritySpecAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaSecuritySpecAccess javaSecuritySpecAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaSecuritySpecAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaxCryptoSealedObjectAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaxCryptoSealedObjectAccess javaxCryptoSealedObjectAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaxCryptoSealedObjectAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaxCryptoSpecAccess;", "private static")]
	public static Dova.JDK.jdk.@internal.access.JavaxCryptoSpecAccess javaxCryptoSpecAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaxCryptoSpecAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SharedSecrets(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SharedSecrets() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/access/SharedSecrets;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljdk/internal/access/JavaIOAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaIOAccess getJavaIOAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaIOAccess>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaLangAccess;)V", "public static")]
	public static void setJavaLangAccess(Dova.JDK.jdk.@internal.access.JavaLangAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "private static")]
	public static void ensureClassInitialized(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaSecurityAccess;)V", "public static")]
	public static void setJavaSecurityAccess(Dova.JDK.jdk.@internal.access.JavaSecurityAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaLangRefAccess;)V", "public static")]
	public static void setJavaLangRefAccess(Dova.JDK.jdk.@internal.access.JavaLangRefAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaObjectInputStreamAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaObjectInputStreamAccess getJavaObjectInputStreamAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaObjectInputStreamAccess>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaLangReflectAccess;)V", "public static")]
	public static void setJavaLangReflectAccess(Dova.JDK.jdk.@internal.access.JavaLangReflectAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaLangAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaLangAccess getJavaLangAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaLangAccess>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaLangModuleAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaLangModuleAccess getJavaLangModuleAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaLangModuleAccess>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaNetURLAccess;)V", "public static")]
	public static void setJavaNetURLAccess(Dova.JDK.jdk.@internal.access.JavaNetURLAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaUtilJarAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaUtilJarAccess javaUtilJarAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaUtilJarAccess>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaNioAccess;)V", "public static")]
	public static void setJavaNioAccess(Dova.JDK.jdk.@internal.access.JavaNioAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaLangInvokeAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaLangInvokeAccess getJavaLangInvokeAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaLangInvokeAccess>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaUtilCollectionAccess;)V", "public static")]
	public static void setJavaUtilCollectionAccess(Dova.JDK.jdk.@internal.access.JavaUtilCollectionAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaUtilCollectionAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaUtilCollectionAccess getJavaUtilCollectionAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaUtilCollectionAccess>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaUtilJarAccess;)V", "public static")]
	public static void setJavaUtilJarAccess(Dova.JDK.jdk.@internal.access.JavaUtilJarAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaLangInvokeAccess;)V", "public static")]
	public static void setJavaLangInvokeAccess(Dova.JDK.jdk.@internal.access.JavaLangInvokeAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaLangModuleAccess;)V", "public static")]
	public static void setJavaLangModuleAccess(Dova.JDK.jdk.@internal.access.JavaLangModuleAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaLangRefAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaLangRefAccess getJavaLangRefAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaLangRefAccess>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaLangReflectAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaLangReflectAccess getJavaLangReflectAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaLangReflectAccess>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaNetUriAccess;)V", "public static")]
	public static void setJavaNetUriAccess(Dova.JDK.jdk.@internal.access.JavaNetUriAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaNetUriAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaNetUriAccess getJavaNetUriAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaNetUriAccess>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaNetURLAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaNetURLAccess getJavaNetURLAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaNetURLAccess>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaNetInetAddressAccess;)V", "public static")]
	public static void setJavaNetInetAddressAccess(Dova.JDK.jdk.@internal.access.JavaNetInetAddressAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaNetInetAddressAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaNetInetAddressAccess getJavaNetInetAddressAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaNetInetAddressAccess>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaNetHttpCookieAccess;)V", "public static")]
	public static void setJavaNetHttpCookieAccess(Dova.JDK.jdk.@internal.access.JavaNetHttpCookieAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaNetHttpCookieAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaNetHttpCookieAccess getJavaNetHttpCookieAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaNetHttpCookieAccess>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaNioAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaNioAccess getJavaNioAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaNioAccess>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaIOAccess;)V", "public static")]
	public static void setJavaIOAccess(Dova.JDK.jdk.@internal.access.JavaIOAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaIOFileDescriptorAccess;)V", "public static")]
	public static void setJavaIOFileDescriptorAccess(Dova.JDK.jdk.@internal.access.JavaIOFileDescriptorAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[29], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaIOFilePermissionAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaIOFilePermissionAccess getJavaIOFilePermissionAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaIOFilePermissionAccess>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaIOFilePermissionAccess;)V", "public static")]
	public static void setJavaIOFilePermissionAccess(Dova.JDK.jdk.@internal.access.JavaIOFilePermissionAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[31], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaIOFileDescriptorAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaIOFileDescriptorAccess getJavaIOFileDescriptorAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaIOFileDescriptorAccess>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaSecurityAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaSecurityAccess getJavaSecurityAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaSecurityAccess>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaUtilZipFileAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaUtilZipFileAccess getJavaUtilZipFileAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaUtilZipFileAccess>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaUtilZipFileAccess;)V", "public static")]
	public static void setJavaUtilZipFileAccess(Dova.JDK.jdk.@internal.access.JavaUtilZipFileAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaAWTAccess;)V", "public static")]
	public static void setJavaAWTAccess(Dova.JDK.jdk.@internal.access.JavaAWTAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[36], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaAWTAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaAWTAccess getJavaAWTAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaAWTAccess>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaAWTFontAccess;)V", "public static")]
	public static void setJavaAWTFontAccess(Dova.JDK.jdk.@internal.access.JavaAWTFontAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaAWTFontAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaAWTFontAccess getJavaAWTFontAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[39]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaAWTFontAccess>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaBeansAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaBeansAccess getJavaBeansAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[40]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaBeansAccess>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaBeansAccess;)V", "public static")]
	public static void setJavaBeansAccess(Dova.JDK.jdk.@internal.access.JavaBeansAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[41], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaUtilResourceBundleAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaUtilResourceBundleAccess getJavaUtilResourceBundleAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[42]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaUtilResourceBundleAccess>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaUtilResourceBundleAccess;)V", "public static")]
	public static void setJavaUtilResourceBundleAccess(Dova.JDK.jdk.@internal.access.JavaUtilResourceBundleAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[43], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaObjectInputStreamReadString;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaObjectInputStreamReadString getJavaObjectInputStreamReadString()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[44]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaObjectInputStreamReadString>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaObjectInputStreamReadString;)V", "public static")]
	public static void setJavaObjectInputStreamReadString(Dova.JDK.jdk.@internal.access.JavaObjectInputStreamReadString arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[45], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaObjectInputStreamAccess;)V", "public static")]
	public static void setJavaObjectInputStreamAccess(Dova.JDK.jdk.@internal.access.JavaObjectInputStreamAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[46], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaObjectInputFilterAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaObjectInputFilterAccess getJavaObjectInputFilterAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[47]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaObjectInputFilterAccess>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaObjectInputFilterAccess;)V", "public static")]
	public static void setJavaObjectInputFilterAccess(Dova.JDK.jdk.@internal.access.JavaObjectInputFilterAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[48], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaIORandomAccessFileAccess;)V", "public static")]
	public static void setJavaIORandomAccessFileAccess(Dova.JDK.jdk.@internal.access.JavaIORandomAccessFileAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[49], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaIORandomAccessFileAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaIORandomAccessFileAccess getJavaIORandomAccessFileAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[50]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaIORandomAccessFileAccess>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaSecuritySignatureAccess;)V", "public static")]
	public static void setJavaSecuritySignatureAccess(Dova.JDK.jdk.@internal.access.JavaSecuritySignatureAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[51], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaSecuritySignatureAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaSecuritySignatureAccess getJavaSecuritySignatureAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[52]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaSecuritySignatureAccess>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaSecuritySpecAccess;)V", "public static")]
	public static void setJavaSecuritySpecAccess(Dova.JDK.jdk.@internal.access.JavaSecuritySpecAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[53], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaSecuritySpecAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaSecuritySpecAccess getJavaSecuritySpecAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[54]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaSecuritySpecAccess>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaxCryptoSpecAccess;)V", "public static")]
	public static void setJavaxCryptoSpecAccess(Dova.JDK.jdk.@internal.access.JavaxCryptoSpecAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[55], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaxCryptoSpecAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaxCryptoSpecAccess getJavaxCryptoSpecAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[56]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaxCryptoSpecAccess>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/access/JavaxCryptoSealedObjectAccess;)V", "public static")]
	public static void setJavaxCryptoSealedObjectAccess(Dova.JDK.jdk.@internal.access.JavaxCryptoSealedObjectAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[57], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaxCryptoSealedObjectAccess;", "public static")]
	public static Dova.JDK.jdk.@internal.access.JavaxCryptoSealedObjectAccess getJavaxCryptoSealedObjectAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[58]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaxCryptoSealedObjectAccess>(ret);
	}
}
