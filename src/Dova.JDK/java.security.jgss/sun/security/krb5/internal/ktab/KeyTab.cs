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

namespace Dova.JDK.sun.security.krb5.@internal.ktab;

[JniSignatureAttribute("Lsun/security/krb5/internal/ktab/KeyTab;", "public")]
public partial class KeyTab
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.security.krb5.@internal.ktab.KeyTabConstants
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static KeyTab()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/krb5/internal/ktab/KeyTab;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultTabName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "map", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isMissing", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isValid", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tabName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastModified", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "kt_vno", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "entries", "Ljava/util/Vector;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "(Lsun/security/krb5/internal/ktab/KeyTabInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Ljava/lang/String;)Lsun/security/krb5/internal/ktab/KeyTab;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Ljava/io/File;)Lsun/security/krb5/internal/ktab/KeyTab;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "()Lsun/security/krb5/internal/ktab/KeyTab;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "save", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addEntry", "(Lsun/security/krb5/PrincipalName;[CIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addEntry", "(Lsun/security/krb5/PrincipalName;Ljava/lang/String;[CIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "normalize", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Ljava/lang/String;)Lsun/security/krb5/internal/ktab/KeyTab;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "()Lsun/security/krb5/internal/ktab/KeyTab;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEntries", "()[Lsun/security/krb5/internal/ktab/KeyTabEntry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isValid", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tabName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance0", "(Ljava/lang/String;)Lsun/security/krb5/internal/ktab/KeyTab;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDefaultTabName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOneName", "()Lsun/security/krb5/PrincipalName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findServiceEntry", "(Lsun/security/krb5/PrincipalName;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deleteEntries", "(Lsun/security/krb5/PrincipalName;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createVersion", "(Ljava/io/File;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isMissing", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readServiceKeys", "(Lsun/security/krb5/PrincipalName;)[Lsun/security/krb5/EncryptionKey;"));
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool DEBUG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String defaultTabName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static")]
	public static Dova.JDK.java.util.Map map_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool isMissing_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool isValid_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String tabName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long lastModified_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int kt_vno_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/Vector;", "private")]
	public Dova.JDK.java.util.Vector entries_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public KeyTab(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
	public KeyTab(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/krb5/internal/ktab/KeyTab;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/security/krb5/internal/ktab/KeyTabInputStream;)V", "private")]
	public void load(Dova.JDK.sun.security.krb5.@internal.ktab.KeyTabInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/krb5/internal/ktab/KeyTab;", "public static")]
	public static Dova.JDK.sun.security.krb5.@internal.ktab.KeyTab getInstance(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ktab.KeyTab>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Lsun/security/krb5/internal/ktab/KeyTab;", "public static")]
	public static Dova.JDK.sun.security.krb5.@internal.ktab.KeyTab getInstance(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ktab.KeyTab>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/internal/ktab/KeyTab;", "public static")]
	public static Dova.JDK.sun.security.krb5.@internal.ktab.KeyTab getInstance()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ktab.KeyTab>(ret);
	}

	[JniSignatureAttribute("()V", "public synchronized")]
	public void save()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;[CIZ)V", "public")]
	public void addEntry(Dova.JDK.sun.security.krb5.PrincipalName arg0, JavaArray<char> arg1, int arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;Ljava/lang/String;[CIZ)V", "public")]
	public void addEntry(Dova.JDK.sun.security.krb5.PrincipalName arg0, Dova.JDK.java.lang.String arg1, JavaArray<char> arg2, int arg3, bool arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String normalize(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/krb5/internal/ktab/KeyTab;", "public static synchronized")]
	public static Dova.JDK.sun.security.krb5.@internal.ktab.KeyTab create(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ktab.KeyTab>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/internal/ktab/KeyTab;", "public static synchronized")]
	public static Dova.JDK.sun.security.krb5.@internal.ktab.KeyTab create()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ktab.KeyTab>(ret);
	}

	[JniSignatureAttribute("()[Lsun/security/krb5/internal/ktab/KeyTabEntry;", "public")]
	public JavaArray<Dova.JDK.sun.security.krb5.@internal.ktab.KeyTabEntry> getEntries()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.krb5.@internal.ktab.KeyTabEntry>>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isValid()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String tabName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/krb5/internal/ktab/KeyTab;", "private static synchronized")]
	public static Dova.JDK.sun.security.krb5.@internal.ktab.KeyTab getInstance0(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ktab.KeyTab>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String getDefaultTabName()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/PrincipalName;", "public")]
	public Dova.JDK.sun.security.krb5.PrincipalName getOneName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.PrincipalName>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;)Z", "public")]
	public bool findServiceEntry(Dova.JDK.sun.security.krb5.PrincipalName arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;II)I", "public")]
	public int deleteEntries(Dova.JDK.sun.security.krb5.PrincipalName arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/File;)V", "public synchronized")]
	public void createVersion(Dova.JDK.java.io.File arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isMissing()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;)[Lsun/security/krb5/EncryptionKey;", "public")]
	public JavaArray<Dova.JDK.sun.security.krb5.EncryptionKey> readServiceKeys(Dova.JDK.sun.security.krb5.PrincipalName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.krb5.EncryptionKey>>(ret);
	}
}
