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

namespace Dova.JDK.com.sun.jndi.toolkit.dir;

[JniSignatureAttribute("Lcom/sun/jndi/toolkit/dir/HierMemDirCtx;", "public")]
public partial class HierMemDirCtx
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.naming.directory.DirContext
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HierMemDirCtx()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jndi/toolkit/dir/HierMemDirCtx;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "debug", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultParser", "Ljavax/naming/NameParser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "myEnv", "Ljava/util/Hashtable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bindings", "Ljava/util/Hashtable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attrs", "Ljavax/naming/directory/Attributes;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ignoreCase", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readOnlyEx", "Ljavax/naming/NamingException;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "myParser", "Ljavax/naming/NameParser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "alwaysUseFactory", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Hashtable;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Hashtable;ZZ)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "list", "(Ljavax/naming/Name;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "list", "(Ljava/lang/String;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookup", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookup", "(Ljavax/naming/Name;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setReadOnly", "(Ljavax/naming/NamingException;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rebind", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rebind", "(Ljavax/naming/Name;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rebind", "(Ljava/lang/String;Ljava/lang/Object;Ljavax/naming/directory/Attributes;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rebind", "(Ljavax/naming/Name;Ljava/lang/Object;Ljavax/naming/directory/Attributes;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "(Ljava/lang/String;[Ljava/lang/String;)Ljavax/naming/directory/Attributes;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "(Ljavax/naming/Name;[Ljava/lang/String;)Ljavax/naming/directory/Attributes;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "(Ljavax/naming/Name;)Ljavax/naming/directory/Attributes;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "(Ljava/lang/String;)Ljavax/naming/directory/Attributes;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "search", "(Ljavax/naming/Name;Ljava/lang/String;[Ljava/lang/Object;Ljavax/naming/directory/SearchControls;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "search", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljavax/naming/directory/SearchControls;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "search", "(Ljava/lang/String;Ljava/lang/String;Ljavax/naming/directory/SearchControls;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "search", "(Ljavax/naming/Name;Ljavax/naming/directory/Attributes;[Ljava/lang/String;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "search", "(Ljava/lang/String;Ljavax/naming/directory/Attributes;[Ljava/lang/String;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "search", "(Ljavax/naming/Name;Ljava/lang/String;Ljavax/naming/directory/SearchControls;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "search", "(Ljava/lang/String;Ljavax/naming/directory/Attributes;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "search", "(Ljavax/naming/Name;Ljavax/naming/directory/Attributes;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Ljavax/naming/Name;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Ljavax/naming/Name;Ljava/lang/Object;Ljavax/naming/directory/Attributes;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Ljava/lang/String;Ljava/lang/Object;Ljavax/naming/directory/Attributes;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rename", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rename", "(Ljavax/naming/Name;Ljavax/naming/Name;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInternalName", "(Ljavax/naming/Name;)Ljavax/naming/Name;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addToEnvironment", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSchema", "(Ljavax/naming/Name;)Ljavax/naming/directory/DirContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSchema", "(Ljava/lang/String;)Ljavax/naming/directory/DirContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doLookup", "(Ljavax/naming/Name;Z)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modifyAttributes", "(Ljavax/naming/Name;[Ljavax/naming/directory/ModificationItem;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modifyAttributes", "(Ljava/lang/String;[Ljavax/naming/directory/ModificationItem;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modifyAttributes", "(Ljava/lang/String;ILjavax/naming/directory/Attributes;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modifyAttributes", "(Ljavax/naming/Name;ILjavax/naming/directory/Attributes;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createSubcontext", "(Ljavax/naming/Name;Ljavax/naming/directory/Attributes;)Ljavax/naming/directory/DirContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createSubcontext", "(Ljava/lang/String;Ljavax/naming/directory/Attributes;)Ljavax/naming/directory/DirContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createSubcontext", "(Ljavax/naming/Name;)Ljavax/naming/Context;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createSubcontext", "(Ljava/lang/String;)Ljavax/naming/Context;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSchemaClassDefinition", "(Ljava/lang/String;)Ljavax/naming/directory/DirContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSchemaClassDefinition", "(Ljavax/naming/Name;)Ljavax/naming/directory/DirContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unbind", "(Ljavax/naming/Name;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unbind", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listBindings", "(Ljava/lang/String;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listBindings", "(Ljavax/naming/Name;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "destroySubcontext", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "destroySubcontext", "(Ljavax/naming/Name;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupLink", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupLink", "(Ljavax/naming/Name;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNameParser", "(Ljavax/naming/Name;)Ljavax/naming/NameParser;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNameParser", "(Ljava/lang/String;)Ljavax/naming/NameParser;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "composeName", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "composeName", "(Ljavax/naming/Name;Ljavax/naming/Name;)Ljavax/naming/Name;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeFromEnvironment", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnvironment", "()Ljava/util/Hashtable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNameInNamespace", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canonizeName", "(Ljavax/naming/Name;)Ljavax/naming/Name;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doBind", "(Ljavax/naming/Name;Ljava/lang/Object;Ljavax/naming/directory/Attributes;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLeafName", "(Ljavax/naming/Name;)Ljavax/naming/Name;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doBindAux", "(Ljavax/naming/Name;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doRebind", "(Ljavax/naming/Name;Ljava/lang/Object;Ljavax/naming/directory/Attributes;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doRebindAux", "(Ljavax/naming/Name;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doUnbind", "(Ljavax/naming/Name;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doRename", "(Ljavax/naming/Name;Ljavax/naming/Name;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doList", "()Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doListBindings", "(Z)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doDestroySubcontext", "(Ljavax/naming/Name;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doCreateSubcontext", "(Ljavax/naming/Name;Ljavax/naming/directory/Attributes;)Ljavax/naming/directory/DirContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createNewCtx", "()Lcom/sun/jndi/toolkit/dir/HierMemDirCtx;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doGetAttributes", "([Ljava/lang/String;)Ljavax/naming/directory/Attributes;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doGetAttributes", "()Ljavax/naming/directory/Attributes;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doModifyAttributes", "([Ljavax/naming/directory/ModificationItem;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "applyMods", "([Ljavax/naming/directory/ModificationItem;Ljavax/naming/directory/Attributes;)Ljavax/naming/directory/Attributes;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setIgnoreCase", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNameParser", "(Ljavax/naming/NameParser;)V"));
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool debug_Property
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

	[JniSignatureAttribute("Ljavax/naming/NameParser;", "private static final")]
	public static Dova.JDK.javax.naming.NameParser defaultParser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NameParser>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Hashtable;", "protected")]
	public Dova.JDK.java.util.Hashtable myEnv_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Hashtable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Hashtable;", "protected")]
	public Dova.JDK.java.util.Hashtable bindings_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Hashtable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/naming/directory/Attributes;", "protected")]
	public Dova.JDK.javax.naming.directory.Attributes attrs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.Attributes>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool ignoreCase_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("Ljavax/naming/NamingException;", "protected")]
	public Dova.JDK.javax.naming.NamingException readOnlyEx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingException>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/naming/NameParser;", "protected")]
	public Dova.JDK.javax.naming.NameParser myParser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NameParser>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool alwaysUseFactory_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HierMemDirCtx(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/util/Hashtable;Z)V", "public")]
	public HierMemDirCtx(Dova.JDK.java.util.Hashtable arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public HierMemDirCtx() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1]))
	{
	}

	[JniSignatureAttribute("(Ljava/util/Hashtable;ZZ)V", "protected")]
	public HierMemDirCtx(Dova.JDK.java.util.Hashtable arg0, bool arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public HierMemDirCtx(bool arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jndi/toolkit/dir/HierMemDirCtx;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/naming/Name;)Ljavax/naming/NamingEnumeration;", "public")]
	public Dova.JDK.javax.naming.NamingEnumeration list(Dova.JDK.javax.naming.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/naming/NamingEnumeration;", "public")]
	public Dova.JDK.javax.naming.NamingEnumeration list(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object lookup(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object lookup(Dova.JDK.javax.naming.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void init()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(Ljavax/naming/NamingException;)V", "public")]
	public void setReadOnly(Dova.JDK.javax.naming.NamingException arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public")]
	public void rebind(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/Object;)V", "public")]
	public void rebind(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;Ljavax/naming/directory/Attributes;)V", "public")]
	public void rebind(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.javax.naming.directory.Attributes arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/Object;Ljavax/naming/directory/Attributes;)V", "public")]
	public void rebind(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.javax.naming.directory.Attributes arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/String;)Ljavax/naming/directory/Attributes;", "public")]
	public Dova.JDK.javax.naming.directory.Attributes getAttributes(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.Attributes>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;[Ljava/lang/String;)Ljavax/naming/directory/Attributes;", "public")]
	public Dova.JDK.javax.naming.directory.Attributes getAttributes(Dova.JDK.javax.naming.Name arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.Attributes>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)Ljavax/naming/directory/Attributes;", "public")]
	public Dova.JDK.javax.naming.directory.Attributes getAttributes(Dova.JDK.javax.naming.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.Attributes>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/naming/directory/Attributes;", "public")]
	public Dova.JDK.javax.naming.directory.Attributes getAttributes(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.Attributes>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/String;[Ljava/lang/Object;Ljavax/naming/directory/SearchControls;)Ljavax/naming/NamingEnumeration;", "public")]
	public Dova.JDK.javax.naming.NamingEnumeration search(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, Dova.JDK.javax.naming.directory.SearchControls arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljavax/naming/directory/SearchControls;)Ljavax/naming/NamingEnumeration;", "public")]
	public Dova.JDK.javax.naming.NamingEnumeration search(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, Dova.JDK.javax.naming.directory.SearchControls arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljavax/naming/directory/SearchControls;)Ljavax/naming/NamingEnumeration;", "public")]
	public Dova.JDK.javax.naming.NamingEnumeration search(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.naming.directory.SearchControls arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljavax/naming/directory/Attributes;[Ljava/lang/String;)Ljavax/naming/NamingEnumeration;", "public")]
	public Dova.JDK.javax.naming.NamingEnumeration search(Dova.JDK.javax.naming.Name arg0, Dova.JDK.javax.naming.directory.Attributes arg1, JavaArray<Dova.JDK.java.lang.String> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/naming/directory/Attributes;[Ljava/lang/String;)Ljavax/naming/NamingEnumeration;", "public")]
	public Dova.JDK.javax.naming.NamingEnumeration search(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.naming.directory.Attributes arg1, JavaArray<Dova.JDK.java.lang.String> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/String;Ljavax/naming/directory/SearchControls;)Ljavax/naming/NamingEnumeration;", "public")]
	public Dova.JDK.javax.naming.NamingEnumeration search(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.naming.directory.SearchControls arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/naming/directory/Attributes;)Ljavax/naming/NamingEnumeration;", "public")]
	public Dova.JDK.javax.naming.NamingEnumeration search(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.naming.directory.Attributes arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljavax/naming/directory/Attributes;)Ljavax/naming/NamingEnumeration;", "public")]
	public Dova.JDK.javax.naming.NamingEnumeration search(Dova.JDK.javax.naming.Name arg0, Dova.JDK.javax.naming.directory.Attributes arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public")]
	public void bind(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/Object;)V", "public")]
	public void bind(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/Object;Ljavax/naming/directory/Attributes;)V", "public")]
	public void bind(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.javax.naming.directory.Attributes arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;Ljavax/naming/directory/Attributes;)V", "public")]
	public void bind(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.javax.naming.directory.Attributes arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void rename(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljavax/naming/Name;)V", "public")]
	public void rename(Dova.JDK.javax.naming.Name arg0, Dova.JDK.javax.naming.Name arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)Ljavax/naming/Name;", "protected")]
	public Dova.JDK.javax.naming.Name getInternalName(Dova.JDK.javax.naming.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.Name>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object addToEnvironment(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)Ljavax/naming/directory/DirContext;", "public")]
	public Dova.JDK.javax.naming.directory.DirContext getSchema(Dova.JDK.javax.naming.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.DirContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/naming/directory/DirContext;", "public")]
	public Dova.JDK.javax.naming.directory.DirContext getSchema(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.DirContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Z)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object doLookup(Dova.JDK.javax.naming.Name arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;[Ljavax/naming/directory/ModificationItem;)V", "public")]
	public void modifyAttributes(Dova.JDK.javax.naming.Name arg0, JavaArray<Dova.JDK.javax.naming.directory.ModificationItem> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljavax/naming/directory/ModificationItem;)V", "public")]
	public void modifyAttributes(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.javax.naming.directory.ModificationItem> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjavax/naming/directory/Attributes;)V", "public")]
	public void modifyAttributes(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.javax.naming.directory.Attributes arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;ILjavax/naming/directory/Attributes;)V", "public")]
	public void modifyAttributes(Dova.JDK.javax.naming.Name arg0, int arg1, Dova.JDK.javax.naming.directory.Attributes arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljavax/naming/directory/Attributes;)Ljavax/naming/directory/DirContext;", "public")]
	public Dova.JDK.javax.naming.directory.DirContext createSubcontext(Dova.JDK.javax.naming.Name arg0, Dova.JDK.javax.naming.directory.Attributes arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.DirContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/naming/directory/Attributes;)Ljavax/naming/directory/DirContext;", "public")]
	public Dova.JDK.javax.naming.directory.DirContext createSubcontext(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.naming.directory.Attributes arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.DirContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)Ljavax/naming/Context;", "public")]
	public Dova.JDK.javax.naming.Context createSubcontext(Dova.JDK.javax.naming.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.Context>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/naming/Context;", "public")]
	public Dova.JDK.javax.naming.Context createSubcontext(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.Context>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/naming/directory/DirContext;", "public")]
	public Dova.JDK.javax.naming.directory.DirContext getSchemaClassDefinition(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.DirContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)Ljavax/naming/directory/DirContext;", "public")]
	public Dova.JDK.javax.naming.directory.DirContext getSchemaClassDefinition(Dova.JDK.javax.naming.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.DirContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)V", "public")]
	public void unbind(Dova.JDK.javax.naming.Name arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void unbind(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/naming/NamingEnumeration;", "public")]
	public Dova.JDK.javax.naming.NamingEnumeration listBindings(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)Ljavax/naming/NamingEnumeration;", "public")]
	public Dova.JDK.javax.naming.NamingEnumeration listBindings(Dova.JDK.javax.naming.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void destroySubcontext(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)V", "public")]
	public void destroySubcontext(Dova.JDK.javax.naming.Name arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object lookupLink(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object lookupLink(Dova.JDK.javax.naming.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)Ljavax/naming/NameParser;", "public")]
	public Dova.JDK.javax.naming.NameParser getNameParser(Dova.JDK.javax.naming.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NameParser>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/naming/NameParser;", "public")]
	public Dova.JDK.javax.naming.NameParser getNameParser(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NameParser>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String composeName(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljavax/naming/Name;)Ljavax/naming/Name;", "public")]
	public Dova.JDK.javax.naming.Name composeName(Dova.JDK.javax.naming.Name arg0, Dova.JDK.javax.naming.Name arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.Name>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object removeFromEnvironment(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Hashtable;", "public")]
	public Dova.JDK.java.util.Hashtable getEnvironment()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Hashtable>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getNameInNamespace()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)Ljavax/naming/Name;", "protected")]
	public Dova.JDK.javax.naming.Name canonizeName(Dova.JDK.javax.naming.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.Name>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/Object;Ljavax/naming/directory/Attributes;Z)V", "protected")]
	public void doBind(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.javax.naming.directory.Attributes arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[60], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)Ljavax/naming/Name;", "protected")]
	public Dova.JDK.javax.naming.Name getLeafName(Dova.JDK.javax.naming.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.Name>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/Object;)V", "protected")]
	public void doBindAux(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[62], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/Object;Ljavax/naming/directory/Attributes;Z)V", "protected")]
	public void doRebind(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.javax.naming.directory.Attributes arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[63], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/Object;)V", "protected")]
	public void doRebindAux(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[64], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)V", "protected")]
	public void doUnbind(Dova.JDK.javax.naming.Name arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljavax/naming/Name;)V", "protected")]
	public void doRename(Dova.JDK.javax.naming.Name arg0, Dova.JDK.javax.naming.Name arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[66], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljavax/naming/NamingEnumeration;", "protected")]
	public Dova.JDK.javax.naming.NamingEnumeration doList()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Z)Ljavax/naming/NamingEnumeration;", "protected")]
	public Dova.JDK.javax.naming.NamingEnumeration doListBindings(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[68], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)V", "protected")]
	public void doDestroySubcontext(Dova.JDK.javax.naming.Name arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[69], arg0);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljavax/naming/directory/Attributes;)Ljavax/naming/directory/DirContext;", "protected")]
	public Dova.JDK.javax.naming.directory.DirContext doCreateSubcontext(Dova.JDK.javax.naming.Name arg0, Dova.JDK.javax.naming.directory.Attributes arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[70], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.DirContext>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jndi/toolkit/dir/HierMemDirCtx;", "protected")]
	public Dova.JDK.com.sun.jndi.toolkit.dir.HierMemDirCtx createNewCtx()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[71]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.toolkit.dir.HierMemDirCtx>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)Ljavax/naming/directory/Attributes;", "protected")]
	public Dova.JDK.javax.naming.directory.Attributes doGetAttributes(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[72], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.Attributes>(ret);
	}

	[JniSignatureAttribute("()Ljavax/naming/directory/Attributes;", "protected")]
	public Dova.JDK.javax.naming.directory.Attributes doGetAttributes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[73]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.Attributes>(ret);
	}

	[JniSignatureAttribute("([Ljavax/naming/directory/ModificationItem;)V", "protected")]
	public void doModifyAttributes(JavaArray<Dova.JDK.javax.naming.directory.ModificationItem> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[74], arg0);
	}

	[JniSignatureAttribute("([Ljavax/naming/directory/ModificationItem;Ljavax/naming/directory/Attributes;)Ljavax/naming/directory/Attributes;", "protected static")]
	public static Dova.JDK.javax.naming.directory.Attributes applyMods(JavaArray<Dova.JDK.javax.naming.directory.ModificationItem> arg0, Dova.JDK.javax.naming.directory.Attributes arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[75], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.Attributes>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setIgnoreCase(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[76], arg0);
	}

	[JniSignatureAttribute("(Ljavax/naming/NameParser;)V", "public")]
	public void setNameParser(Dova.JDK.javax.naming.NameParser arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[77], arg0);
	}

	[JniSignatureAttribute("Lcom/sun/jndi/toolkit/dir/HierMemDirCtx$FlatNames;", "private final")]
	public partial class FlatNames
		: Dova.JDK.com.sun.jndi.toolkit.dir.HierMemDirCtx.BaseFlatNames
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FlatNames()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jndi/toolkit/dir/HierMemDirCtx$FlatNames;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/jndi/toolkit/dir/HierMemDirCtx;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jndi/toolkit/dir/HierMemDirCtx;Ljava/util/Enumeration;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_0", "()Ljavax/naming/NameClassPair;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_1", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Lcom/sun/jndi/toolkit/dir/HierMemDirCtx;", "final")]
		public Dova.JDK.com.sun.jndi.toolkit.dir.HierMemDirCtx this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.toolkit.dir.HierMemDirCtx>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FlatNames(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/jndi/toolkit/dir/HierMemDirCtx;Ljava/util/Enumeration;)V", "")]
		public FlatNames(Dova.JDK.com.sun.jndi.toolkit.dir.HierMemDirCtx arg0, Dova.JDK.java.util.Enumeration arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jndi/toolkit/dir/HierMemDirCtx$FlatNames;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljavax/naming/NameClassPair;", "public")]
		public Dova.JDK.javax.naming.NameClassPair next_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NameClassPair>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object next_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jndi/toolkit/dir/HierMemDirCtx$FlatBindings;", "private final")]
	public partial class FlatBindings
		: Dova.JDK.com.sun.jndi.toolkit.dir.HierMemDirCtx.BaseFlatNames
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FlatBindings()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jndi/toolkit/dir/HierMemDirCtx$FlatBindings;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bds", "Ljava/util/Hashtable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "env", "Ljava/util/Hashtable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "useFactory", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/jndi/toolkit/dir/HierMemDirCtx;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jndi/toolkit/dir/HierMemDirCtx;Ljava/util/Hashtable;Ljava/util/Hashtable;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_0", "()Ljavax/naming/Binding;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_1", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Ljava/util/Hashtable;", "private")]
		public Dova.JDK.java.util.Hashtable bds_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Hashtable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Hashtable;", "private")]
		public Dova.JDK.java.util.Hashtable env_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Hashtable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool useFactory_Property
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

		[JniSignatureAttribute("Lcom/sun/jndi/toolkit/dir/HierMemDirCtx;", "final")]
		public Dova.JDK.com.sun.jndi.toolkit.dir.HierMemDirCtx this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.toolkit.dir.HierMemDirCtx>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FlatBindings(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/jndi/toolkit/dir/HierMemDirCtx;Ljava/util/Hashtable;Ljava/util/Hashtable;Z)V", "")]
		public FlatBindings(Dova.JDK.com.sun.jndi.toolkit.dir.HierMemDirCtx arg0, Dova.JDK.java.util.Hashtable arg1, Dova.JDK.java.util.Hashtable arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jndi/toolkit/dir/HierMemDirCtx$FlatBindings;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljavax/naming/Binding;", "public")]
		public Dova.JDK.javax.naming.Binding next_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.Binding>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object next_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jndi/toolkit/dir/HierMemDirCtx$HierContextEnumerator;", "public")]
	public partial class HierContextEnumerator
		: Dova.JDK.com.sun.jndi.toolkit.dir.ContextEnumerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static HierContextEnumerator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jndi/toolkit/dir/HierMemDirCtx$HierContextEnumerator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/jndi/toolkit/dir/HierMemDirCtx;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jndi/toolkit/dir/HierMemDirCtx;Ljavax/naming/Context;I)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jndi/toolkit/dir/HierMemDirCtx;Ljavax/naming/Context;ILjava/lang/String;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getImmediateChildren", "(Ljavax/naming/Context;)Ljavax/naming/NamingEnumeration;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newEnumerator", "(Ljavax/naming/Context;ILjava/lang/String;Z)Lcom/sun/jndi/toolkit/dir/ContextEnumerator;"));
		}

		[JniSignatureAttribute("Lcom/sun/jndi/toolkit/dir/HierMemDirCtx;", "final")]
		public Dova.JDK.com.sun.jndi.toolkit.dir.HierMemDirCtx this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.toolkit.dir.HierMemDirCtx>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public HierContextEnumerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/jndi/toolkit/dir/HierMemDirCtx;Ljavax/naming/Context;I)V", "public")]
		public HierContextEnumerator(Dova.JDK.com.sun.jndi.toolkit.dir.HierMemDirCtx arg0, Dova.JDK.javax.naming.Context arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/jndi/toolkit/dir/HierMemDirCtx;Ljavax/naming/Context;ILjava/lang/String;Z)V", "protected")]
		public HierContextEnumerator(Dova.JDK.com.sun.jndi.toolkit.dir.HierMemDirCtx arg0, Dova.JDK.javax.naming.Context arg1, int arg2, Dova.JDK.java.lang.String arg3, bool arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jndi/toolkit/dir/HierMemDirCtx$HierContextEnumerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/naming/Context;)Ljavax/naming/NamingEnumeration;", "protected")]
		public Dova.JDK.javax.naming.NamingEnumeration getImmediateChildren(Dova.JDK.javax.naming.Context arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
		}

		[JniSignatureAttribute("(Ljavax/naming/Context;ILjava/lang/String;Z)Lcom/sun/jndi/toolkit/dir/ContextEnumerator;", "protected")]
		public Dova.JDK.com.sun.jndi.toolkit.dir.ContextEnumerator newEnumerator(Dova.JDK.javax.naming.Context arg0, int arg1, Dova.JDK.java.lang.String arg2, bool arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.toolkit.dir.ContextEnumerator>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jndi/toolkit/dir/HierMemDirCtx$BaseFlatNames;", "private abstract")]
	public partial class BaseFlatNames
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.naming.NamingEnumeration
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BaseFlatNames()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jndi/toolkit/dir/HierMemDirCtx$BaseFlatNames;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "names", "Ljava/util/Enumeration;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jndi/toolkit/dir/HierMemDirCtx;Ljava/util/Enumeration;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasMoreElements", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextElement", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasMore", "()Z"));
		}

		[JniSignatureAttribute("Ljava/util/Enumeration;", "")]
		public Dova.JDK.java.util.Enumeration names_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Enumeration>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BaseFlatNames(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/jndi/toolkit/dir/HierMemDirCtx;Ljava/util/Enumeration;)V", "")]
		public BaseFlatNames(Dova.JDK.com.sun.jndi.toolkit.dir.HierMemDirCtx arg0, Dova.JDK.java.util.Enumeration arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jndi/toolkit/dir/HierMemDirCtx$BaseFlatNames;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/Object;", "public abstract")]
		public Dova.JDK.java.lang.Object next()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Z", "public final")]
		public bool hasMoreElements()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public final")]
		public Dova.JDK.java.lang.Object nextElement()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()V", "public final")]
		public void close()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("()Z", "public final")]
		public bool hasMore()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}
	}
}
