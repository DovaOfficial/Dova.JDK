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

namespace Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util;

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/StandardDocFileFactory;", "")]
public partial class StandardDocFileFactory
	: Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFileFactory
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StandardDocFileFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/util/StandardDocFileFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fileManager", "Ljavax/tools/StandardJavaFileManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "destDir", "Ljava/nio/file/Path;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "list", "(Ljavax/tools/JavaFileManager$Location;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDestDir", "()Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createFileForOutput", "(Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)Ljdk/javadoc/internal/doclets/toolkit/util/DocFile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createFileForInput", "(Ljava/nio/file/Path;)Ljdk/javadoc/internal/doclets/toolkit/util/DocFile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createFileForInput", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/DocFile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createFileForDirectory", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/DocFile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDestDir", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newFile", "(Ljava/nio/file/Path;Ljava/lang/String;)Ljava/nio/file/Path;"));
	}

	[JniSignatureAttribute("Ljavax/tools/StandardJavaFileManager;", "private final")]
	public Dova.JDK.javax.tools.StandardJavaFileManager fileManager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.StandardJavaFileManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/nio/file/Path;", "private")]
	public Dova.JDK.java.nio.file.Path destDir_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public StandardDocFileFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;)V", "public")]
	public StandardDocFileFactory(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.BaseConfiguration arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/util/StandardDocFileFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)Ljava/lang/Iterable;", "")]
	public Dova.JDK.java.lang.Iterable list(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/file/Path;", "private")]
	public Dova.JDK.java.nio.file.Path getDestDir()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)Ljdk/javadoc/internal/doclets/toolkit/util/DocFile;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFile createFileForOutput(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFile>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljdk/javadoc/internal/doclets/toolkit/util/DocFile;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFile createFileForInput(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFile>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/DocFile;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFile createFileForInput(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFile>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/DocFile;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFile createFileForDirectory(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFile>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setDestDir(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/lang/String;)Ljava/nio/file/Path;", "private static")]
	public static Dova.JDK.java.nio.file.Path newFile(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/StandardDocFileFactory$StandardDocFile;", "")]
	public partial class StandardDocFile
		: Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFile
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StandardDocFile()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/util/StandardDocFileFactory$StandardDocFile;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "file", "Ljava/nio/file/Path;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/javadoc/internal/doclets/toolkit/util/StandardDocFileFactory;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/toolkit/util/StandardDocFileFactory;Ljava/nio/file/Path;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/toolkit/util/StandardDocFileFactory;Ljavax/tools/JavaFileManager$Location;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "list", "()Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAbsolute", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/DocFile;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)Ljdk/javadoc/internal/doclets/toolkit/util/DocFile;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canRead", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPath", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exists", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDirectory", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mkdirs", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canWrite", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFile", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSameFile", "(Ljdk/javadoc/internal/doclets/toolkit/util/DocFile;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileObject", "()Ljavax/tools/FileObject;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaFileObjectForInput", "(Ljava/nio/file/Path;)Ljavax/tools/JavaFileObject;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileObjectForOutput", "(Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)Ljavax/tools/FileObject;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveAgainst", "(Ljavax/tools/JavaFileManager$Location;)Ljdk/javadoc/internal/doclets/toolkit/util/DocFile;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "openInputStream", "()Ljava/io/InputStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "openOutputStream", "()Ljava/io/OutputStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "openWriter", "()Ljava/io/Writer;"));
		}

		[JniSignatureAttribute("Ljava/nio/file/Path;", "private final")]
		public Dova.JDK.java.nio.file.Path file_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/StandardDocFileFactory;", "final")]
		public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.StandardDocFileFactory this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.StandardDocFileFactory>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StandardDocFile(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/StandardDocFileFactory;Ljava/nio/file/Path;)V", "")]
		public StandardDocFile(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.StandardDocFileFactory arg0, Dova.JDK.java.nio.file.Path arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/StandardDocFileFactory;Ljavax/tools/JavaFileManager$Location;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)V", "")]
		public StandardDocFile(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.StandardDocFileFactory arg0, Dova.JDK.javax.tools.JavaFileManager.Location arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/util/StandardDocFileFactory$StandardDocFile;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Iterable;", "public")]
		public Dova.JDK.java.lang.Iterable list()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isAbsolute()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/DocFile;", "public")]
		public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFile resolve(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFile>(ret);
		}

		[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)Ljdk/javadoc/internal/doclets/toolkit/util/DocFile;", "public")]
		public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFile resolve(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFile>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool canRead()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getPath()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool exists()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isDirectory()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool mkdirs()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool canWrite()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isFile()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
			return ret;
		}

		[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/DocFile;)Z", "public")]
		public bool isSameFile(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFile arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljavax/tools/FileObject;", "public")]
		public Dova.JDK.javax.tools.FileObject getFileObject()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.FileObject>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljavax/tools/JavaFileObject;", "private")]
		public Dova.JDK.javax.tools.JavaFileObject getJavaFileObjectForInput(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject>(ret);
		}

		[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)Ljavax/tools/FileObject;", "private")]
		public Dova.JDK.javax.tools.FileObject getFileObjectForOutput(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.FileObject>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;)Ljdk/javadoc/internal/doclets/toolkit/util/DocFile;", "public")]
		public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFile resolveAgainst(Dova.JDK.javax.tools.JavaFileManager.Location arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFile>(ret);
		}

		[JniSignatureAttribute("()Ljava/io/InputStream;", "public")]
		public Dova.JDK.java.io.InputStream openInputStream()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
		}

		[JniSignatureAttribute("()Ljava/io/OutputStream;", "public")]
		public Dova.JDK.java.io.OutputStream openOutputStream()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.OutputStream>(ret);
		}

		[JniSignatureAttribute("()Ljava/io/Writer;", "public")]
		public Dova.JDK.java.io.Writer openWriter()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.Writer>(ret);
		}
	}
}
