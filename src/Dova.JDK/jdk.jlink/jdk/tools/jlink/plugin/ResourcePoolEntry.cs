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

namespace Dova.JDK.jdk.tools.jlink.plugin;

[JniSignatureAttribute("Ljdk/tools/jlink/plugin/ResourcePoolEntry;", "public abstract interface")]
public partial interface ResourcePoolEntry
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ResourcePoolEntry()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/plugin/ResourcePoolEntry;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "type", "()Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "moduleName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljava/io/OutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "path", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Ljava/lang/String;Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;[B)Ljdk/tools/jlink/plugin/ResourcePoolEntry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Ljava/lang/String;Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;Ljava/nio/file/Path;)Ljdk/tools/jlink/plugin/ResourcePoolEntry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Ljava/lang/String;[B)Ljdk/tools/jlink/plugin/ResourcePoolEntry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Ljava/lang/String;Ljava/nio/file/Path;)Ljdk/tools/jlink/plugin/ResourcePoolEntry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "content", "()Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contentLength", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "linkedTarget", "()Ljdk/tools/jlink/plugin/ResourcePoolEntry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyWithContent", "(Ljava/nio/file/Path;)Ljdk/tools/jlink/plugin/ResourcePoolEntry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyWithContent", "([B)Ljdk/tools/jlink/plugin/ResourcePoolEntry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createSymLink", "(Ljava/lang/String;Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;Ljdk/tools/jlink/plugin/ResourcePoolEntry;)Ljdk/tools/jlink/plugin/ResourcePoolEntry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contentBytes", "()[B"));
	}

	[JniSignatureAttribute("()Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;", "public abstract")]
	Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type type()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String moduleName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/OutputStream;)V", "public")]
	void write(Dova.JDK.java.io.OutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String path()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;[B)Ljdk/tools/jlink/plugin/ResourcePoolEntry;", "public static")]
	static Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry create(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type arg1, JavaArray<byte> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;Ljava/nio/file/Path;)Ljdk/tools/jlink/plugin/ResourcePoolEntry;", "public static")]
	static Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry create(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type arg1, Dova.JDK.java.nio.file.Path arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[B)Ljdk/tools/jlink/plugin/ResourcePoolEntry;", "public static")]
	static Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry create(Dova.JDK.java.lang.String arg0, JavaArray<byte> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/nio/file/Path;)Ljdk/tools/jlink/plugin/ResourcePoolEntry;", "public static")]
	static Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry create(Dova.JDK.java.lang.String arg0, Dova.JDK.java.nio.file.Path arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/InputStream;", "public abstract")]
	Dova.JDK.java.io.InputStream content()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("()J", "public abstract")]
	long contentLength()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/tools/jlink/plugin/ResourcePoolEntry;", "public")]
	Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry linkedTarget()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljdk/tools/jlink/plugin/ResourcePoolEntry;", "public")]
	Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry copyWithContent(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry>(ret);
	}

	[JniSignatureAttribute("([B)Ljdk/tools/jlink/plugin/ResourcePoolEntry;", "public")]
	Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry copyWithContent(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;Ljdk/tools/jlink/plugin/ResourcePoolEntry;)Ljdk/tools/jlink/plugin/ResourcePoolEntry;", "public static")]
	static Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry createSymLink(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type arg1, Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry>(ret);
	}

	[JniSignatureAttribute("()[B", "public")]
	JavaArray<byte> contentBytes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;", "public static final")]
	public partial class Type
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Type()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_OR_RESOURCE", "Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONFIG", "Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HEADER_FILE", "Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LEGAL_NOTICE", "Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAN_PAGE", "Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NATIVE_CMD", "Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NATIVE_LIB", "Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TOP", "Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;"));
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type CLASS_OR_RESOURCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type CONFIG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type HEADER_FILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type LEGAL_NOTICE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type MAN_PAGE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type NATIVE_CMD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type NATIVE_LIB_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;", "public static final")]
		public static Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type TOP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Type(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Type(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;", "public static")]
		public static JavaArray<Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;", "public static")]
		public static Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/tools/jlink/plugin/ResourcePoolEntry$Type;", "private static")]
		public static JavaArray<Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.tools.jlink.plugin.ResourcePoolEntry.Type>>(ret);
		}
	}
}
