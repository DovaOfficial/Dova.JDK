/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.jdk.tools.jlink.@internal;

[JniSignatureAttribute("Ljdk/tools/jlink/internal/Archive;", "public abstract interface")]
public partial interface Archive
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Archive()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/internal/Archive;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "moduleName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "entries", "()Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "open", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPath", "()Ljava/nio/file/Path;"));
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String moduleName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("()Ljava/util/stream/Stream;", "public abstract")]
	Dova.JDK.java.util.stream.Stream entries()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void open()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()Ljava/nio/file/Path;", "public abstract")]
	Dova.JDK.java.nio.file.Path getPath()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("Ljdk/tools/jlink/internal/Archive$Entry;", "public abstract static")]
	public partial class Entry
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Entry()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/internal/Archive$Entry;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "type", "Ljdk/tools/jlink/internal/Archive$Entry$EntryType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "archive", "Ljdk/tools/jlink/internal/Archive;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "path", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Entry", "(Ljdk/tools/jlink/internal/Archive;Ljava/lang/String;Ljava/lang/String;Ljdk/tools/jlink/internal/Archive$Entry$EntryType;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "name", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "type", "()Ljdk/tools/jlink/internal/Archive$Entry$EntryType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "size", "()J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "stream", "()Ljava/io/InputStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "archive", "()Ljdk/tools/jlink/internal/Archive;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getResourcePoolEntryName", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/internal/Archive$Entry$EntryType;", "private final")]
		public Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType type_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/internal/Archive;", "private final")]
		public Dova.JDK.jdk.tools.jlink.@internal.Archive archive_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Archive>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String path_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Entry(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/tools/jlink/internal/Archive;Ljava/lang/String;Ljava/lang/String;Ljdk/tools/jlink/internal/Archive$Entry$EntryType;)V", "public")]
		public Entry(Dova.JDK.jdk.tools.jlink.@internal.Archive arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/tools/jlink/internal/Archive$Entry;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public final")]
		public Dova.JDK.java.lang.String name()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljdk/tools/jlink/internal/Archive$Entry$EntryType;", "public final")]
		public Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType type()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()J", "public abstract")]
		public long size()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/io/InputStream;", "public abstract")]
		public Dova.JDK.java.io.InputStream stream()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
		}

		[JniSignatureAttribute("()Ljdk/tools/jlink/internal/Archive;", "public final")]
		public Dova.JDK.jdk.tools.jlink.@internal.Archive archive()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Archive>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public final")]
		public Dova.JDK.java.lang.String getResourcePoolEntryName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("Ljdk/tools/jlink/internal/Archive$Entry$EntryType;", "public static final")]
		public partial class EntryType
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static EntryType()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/internal/Archive$Entry$EntryType;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MODULE_NAME", "Ljdk/tools/jlink/internal/Archive$Entry$EntryType;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CLASS_OR_RESOURCE", "Ljdk/tools/jlink/internal/Archive$Entry$EntryType;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CONFIG", "Ljdk/tools/jlink/internal/Archive$Entry$EntryType;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NATIVE_LIB", "Ljdk/tools/jlink/internal/Archive$Entry$EntryType;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NATIVE_CMD", "Ljdk/tools/jlink/internal/Archive$Entry$EntryType;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "HEADER_FILE", "Ljdk/tools/jlink/internal/Archive$Entry$EntryType;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LEGAL_NOTICE", "Ljdk/tools/jlink/internal/Archive$Entry$EntryType;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MAN_PAGE", "Ljdk/tools/jlink/internal/Archive$Entry$EntryType;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SERVICE", "Ljdk/tools/jlink/internal/Archive$Entry$EntryType;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Ljdk/tools/jlink/internal/Archive$Entry$EntryType;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "EntryType", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Ljdk/tools/jlink/internal/Archive$Entry$EntryType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Ljdk/tools/jlink/internal/Archive$Entry$EntryType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Ljdk/tools/jlink/internal/Archive$Entry$EntryType;"));
			}

			[JniSignatureAttribute("Ljdk/tools/jlink/internal/Archive$Entry$EntryType;", "public static final")]
			public static Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType MODULE_NAME_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType>(ret);
				}
				set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Ljdk/tools/jlink/internal/Archive$Entry$EntryType;", "public static final")]
			public static Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType CLASS_OR_RESOURCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType>(ret);
				}
				set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Ljdk/tools/jlink/internal/Archive$Entry$EntryType;", "public static final")]
			public static Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType CONFIG_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType>(ret);
				}
				set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Ljdk/tools/jlink/internal/Archive$Entry$EntryType;", "public static final")]
			public static Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType NATIVE_LIB_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType>(ret);
				}
				set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Ljdk/tools/jlink/internal/Archive$Entry$EntryType;", "public static final")]
			public static Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType NATIVE_CMD_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType>(ret);
				}
				set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Ljdk/tools/jlink/internal/Archive$Entry$EntryType;", "public static final")]
			public static Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType HEADER_FILE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType>(ret);
				}
				set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Ljdk/tools/jlink/internal/Archive$Entry$EntryType;", "public static final")]
			public static Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType LEGAL_NOTICE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType>(ret);
				}
				set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Ljdk/tools/jlink/internal/Archive$Entry$EntryType;", "public static final")]
			public static Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType MAN_PAGE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType>(ret);
				}
				set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Ljdk/tools/jlink/internal/Archive$Entry$EntryType;", "public static final")]
			public static Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType SERVICE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType>(ret);
				}
				set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("[Ljdk/tools/jlink/internal/Archive$Entry$EntryType;", "private static final")]
			public static JavaArray<Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType>>(ret);
				}
				set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public EntryType(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public EntryType(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/tools/jlink/internal/Archive$Entry$EntryType;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Ljdk/tools/jlink/internal/Archive$Entry$EntryType;", "public static")]
			public static JavaArray<Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/tools/jlink/internal/Archive$Entry$EntryType;", "public static")]
			public static Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType>(ret);
			}

			[JniSignatureAttribute("()[Ljdk/tools/jlink/internal/Archive$Entry$EntryType;", "private static")]
			public static JavaArray<Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType> _values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.tools.jlink.@internal.Archive.Entry.EntryType>>(ret);
			}
		}
	}
}
