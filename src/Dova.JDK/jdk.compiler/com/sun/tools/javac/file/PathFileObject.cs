/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.tools.javac.file;

[JniSignatureAttribute("Lcom/sun/tools/javac/file/PathFileObject;", "public abstract")]
public partial class PathFileObject
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.tools.JavaFileObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PathFileObject()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/file/PathFileObject;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultFileSystem", "Ljava/nio/file/FileSystem;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "isMacOS", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fileManager", "Lcom/sun/tools/javac/file/BaseFileManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "path", "Ljava/nio/file/Path;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hasParents", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/file/BaseFileManager;Ljava/nio/file/Path;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSimpleName", "(Ljavax/tools/FileObject;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "delete", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPath", "()Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSameFile", "(Lcom/sun/tools/javac/file/PathFileObject;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toUri", "()Ljava/net/URI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLastModified", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureParentDirectoriesExist", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeExtension", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPathNameCompatible", "(Ljava/nio/file/Path;Ljava/lang/String;Ljavax/tools/JavaFileObject$Kind;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inferBinaryName", "(Ljava/lang/Iterable;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNameCompatible", "(Ljava/lang/String;Ljavax/tools/JavaFileObject$Kind;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSibling", "(Ljava/lang/String;)Lcom/sun/tools/javac/file/PathFileObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forSimplePath", "(Lcom/sun/tools/javac/file/BaseFileManager;Ljava/nio/file/Path;Ljava/nio/file/Path;)Lcom/sun/tools/javac/file/PathFileObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forDirectoryPath", "(Lcom/sun/tools/javac/file/BaseFileManager;Ljava/nio/file/Path;Ljava/nio/file/Path;Lcom/sun/tools/javac/file/RelativePath;)Lcom/sun/tools/javac/file/PathFileObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNestingKind", "()Ljavax/lang/model/element/NestingKind;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessLevel", "()Ljavax/lang/model/element/Modifier;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toBinaryName", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toBinaryName", "(Lcom/sun/tools/javac/file/RelativePath;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toBinaryName", "(Ljava/nio/file/Path;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forJRTPath", "(Lcom/sun/tools/javac/file/BaseFileManager;Ljava/nio/file/Path;)Lcom/sun/tools/javac/file/PathFileObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forJarPath", "(Lcom/sun/tools/javac/file/BaseFileManager;Ljava/nio/file/Path;Ljava/nio/file/Path;)Lcom/sun/tools/javac/file/PathFileObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "openInputStream", "()Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "openOutputStream", "()Ljava/io/OutputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "openReader", "(Z)Ljava/io/Reader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharContent", "(Z)Ljava/lang/CharSequence;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "openWriter", "()Ljava/io/Writer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Ljavax/tools/JavaFileObject$Kind;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShortName", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Ljava/nio/file/FileSystem;", "private static final")]
	public static Dova.JDK.java.nio.file.FileSystem defaultFileSystem_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileSystem>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool isMacOS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/file/BaseFileManager;", "protected final")]
	public Dova.JDK.com.sun.tools.javac.file.BaseFileManager fileManager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.BaseFileManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/nio/file/Path;", "protected final")]
	public Dova.JDK.java.nio.file.Path path_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool hasParents_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PathFileObject(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/file/BaseFileManager;Ljava/nio/file/Path;)V", "protected")]
	public PathFileObject(Dova.JDK.com.sun.tools.javac.file.BaseFileManager arg0, Dova.JDK.java.nio.file.Path arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/file/PathFileObject;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/tools/FileObject;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getSimpleName(Dova.JDK.javax.tools.FileObject arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool delete()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/nio/file/Path;", "public")]
	public Dova.JDK.java.nio.file.Path getPath()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/file/PathFileObject;)Z", "")]
	public bool isSameFile(Dova.JDK.com.sun.tools.javac.file.PathFileObject arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/net/URI;", "public")]
	public Dova.JDK.java.net.URI toUri()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URI>(ret);
	}

	[JniSignatureAttribute("()J", "public")]
	public long getLastModified()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void ensureParentDirectoriesExist()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String removeExtension(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/lang/String;Ljavax/tools/JavaFileObject$Kind;)Z", "protected")]
	public bool isPathNameCompatible(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.tools.JavaFileObject.Kind arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/lang/String;", "abstract")]
	public Dova.JDK.java.lang.String inferBinaryName(Dova.JDK.java.lang.Iterable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/tools/JavaFileObject$Kind;)Z", "public")]
	public bool isNameCompatible(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.tools.JavaFileObject.Kind arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/file/PathFileObject;", "abstract")]
	public Dova.JDK.com.sun.tools.javac.file.PathFileObject getSibling(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.PathFileObject>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/file/BaseFileManager;Ljava/nio/file/Path;Ljava/nio/file/Path;)Lcom/sun/tools/javac/file/PathFileObject;", "static")]
	public static Dova.JDK.com.sun.tools.javac.file.PathFileObject forSimplePath(Dova.JDK.com.sun.tools.javac.file.BaseFileManager arg0, Dova.JDK.java.nio.file.Path arg1, Dova.JDK.java.nio.file.Path arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.PathFileObject>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/file/BaseFileManager;Ljava/nio/file/Path;Ljava/nio/file/Path;Lcom/sun/tools/javac/file/RelativePath;)Lcom/sun/tools/javac/file/PathFileObject;", "static")]
	public static Dova.JDK.com.sun.tools.javac.file.PathFileObject forDirectoryPath(Dova.JDK.com.sun.tools.javac.file.BaseFileManager arg0, Dova.JDK.java.nio.file.Path arg1, Dova.JDK.java.nio.file.Path arg2, Dova.JDK.com.sun.tools.javac.file.RelativePath arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.PathFileObject>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/element/NestingKind;", "public")]
	public Dova.JDK.javax.lang.model.element.NestingKind getNestingKind()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.NestingKind>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/element/Modifier;", "public")]
	public Dova.JDK.javax.lang.model.element.Modifier getAccessLevel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Modifier>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String toBinaryName(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/file/RelativePath;)Ljava/lang/String;", "protected static")]
	public static Dova.JDK.java.lang.String toBinaryName(Dova.JDK.com.sun.tools.javac.file.RelativePath arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/lang/String;", "protected static")]
	public static Dova.JDK.java.lang.String toBinaryName(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/file/BaseFileManager;Ljava/nio/file/Path;)Lcom/sun/tools/javac/file/PathFileObject;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.file.PathFileObject forJRTPath(Dova.JDK.com.sun.tools.javac.file.BaseFileManager arg0, Dova.JDK.java.nio.file.Path arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.PathFileObject>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/file/BaseFileManager;Ljava/nio/file/Path;Ljava/nio/file/Path;)Lcom/sun/tools/javac/file/PathFileObject;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.file.PathFileObject forJarPath(Dova.JDK.com.sun.tools.javac.file.BaseFileManager arg0, Dova.JDK.java.nio.file.Path arg1, Dova.JDK.java.nio.file.Path arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.PathFileObject>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/InputStream;", "public")]
	public Dova.JDK.java.io.InputStream openInputStream()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/OutputStream;", "public")]
	public Dova.JDK.java.io.OutputStream openOutputStream()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.OutputStream>(ret);
	}

	[JniSignatureAttribute("(Z)Ljava/io/Reader;", "public")]
	public Dova.JDK.java.io.Reader openReader(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.Reader>(ret);
	}

	[JniSignatureAttribute("(Z)Ljava/lang/CharSequence;", "public")]
	public Dova.JDK.java.lang.CharSequence getCharContent(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.CharSequence>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/Writer;", "public")]
	public Dova.JDK.java.io.Writer openWriter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.Writer>(ret);
	}

	[JniSignatureAttribute("()Ljavax/tools/JavaFileObject$Kind;", "public")]
	public Dova.JDK.javax.tools.JavaFileObject.Kind getKind()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject.Kind>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getShortName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/file/PathFileObject$DirectoryFileObject;", "private static")]
	public partial class DirectoryFileObject
		: Dova.JDK.com.sun.tools.javac.file.PathFileObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DirectoryFileObject()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/file/PathFileObject$DirectoryFileObject;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "userPackageRootDir", "Ljava/nio/file/Path;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "relativePath", "Lcom/sun/tools/javac/file/RelativePath;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/file/BaseFileManager;Ljava/nio/file/Path;Ljava/nio/file/Path;Lcom/sun/tools/javac/file/RelativePath;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inferBinaryName", "(Ljava/lang/Iterable;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSibling", "(Ljava/lang/String;)Lcom/sun/tools/javac/file/PathFileObject;"));
		}

		[JniSignatureAttribute("Ljava/nio/file/Path;", "private final")]
		public Dova.JDK.java.nio.file.Path userPackageRootDir_Property
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

		[JniSignatureAttribute("Lcom/sun/tools/javac/file/RelativePath;", "private final")]
		public Dova.JDK.com.sun.tools.javac.file.RelativePath relativePath_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.RelativePath>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DirectoryFileObject(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/file/BaseFileManager;Ljava/nio/file/Path;Ljava/nio/file/Path;Lcom/sun/tools/javac/file/RelativePath;)V", "private")]
		public DirectoryFileObject(Dova.JDK.com.sun.tools.javac.file.BaseFileManager arg0, Dova.JDK.java.nio.file.Path arg1, Dova.JDK.java.nio.file.Path arg2, Dova.JDK.com.sun.tools.javac.file.RelativePath arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/file/PathFileObject$DirectoryFileObject;";
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

		[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String inferBinaryName(Dova.JDK.java.lang.Iterable arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/file/PathFileObject;", "")]
		public Dova.JDK.com.sun.tools.javac.file.PathFileObject getSibling(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.PathFileObject>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/file/PathFileObject$JarFileObject;", "private static")]
	public partial class JarFileObject
		: Dova.JDK.com.sun.tools.javac.file.PathFileObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JarFileObject()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/file/PathFileObject$JarFileObject;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "userJarPath", "Ljava/nio/file/Path;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/file/BaseFileManager;Ljava/nio/file/Path;Ljava/nio/file/Path;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toUri", "()Ljava/net/URI;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createJarUri", "(Ljava/nio/file/Path;Ljava/lang/String;)Ljava/net/URI;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inferBinaryName", "(Ljava/lang/Iterable;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSibling", "(Ljava/lang/String;)Lcom/sun/tools/javac/file/PathFileObject;"));
		}

		[JniSignatureAttribute("Ljava/nio/file/Path;", "private final")]
		public Dova.JDK.java.nio.file.Path userJarPath_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JarFileObject(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/file/BaseFileManager;Ljava/nio/file/Path;Ljava/nio/file/Path;)V", "private")]
		public JarFileObject(Dova.JDK.com.sun.tools.javac.file.BaseFileManager arg0, Dova.JDK.java.nio.file.Path arg1, Dova.JDK.java.nio.file.Path arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/file/PathFileObject$JarFileObject;";
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

		[JniSignatureAttribute("()Ljava/net/URI;", "public")]
		public Dova.JDK.java.net.URI toUri()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.URI>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/lang/String;)Ljava/net/URI;", "private static")]
		public static Dova.JDK.java.net.URI createJarUri(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.URI>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String inferBinaryName(Dova.JDK.java.lang.Iterable arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/file/PathFileObject;", "")]
		public Dova.JDK.com.sun.tools.javac.file.PathFileObject getSibling(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.PathFileObject>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/file/PathFileObject$JRTFileObject;", "private static")]
	public partial class JRTFileObject
		: Dova.JDK.com.sun.tools.javac.file.PathFileObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JRTFileObject()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/file/PathFileObject$JRTFileObject;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/file/BaseFileManager;Ljava/nio/file/Path;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inferBinaryName", "(Ljava/lang/Iterable;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSibling", "(Ljava/lang/String;)Lcom/sun/tools/javac/file/PathFileObject;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JRTFileObject(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/file/BaseFileManager;Ljava/nio/file/Path;)V", "private")]
		public JRTFileObject(Dova.JDK.com.sun.tools.javac.file.BaseFileManager arg0, Dova.JDK.java.nio.file.Path arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/file/PathFileObject$JRTFileObject;";
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

		[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String inferBinaryName(Dova.JDK.java.lang.Iterable arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/file/PathFileObject;", "")]
		public Dova.JDK.com.sun.tools.javac.file.PathFileObject getSibling(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.PathFileObject>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/file/PathFileObject$SimpleFileObject;", "private static")]
	public partial class SimpleFileObject
		: Dova.JDK.com.sun.tools.javac.file.PathFileObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SimpleFileObject()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/file/PathFileObject$SimpleFileObject;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "userPath", "Ljava/nio/file/Path;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/file/BaseFileManager;Ljava/nio/file/Path;Ljava/nio/file/Path;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toUri", "()Ljava/net/URI;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inferBinaryName", "(Ljava/lang/Iterable;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNameCompatible", "(Ljava/lang/String;Ljavax/tools/JavaFileObject$Kind;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSibling", "(Ljava/lang/String;)Lcom/sun/tools/javac/file/PathFileObject;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Ljavax/tools/JavaFileObject$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShortName", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/nio/file/Path;", "private final")]
		public Dova.JDK.java.nio.file.Path userPath_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SimpleFileObject(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/file/BaseFileManager;Ljava/nio/file/Path;Ljava/nio/file/Path;)V", "private")]
		public SimpleFileObject(Dova.JDK.com.sun.tools.javac.file.BaseFileManager arg0, Dova.JDK.java.nio.file.Path arg1, Dova.JDK.java.nio.file.Path arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/file/PathFileObject$SimpleFileObject;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/URI;", "public")]
		public Dova.JDK.java.net.URI toUri()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.URI>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String inferBinaryName(Dova.JDK.java.lang.Iterable arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljavax/tools/JavaFileObject$Kind;)Z", "public")]
		public bool isNameCompatible(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.tools.JavaFileObject.Kind arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/file/PathFileObject;", "")]
		public Dova.JDK.com.sun.tools.javac.file.PathFileObject getSibling(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.file.PathFileObject>(ret);
		}

		[JniSignatureAttribute("()Ljavax/tools/JavaFileObject$Kind;", "public")]
		public Dova.JDK.javax.tools.JavaFileObject.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject.Kind>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getShortName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/file/PathFileObject$CannotCreateUriError;", "public static")]
	public partial class CannotCreateUriError
		: Dova.JDK.java.lang.Error
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CannotCreateUriError()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/file/PathFileObject$CannotCreateUriError;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V"));
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CannotCreateUriError(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V", "public")]
		public CannotCreateUriError(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Throwable arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/file/PathFileObject$CannotCreateUriError;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
