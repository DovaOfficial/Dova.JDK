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

namespace Dova.JDK.sun.nio.fs;

[JniSignatureAttribute("Lsun/nio/fs/UnixCopyFile;", "")]
public partial class UnixCopyFile
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static UnixCopyFile()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/fs/UnixCopyFile;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "UnixCopyFile", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "copy", "(Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixPath;[Ljava/nio/file/CopyOption;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "transfer", "(IIJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "move", "(Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixPath;[Ljava/nio/file/CopyOption;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "ensureEmptyDir", "(Lsun/nio/fs/UnixPath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "copyDirectory", "(Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixFileAttributes;Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixCopyFile$Flags;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "copyLink", "(Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixFileAttributes;Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixCopyFile$Flags;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "copySpecial", "(Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixFileAttributes;Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixCopyFile$Flags;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "copyFile", "(Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixFileAttributes;Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixCopyFile$Flags;J)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public UnixCopyFile(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public UnixCopyFile() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/nio/fs/UnixCopyFile;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixPath;[Ljava/nio/file/CopyOption;)V", "static transient")]
	public static void copy(Dova.JDK.sun.nio.fs.UnixPath arg0, Dova.JDK.sun.nio.fs.UnixPath arg1, JavaArray<Dova.JDK.java.nio.file.CopyOption> arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(IIJ)V", "static native")]
	public static void transfer(int arg0, int arg1, long arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixPath;[Ljava/nio/file/CopyOption;)V", "static transient")]
	public static void move(Dova.JDK.sun.nio.fs.UnixPath arg0, Dova.JDK.sun.nio.fs.UnixPath arg1, JavaArray<Dova.JDK.java.nio.file.CopyOption> arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;)V", "static")]
	public static void ensureEmptyDir(Dova.JDK.sun.nio.fs.UnixPath arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixFileAttributes;Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixCopyFile$Flags;)V", "private static")]
	public static void copyDirectory(Dova.JDK.sun.nio.fs.UnixPath arg0, Dova.JDK.sun.nio.fs.UnixFileAttributes arg1, Dova.JDK.sun.nio.fs.UnixPath arg2, Dova.JDK.sun.nio.fs.UnixCopyFile.Flags arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixFileAttributes;Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixCopyFile$Flags;)V", "private static")]
	public static void copyLink(Dova.JDK.sun.nio.fs.UnixPath arg0, Dova.JDK.sun.nio.fs.UnixFileAttributes arg1, Dova.JDK.sun.nio.fs.UnixPath arg2, Dova.JDK.sun.nio.fs.UnixCopyFile.Flags arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixFileAttributes;Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixCopyFile$Flags;)V", "private static")]
	public static void copySpecial(Dova.JDK.sun.nio.fs.UnixPath arg0, Dova.JDK.sun.nio.fs.UnixFileAttributes arg1, Dova.JDK.sun.nio.fs.UnixPath arg2, Dova.JDK.sun.nio.fs.UnixCopyFile.Flags arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixFileAttributes;Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixCopyFile$Flags;J)V", "private static")]
	public static void copyFile(Dova.JDK.sun.nio.fs.UnixPath arg0, Dova.JDK.sun.nio.fs.UnixFileAttributes arg1, Dova.JDK.sun.nio.fs.UnixPath arg2, Dova.JDK.sun.nio.fs.UnixCopyFile.Flags arg3, long arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("Lsun/nio/fs/UnixCopyFile$Flags;", "private static")]
	public partial class Flags
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Flags()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/fs/UnixCopyFile$Flags;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "replaceExisting", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "atomicMove", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "followLinks", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "interruptible", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "copyBasicAttributes", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "copyPosixAttributes", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "copyNonPosixAttributes", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "failIfUnableToCopyBasic", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "failIfUnableToCopyPosix", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "failIfUnableToCopyNonPosix", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Flags", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "fromMoveOptions", "([Ljava/nio/file/CopyOption;)Lsun/nio/fs/UnixCopyFile$Flags;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "fromCopyOptions", "([Ljava/nio/file/CopyOption;)Lsun/nio/fs/UnixCopyFile$Flags;"));
		}

		[JniSignatureAttribute("Z", "")]
		public bool replaceExisting_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("Z", "")]
		public bool atomicMove_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("Z", "")]
		public bool followLinks_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("Z", "")]
		public bool interruptible_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("Z", "")]
		public bool copyBasicAttributes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("Z", "")]
		public bool copyPosixAttributes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
		}

		[JniSignatureAttribute("Z", "")]
		public bool copyNonPosixAttributes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
		}

		[JniSignatureAttribute("Z", "")]
		public bool failIfUnableToCopyBasic_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
		}

		[JniSignatureAttribute("Z", "")]
		public bool failIfUnableToCopyPosix_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
		}

		[JniSignatureAttribute("Z", "")]
		public bool failIfUnableToCopyNonPosix_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[9]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[9], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Flags(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Flags() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/nio/fs/UnixCopyFile$Flags;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([Ljava/nio/file/CopyOption;)Lsun/nio/fs/UnixCopyFile$Flags;", "static transient")]
		public static Dova.JDK.sun.nio.fs.UnixCopyFile.Flags fromMoveOptions(JavaArray<Dova.JDK.java.nio.file.CopyOption> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.fs.UnixCopyFile.Flags>(ret);
		}

		[JniSignatureAttribute("([Ljava/nio/file/CopyOption;)Lsun/nio/fs/UnixCopyFile$Flags;", "static transient")]
		public static Dova.JDK.sun.nio.fs.UnixCopyFile.Flags fromCopyOptions(JavaArray<Dova.JDK.java.nio.file.CopyOption> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.fs.UnixCopyFile.Flags>(ret);
		}
	}
}
