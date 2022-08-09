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

namespace Dova.JDK.jdk.@internal.jrtfs;

[JniSignatureAttribute("Ljdk/internal/jrtfs/JrtFileAttributeView;", "final")]
public partial class JrtFileAttributeView
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.nio.file.attribute.BasicFileAttributeView
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JrtFileAttributeView()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/jrtfs/JrtFileAttributeView;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "path", "Ljdk/internal/jrtfs/JrtPath;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "isJrtView", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "options", "[Ljava/nio/file/LinkOption;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "JrtFileAttributeView", "(Ljdk/internal/jrtfs/JrtPath;Z[Ljava/nio/file/LinkOption;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "name", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "get", "(Ljdk/internal/jrtfs/JrtPath;Ljava/lang/String;[Ljava/nio/file/LinkOption;)Ljdk/internal/jrtfs/JrtFileAttributeView;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "get", "(Ljdk/internal/jrtfs/JrtPath;Ljava/lang/Class;[Ljava/nio/file/LinkOption;)Ljava/nio/file/attribute/FileAttributeView;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "attribute", "(Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;Ljdk/internal/jrtfs/JrtFileAttributes;Z)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "readAttributes", "(Ljdk/internal/jrtfs/JrtPath;Ljava/lang/String;[Ljava/nio/file/LinkOption;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "readAttributes_0", "()Ljdk/internal/jrtfs/JrtFileAttributes;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "readAttributes_1", "()Ljava/nio/file/attribute/BasicFileAttributes;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setAttribute", "(Ljdk/internal/jrtfs/JrtPath;Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setTimes", "(Ljava/nio/file/attribute/FileTime;Ljava/nio/file/attribute/FileTime;Ljava/nio/file/attribute/FileTime;)V"));
	}

	[JniSignatureAttribute("Ljdk/internal/jrtfs/JrtPath;", "private final")]
	public Dova.JDK.jdk.@internal.jrtfs.JrtPath path_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jrtfs.JrtPath>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool isJrtView_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("[Ljava/nio/file/LinkOption;", "private final")]
	public JavaArray<Dova.JDK.java.nio.file.LinkOption> options_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.nio.file.LinkOption>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JrtFileAttributeView(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/jrtfs/JrtPath;Z[Ljava/nio/file/LinkOption;)V", "private transient")]
	public JrtFileAttributeView(Dova.JDK.jdk.@internal.jrtfs.JrtPath arg0, bool arg1, JavaArray<Dova.JDK.java.nio.file.LinkOption> arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/jrtfs/JrtFileAttributeView;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String name()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jrtfs/JrtPath;Ljava/lang/String;[Ljava/nio/file/LinkOption;)Ljdk/internal/jrtfs/JrtFileAttributeView;", "static transient")]
	public static Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView get(Dova.JDK.jdk.@internal.jrtfs.JrtPath arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.nio.file.LinkOption> arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jrtfs/JrtPath;Ljava/lang/Class;[Ljava/nio/file/LinkOption;)Ljava/nio/file/attribute/FileAttributeView;", "static transient")]
	public static Dova.JDK.java.lang.Object get(Dova.JDK.jdk.@internal.jrtfs.JrtPath arg0, Dova.JDK.java.lang.Class arg1, JavaArray<Dova.JDK.java.nio.file.LinkOption> arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;Ljdk/internal/jrtfs/JrtFileAttributes;Z)Ljava/lang/Object;", "static")]
	public static Dova.JDK.java.lang.Object attribute(Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID arg0, Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributes arg1, bool arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jrtfs/JrtPath;Ljava/lang/String;[Ljava/nio/file/LinkOption;)Ljava/util/Map;", "static transient")]
	public static Dova.JDK.java.util.Map readAttributes(Dova.JDK.jdk.@internal.jrtfs.JrtPath arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.nio.file.LinkOption> arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/jrtfs/JrtFileAttributes;", "public")]
	public Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributes readAttributes_0()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributes>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/file/attribute/BasicFileAttributes;", "public volatile")]
	public Dova.JDK.java.nio.file.attribute.BasicFileAttributes readAttributes_1()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.BasicFileAttributes>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jrtfs/JrtPath;Ljava/lang/String;Ljava/lang/Object;)V", "static")]
	public static void setAttribute(Dova.JDK.jdk.@internal.jrtfs.JrtPath arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/nio/file/attribute/FileTime;Ljava/nio/file/attribute/FileTime;Ljava/nio/file/attribute/FileTime;)V", "public")]
	public void setTimes(Dova.JDK.java.nio.file.attribute.FileTime arg0, Dova.JDK.java.nio.file.attribute.FileTime arg1, Dova.JDK.java.nio.file.attribute.FileTime arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;", "private static final")]
	public partial class AttrID
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AttrID()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "size", "Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "creationTime", "Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "lastAccessTime", "Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "lastModifiedTime", "Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "isDirectory", "Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "isRegularFile", "Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "isSymbolicLink", "Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "isOther", "Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "fileKey", "Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "compressedSize", "Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "extension", "Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "AttrID", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;"));
		}

		[JniSignatureAttribute("Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;", "public static final")]
		public static Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID size_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;", "public static final")]
		public static Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID creationTime_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;", "public static final")]
		public static Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID lastAccessTime_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;", "public static final")]
		public static Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID lastModifiedTime_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;", "public static final")]
		public static Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID isDirectory_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;", "public static final")]
		public static Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID isRegularFile_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;", "public static final")]
		public static Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID isSymbolicLink_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;", "public static final")]
		public static Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID isOther_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;", "public static final")]
		public static Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID fileKey_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;", "public static final")]
		public static Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID compressedSize_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;", "public static final")]
		public static Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID extension_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID> VALUES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AttrID(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public AttrID(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID> values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;", "public static")]
		public static Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/jrtfs/JrtFileAttributeView$AttrID;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID> _values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributeView.AttrID>>(ret);
		}
	}
}
