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

namespace Dova.JDK.com.sun.tools.jdeps;

[JniSignatureAttribute("Lcom/sun/tools/jdeps/ClassFileReader;", "public")]
public partial class ClassFileReader
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.io.Closeable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ClassFileReader()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdeps/ClassFileReader;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "path", "Ljava/nio/file/Path;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "baseFileName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "entries", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "skippedEntries", "Ljava/util/List;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/file/Path;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newInstance", "(Ljava/nio/file/Path;Ljava/lang/Runtime$Version;)Lcom/sun/tools/jdeps/ClassFileReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newInstance", "(Ljava/nio/file/FileSystem;Ljava/nio/file/Path;)Lcom/sun/tools/jdeps/ClassFileReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "entries", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scan", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "skippedEntries", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isClass", "(Ljava/nio/file/Path;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassFile", "(Ljava/lang/String;)Lcom/sun/tools/classfile/ClassFile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassFiles", "()Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readClassFile", "(Ljava/nio/file/Path;)Lcom/sun/tools/classfile/ClassFile;"));
	}

	[JniSignatureAttribute("Ljava/nio/file/Path;", "protected final")]
	public Dova.JDK.java.nio.file.Path path_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "protected final")]
	public Dova.JDK.java.lang.String baseFileName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "protected")]
	public Dova.JDK.java.util.Set entries_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "protected final")]
	public Dova.JDK.java.util.List skippedEntries_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ClassFileReader(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)V", "protected")]
	public ClassFileReader(Dova.JDK.java.nio.file.Path arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/jdeps/ClassFileReader;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/lang/Runtime$Version;)Lcom/sun/tools/jdeps/ClassFileReader;", "public static")]
	public static Dova.JDK.com.sun.tools.jdeps.ClassFileReader newInstance(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.lang.Runtime.Version arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.ClassFileReader>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/FileSystem;Ljava/nio/file/Path;)Lcom/sun/tools/jdeps/ClassFileReader;", "public static")]
	public static Dova.JDK.com.sun.tools.jdeps.ClassFileReader newInstance(Dova.JDK.java.nio.file.FileSystem arg0, Dova.JDK.java.nio.file.Path arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.ClassFileReader>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set entries()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getFileName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "protected")]
	public Dova.JDK.java.util.Set scan()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List skippedEntries()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Z", "static")]
	public static bool isClass(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/classfile/ClassFile;", "public")]
	public Dova.JDK.com.sun.tools.classfile.ClassFile getClassFile(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ClassFile>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Iterable;", "public")]
	public Dova.JDK.java.lang.Iterable getClassFiles()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/classfile/ClassFile;", "protected")]
	public Dova.JDK.com.sun.tools.classfile.ClassFile readClassFile(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ClassFile>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdeps/ClassFileReader$DirectoryReader;", "private static")]
	public partial class DirectoryReader
		: Dova.JDK.com.sun.tools.jdeps.ClassFileReader
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DirectoryReader()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdeps/ClassFileReader$DirectoryReader;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fsSep", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/file/Path;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/file/FileSystem;Ljava/nio/file/Path;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scan", "()Ljava/util/Set;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassFile", "(Ljava/lang/String;)Lcom/sun/tools/classfile/ClassFile;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassFiles", "()Ljava/lang/Iterable;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "protected final")]
		public Dova.JDK.java.lang.String fsSep_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DirectoryReader(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)V", "")]
		public DirectoryReader(Dova.JDK.java.nio.file.Path arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/nio/file/FileSystem;Ljava/nio/file/Path;)V", "")]
		public DirectoryReader(Dova.JDK.java.nio.file.FileSystem arg0, Dova.JDK.java.nio.file.Path arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdeps/ClassFileReader$DirectoryReader;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/Set;", "protected")]
		public Dova.JDK.java.util.Set scan()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/classfile/ClassFile;", "public")]
		public Dova.JDK.com.sun.tools.classfile.ClassFile getClassFile(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ClassFile>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Iterable;", "public")]
		public Dova.JDK.java.lang.Iterable getClassFiles()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdeps/ClassFileReader$DirectoryReader$DirectoryIterator;", "")]
		public partial class DirectoryIterator
			: Dova.JDK.java.lang.Object
			, Dova.JDK.java.util.Iterator
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static DirectoryIterator()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdeps/ClassFileReader$DirectoryReader$DirectoryIterator;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "entries", "Ljava/util/List;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/jdeps/ClassFileReader$DirectoryReader;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdeps/ClassFileReader$DirectoryReader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasNext", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_0", "()Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_1", "()Lcom/sun/tools/classfile/ClassFile;"));
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List entries_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private")]
			public int index_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdeps/ClassFileReader$DirectoryReader;", "final")]
			public Dova.JDK.com.sun.tools.jdeps.ClassFileReader.DirectoryReader this0_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.ClassFileReader.DirectoryReader>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public DirectoryIterator(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdeps/ClassFileReader$DirectoryReader;)V", "")]
			public DirectoryIterator(Dova.JDK.com.sun.tools.jdeps.ClassFileReader.DirectoryReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdeps/ClassFileReader$DirectoryReader$DirectoryIterator;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "public")]
			public void remove()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool hasNext()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object next_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("()Lcom/sun/tools/classfile/ClassFile;", "public")]
			public Dova.JDK.com.sun.tools.classfile.ClassFile next_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ClassFile>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdeps/ClassFileReader$JarFileReader;", "static")]
	public partial class JarFileReader
		: Dova.JDK.com.sun.tools.jdeps.ClassFileReader
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JarFileReader()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdeps/ClassFileReader$JarFileReader;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "jarfile", "Ljava/util/jar/JarFile;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "version", "Ljava/lang/Runtime$Version;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/file/Path;Ljava/lang/Runtime$Version;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/file/Path;Ljava/util/jar/JarFile;Ljava/lang/Runtime$Version;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scan", "()Ljava/util/Set;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "openJarFile", "(Ljava/io/File;Ljava/lang/Runtime$Version;)Ljava/util/jar/JarFile;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassFile", "(Ljava/lang/String;)Lcom/sun/tools/classfile/ClassFile;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassFiles", "()Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readClassFile", "(Ljava/util/jar/JarFile;Ljava/util/jar/JarEntry;)Lcom/sun/tools/classfile/ClassFile;"));
		}

		[JniSignatureAttribute("Ljava/util/jar/JarFile;", "private final")]
		public Dova.JDK.java.util.jar.JarFile jarfile_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.JarFile>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Runtime$Version;", "private final")]
		public Dova.JDK.java.lang.Runtime.Version version_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runtime.Version>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JarFileReader(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/lang/Runtime$Version;)V", "")]
		public JarFileReader(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.lang.Runtime.Version arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/util/jar/JarFile;Ljava/lang/Runtime$Version;)V", "")]
		public JarFileReader(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.util.jar.JarFile arg1, Dova.JDK.java.lang.Runtime.Version arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdeps/ClassFileReader$JarFileReader;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void close()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()Ljava/util/Set;", "protected")]
		public Dova.JDK.java.util.Set scan()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;Ljava/lang/Runtime$Version;)Ljava/util/jar/JarFile;", "private static")]
		public static Dova.JDK.java.util.jar.JarFile openJarFile(Dova.JDK.java.io.File arg0, Dova.JDK.java.lang.Runtime.Version arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.JarFile>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/classfile/ClassFile;", "public")]
		public Dova.JDK.com.sun.tools.classfile.ClassFile getClassFile(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ClassFile>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Iterable;", "public")]
		public Dova.JDK.java.lang.Iterable getClassFiles()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/jar/JarFile;Ljava/util/jar/JarEntry;)Lcom/sun/tools/classfile/ClassFile;", "protected")]
		public Dova.JDK.com.sun.tools.classfile.ClassFile readClassFile(Dova.JDK.java.util.jar.JarFile arg0, Dova.JDK.java.util.jar.JarEntry arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ClassFile>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdeps/ClassFileReader$FileIterator;", "")]
	public partial class FileIterator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.Iterator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FileIterator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdeps/ClassFileReader$FileIterator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "count", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/jdeps/ClassFileReader;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdeps/ClassFileReader;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasNext", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_1", "()Lcom/sun/tools/classfile/ClassFile;"));
		}

		[JniSignatureAttribute("I", "")]
		public int count_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdeps/ClassFileReader;", "final")]
		public Dova.JDK.com.sun.tools.jdeps.ClassFileReader this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.ClassFileReader>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FileIterator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/jdeps/ClassFileReader;)V", "")]
		public FileIterator(Dova.JDK.com.sun.tools.jdeps.ClassFileReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdeps/ClassFileReader$FileIterator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void remove()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool hasNext()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object next_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/classfile/ClassFile;", "public")]
		public Dova.JDK.com.sun.tools.classfile.ClassFile next_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ClassFile>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdeps/ClassFileReader$JarFileIterator;", "")]
	public partial class JarFileIterator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.Iterator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JarFileIterator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdeps/ClassFileReader$JarFileIterator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reader", "Lcom/sun/tools/jdeps/ClassFileReader$JarFileReader;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "entries", "Ljava/util/Iterator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "jf", "Ljava/util/jar/JarFile;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nextEntry", "Ljava/util/jar/JarEntry;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cf", "Lcom/sun/tools/classfile/ClassFile;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/jdeps/ClassFileReader;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdeps/ClassFileReader;Lcom/sun/tools/jdeps/ClassFileReader$JarFileReader;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdeps/ClassFileReader;Lcom/sun/tools/jdeps/ClassFileReader$JarFileReader;Ljava/util/jar/JarFile;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasNext", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_1", "()Lcom/sun/tools/classfile/ClassFile;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextEntry", "()Ljava/util/jar/JarEntry;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setJarFile", "(Ljava/util/jar/JarFile;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdeps/ClassFileReader$JarFileReader;", "protected final")]
		public Dova.JDK.com.sun.tools.jdeps.ClassFileReader.JarFileReader reader_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.ClassFileReader.JarFileReader>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Iterator;", "protected")]
		public Dova.JDK.java.util.Iterator entries_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/jar/JarFile;", "protected")]
		public Dova.JDK.java.util.jar.JarFile jf_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.JarFile>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/jar/JarEntry;", "protected")]
		public Dova.JDK.java.util.jar.JarEntry nextEntry_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.JarEntry>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/ClassFile;", "protected")]
		public Dova.JDK.com.sun.tools.classfile.ClassFile cf_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ClassFile>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdeps/ClassFileReader;", "final")]
		public Dova.JDK.com.sun.tools.jdeps.ClassFileReader this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.ClassFileReader>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JarFileIterator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/jdeps/ClassFileReader;Lcom/sun/tools/jdeps/ClassFileReader$JarFileReader;)V", "")]
		public JarFileIterator(Dova.JDK.com.sun.tools.jdeps.ClassFileReader arg0, Dova.JDK.com.sun.tools.jdeps.ClassFileReader.JarFileReader arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/jdeps/ClassFileReader;Lcom/sun/tools/jdeps/ClassFileReader$JarFileReader;Ljava/util/jar/JarFile;)V", "")]
		public JarFileIterator(Dova.JDK.com.sun.tools.jdeps.ClassFileReader arg0, Dova.JDK.com.sun.tools.jdeps.ClassFileReader.JarFileReader arg1, Dova.JDK.java.util.jar.JarFile arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdeps/ClassFileReader$JarFileIterator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void remove()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool hasNext()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object next_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/classfile/ClassFile;", "public")]
		public Dova.JDK.com.sun.tools.classfile.ClassFile next_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ClassFile>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/jar/JarEntry;", "protected")]
		public Dova.JDK.java.util.jar.JarEntry nextEntry()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.JarEntry>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/jar/JarFile;)V", "")]
		public void setJarFile(Dova.JDK.java.util.jar.JarFile arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}
	}
}
