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

namespace Dova.JDK.sun.net.www;

[JniSignatureAttribute("Lsun/net/www/MimeTable;", "public")]
public partial class MimeTable
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.net.FileNameMap
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MimeTable()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/net/www/MimeTable;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "entries", "Ljava/util/Hashtable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "extensionMap", "Ljava/util/Hashtable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "tempFileTemplate", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "filePreamble", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "fileMagic", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "mailcapLocations", "[Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Lsun/net/www/MimeEntry;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "(Ljava/lang/String;)Lsun/net/www/MimeEntry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "(Lsun/net/www/MimeEntry;)Lsun/net/www/MimeEntry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fill", "(Lsun/net/www/MimeEntry;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "elements", "()Ljava/util/Enumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "find", "(Ljava/lang/String;)Lsun/net/www/MimeEntry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/lang/String;Lsun/net/www/MimeEntry;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/util/Properties;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExtensions", "(Ljava/lang/String;)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTempFileTemplate", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDefaultTable", "()Lsun/net/www/MimeTable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findByFileName", "(Ljava/lang/String;)Lsun/net/www/MimeEntry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findByExt", "(Ljava/lang/String;)Lsun/net/www/MimeEntry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActionCode", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAsProperties", "()Ljava/util/Properties;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loadTable", "()Ljava/net/FileNameMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContentTypeFor", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findByDescription", "(Ljava/lang/String;)Lsun/net/www/MimeEntry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "saveAsProperties", "(Ljava/io/File;)Z"));
	}

	[JniSignatureAttribute("Ljava/util/Hashtable;", "private")]
	public Dova.JDK.java.util.Hashtable entries_Property
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
	public Dova.JDK.java.util.Hashtable extensionMap_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String tempFileTemplate_Property
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
	public static Dova.JDK.java.lang.String filePreamble_Property
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
	public static Dova.JDK.java.lang.String fileMagic_Property
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

	[JniSignatureAttribute("[Ljava/lang/String;", "protected static")]
	public static JavaArray<Dova.JDK.java.lang.String> mailcapLocations_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MimeTable(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public MimeTable() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/net/www/MimeTable;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/net/www/MimeEntry;)V", "public synchronized")]
	public void add(Dova.JDK.sun.net.www.MimeEntry arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/net/www/MimeEntry;", "public synchronized")]
	public Dova.JDK.sun.net.www.MimeEntry remove(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.MimeEntry>(ret);
	}

	[JniSignatureAttribute("(Lsun/net/www/MimeEntry;)Lsun/net/www/MimeEntry;", "public synchronized")]
	public Dova.JDK.sun.net.www.MimeEntry remove(Dova.JDK.sun.net.www.MimeEntry arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.MimeEntry>(ret);
	}

	[JniSignatureAttribute("()V", "public synchronized")]
	public void load()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("(Lsun/net/www/MimeEntry;Ljava/lang/String;Ljava/lang/String;)V", "")]
	public void fill(Dova.JDK.sun.net.www.MimeEntry arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Ljava/util/Enumeration;", "public synchronized")]
	public Dova.JDK.java.util.Enumeration elements()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Enumeration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/net/www/MimeEntry;", "public synchronized")]
	public Dova.JDK.sun.net.www.MimeEntry find(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.MimeEntry>(ret);
	}

	[JniSignatureAttribute("()I", "public synchronized")]
	public int getSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "")]
	public void parse(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lsun/net/www/MimeEntry;)V", "")]
	public void parse(Dova.JDK.java.lang.String arg0, Dova.JDK.sun.net.www.MimeEntry arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/util/Properties;)V", "")]
	public void parse(Dova.JDK.java.util.Properties arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[Ljava/lang/String;", "")]
	public JavaArray<Dova.JDK.java.lang.String> getExtensions(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String getTempFileTemplate()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lsun/net/www/MimeTable;", "public static")]
	public static Dova.JDK.sun.net.www.MimeTable getDefaultTable()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.MimeTable>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/net/www/MimeEntry;", "public")]
	public Dova.JDK.sun.net.www.MimeEntry findByFileName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.MimeEntry>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/net/www/MimeEntry;", "public synchronized")]
	public Dova.JDK.sun.net.www.MimeEntry findByExt(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.MimeEntry>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "")]
	public int getActionCode(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Properties;", "public")]
	public Dova.JDK.java.util.Properties getAsProperties()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Properties>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/FileNameMap;", "public static")]
	public static Dova.JDK.java.net.FileNameMap loadTable()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.FileNameMap>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public synchronized")]
	public Dova.JDK.java.lang.String getContentTypeFor(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/net/www/MimeEntry;", "public synchronized")]
	public Dova.JDK.sun.net.www.MimeEntry findByDescription(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.MimeEntry>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Z", "protected")]
	public bool saveAsProperties(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("Lsun/net/www/MimeTable$DefaultInstanceHolder;", "private static")]
	public partial class DefaultInstanceHolder
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DefaultInstanceHolder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/net/www/MimeTable$DefaultInstanceHolder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultInstance", "Lsun/net/www/MimeTable;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDefaultInstance", "()Lsun/net/www/MimeTable;"));
		}

		[JniSignatureAttribute("Lsun/net/www/MimeTable;", "static final")]
		public static Dova.JDK.sun.net.www.MimeTable defaultInstance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.MimeTable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DefaultInstanceHolder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public DefaultInstanceHolder() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/net/www/MimeTable$DefaultInstanceHolder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lsun/net/www/MimeTable;", "static")]
		public static Dova.JDK.sun.net.www.MimeTable getDefaultInstance()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.www.MimeTable>(ret);
		}
	}
}
