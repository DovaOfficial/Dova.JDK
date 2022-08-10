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

namespace Dova.JDK.jdk.@internal.jimage;

[JniSignatureAttribute("Ljdk/internal/jimage/ImageReader;", "public final")]
public partial class ImageReader
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.lang.AutoCloseable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ImageReader()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jimage/ImageReader;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "reader", "Ljdk/internal/jimage/ImageReader$SharedImageReader;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "closed", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ImageReader", "(Ljdk/internal/jimage/ImageReader$SharedImageReader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getResource", "(Ljava/lang/String;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getResource", "(Ljdk/internal/jimage/ImageReader$Node;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getResource", "(Ljdk/internal/jimage/ImageReader$Resource;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getResource", "(Ljdk/internal/jimage/ImageLocation;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "open", "(Ljava/nio/file/Path;)Ljdk/internal/jimage/ImageReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "open", "(Ljava/nio/file/Path;Ljava/nio/ByteOrder;)Ljdk/internal/jimage/ImageReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAttributes", "(I)[J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ensureOpen", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getModuleNames", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "findLocation", "(Ljava/lang/String;)Ljdk/internal/jimage/ImageLocation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "findLocation", "(Ljava/lang/String;Ljava/lang/String;)Ljdk/internal/jimage/ImageLocation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getResourceBuffer", "(Ljdk/internal/jimage/ImageLocation;)Ljava/nio/ByteBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getString", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "findNode", "(Ljava/lang/String;)Ljdk/internal/jimage/ImageReader$Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getHeader", "()Ljdk/internal/jimage/ImageHeader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "releaseByteBuffer", "(Ljava/nio/ByteBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getByteOrder", "()Ljava/nio/ByteOrder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getImagePath", "()Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getStrings", "()Ljdk/internal/jimage/ImageStringsReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "verifyLocation", "(Ljava/lang/String;Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getEntryNames", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getResourceStream", "(Ljdk/internal/jimage/ImageLocation;)Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getRootDirectory", "()Ljdk/internal/jimage/ImageReader$Directory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "requireOpen", "()V"));
	}

	[JniSignatureAttribute("Ljdk/internal/jimage/ImageReader$SharedImageReader;", "private final")]
	public Dova.JDK.jdk.@internal.jimage.ImageReader.SharedImageReader reader_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.SharedImageReader>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private volatile")]
	public bool closed_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ImageReader(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/jimage/ImageReader$SharedImageReader;)V", "private")]
	public ImageReader(Dova.JDK.jdk.@internal.jimage.ImageReader.SharedImageReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/jimage/ImageReader;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[B", "public")]
	public JavaArray<byte> getResource(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jimage/ImageReader$Node;)[B", "public")]
	public JavaArray<byte> getResource(Dova.JDK.jdk.@internal.jimage.ImageReader.Node arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jimage/ImageReader$Resource;)[B", "public")]
	public JavaArray<byte> getResource(Dova.JDK.jdk.@internal.jimage.ImageReader.Resource arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jimage/ImageLocation;)[B", "public")]
	public JavaArray<byte> getResource(Dova.JDK.jdk.@internal.jimage.ImageLocation arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljdk/internal/jimage/ImageReader;", "public static")]
	public static Dova.JDK.jdk.@internal.jimage.ImageReader open(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/nio/ByteOrder;)Ljdk/internal/jimage/ImageReader;", "public static")]
	public static Dova.JDK.jdk.@internal.jimage.ImageReader open(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.nio.ByteOrder arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader>(ret);
	}

	[JniSignatureAttribute("(I)[J", "public")]
	public JavaArray<long> getAttributes(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void ensureOpen()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getModuleNames()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/jimage/ImageLocation;", "public")]
	public Dova.JDK.jdk.@internal.jimage.ImageLocation findLocation(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageLocation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljdk/internal/jimage/ImageLocation;", "public")]
	public Dova.JDK.jdk.@internal.jimage.ImageLocation findLocation(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageLocation>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jimage/ImageLocation;)Ljava/nio/ByteBuffer;", "public")]
	public Dova.JDK.java.nio.ByteBuffer getResourceBuffer(Dova.JDK.jdk.@internal.jimage.ImageLocation arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getString(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/jimage/ImageReader$Node;", "public")]
	public Dova.JDK.jdk.@internal.jimage.ImageReader.Node findNode(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.Node>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/jimage/ImageHeader;", "public")]
	public Dova.JDK.jdk.@internal.jimage.ImageHeader getHeader()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageHeader>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)V", "public static")]
	public static void releaseByteBuffer(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("()Ljava/nio/ByteOrder;", "public")]
	public Dova.JDK.java.nio.ByteOrder getByteOrder()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteOrder>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/file/Path;", "public")]
	public Dova.JDK.java.nio.file.Path getImagePath()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/jimage/ImageStringsReader;", "public")]
	public Dova.JDK.jdk.@internal.jimage.ImageStringsReader getStrings()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageStringsReader>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Z", "public")]
	public bool verifyLocation(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getEntryNames()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jimage/ImageLocation;)Ljava/io/InputStream;", "public")]
	public Dova.JDK.java.io.InputStream getResourceStream(Dova.JDK.jdk.@internal.jimage.ImageLocation arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/jimage/ImageReader$Directory;", "public")]
	public Dova.JDK.jdk.@internal.jimage.ImageReader.Directory getRootDirectory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.Directory>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void requireOpen()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25]);
	}

	[JniSignatureAttribute("Ljdk/internal/jimage/ImageReader$SharedImageReader;", "private static final")]
	public partial class SharedImageReader
		: Dova.JDK.jdk.@internal.jimage.BasicImageReader
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SharedImageReader()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jimage/ImageReader$SharedImageReader;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SIZE_OF_OFFSET", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "OPEN_FILES", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "openers", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "imageFileAttributes", "Ljava/nio/file/attribute/BasicFileAttributes;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "nodes", "Ljava/util/HashMap;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "rootDir", "Ljdk/internal/jimage/ImageReader$Directory;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "packagesDir", "Ljdk/internal/jimage/ImageReader$Directory;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "modulesDir", "Ljdk/internal/jimage/ImageReader$Directory;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SharedImageReader", "(Ljava/nio/file/Path;Ljava/nio/ByteOrder;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getResource", "(Ljdk/internal/jimage/ImageReader$Node;)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getResource", "(Ljdk/internal/jimage/ImageReader$Resource;)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "close", "(Ljdk/internal/jimage/ImageReader;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "open", "(Ljava/nio/file/Path;Ljava/nio/ByteOrder;)Ljdk/internal/jimage/ImageReader;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "findNode", "(Ljava/lang/String;)Ljdk/internal/jimage/ImageReader$Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getRootDirectory", "()Ljdk/internal/jimage/ImageReader$Directory;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "buildRootDirectory", "()Ljdk/internal/jimage/ImageReader$Directory;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handlePackages", "(Ljava/lang/String;Ljdk/internal/jimage/ImageLocation;)Ljdk/internal/jimage/ImageReader$Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handleModulesSubTree", "(Ljava/lang/String;Ljdk/internal/jimage/ImageLocation;)Ljdk/internal/jimage/ImageReader$Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handleResource", "(Ljava/lang/String;)Ljdk/internal/jimage/ImageReader$Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handleModuleLink", "(Ljava/lang/String;)Ljdk/internal/jimage/ImageReader$Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newDirectory", "(Ljdk/internal/jimage/ImageReader$Directory;Ljava/lang/String;)Ljdk/internal/jimage/ImageReader$Directory;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getBaseExt", "(Ljdk/internal/jimage/ImageLocation;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newLinkNode", "(Ljdk/internal/jimage/ImageReader$Directory;Ljava/lang/String;Ljdk/internal/jimage/ImageReader$Node;)Ljdk/internal/jimage/ImageReader$LinkNode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLocation", "(Ljdk/internal/jimage/ImageLocation;Ljdk/internal/jimage/ImageReader$SharedImageReader$LocationVisitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitPackageLocation", "(Ljdk/internal/jimage/ImageLocation;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "makeDirectories", "(Ljava/lang/String;)Ljdk/internal/jimage/ImageReader$Directory;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newResource", "(Ljdk/internal/jimage/ImageReader$Directory;Ljdk/internal/jimage/ImageLocation;)Ljdk/internal/jimage/ImageReader$Resource;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "buildNode", "(Ljava/lang/String;)Ljdk/internal/jimage/ImageReader$Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "imageFileAttributes", "()Ljava/nio/file/attribute/BasicFileAttributes;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "makeDirectory", "(Ljava/lang/String;Ljdk/internal/jimage/ImageReader$Directory;)Ljdk/internal/jimage/ImageReader$Directory;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addOpener", "(Ljdk/internal/jimage/ImageReader;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeOpener", "(Ljdk/internal/jimage/ImageReader;)Z"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int SIZE_OF_OFFSET_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("Ljava/util/Map;", "static final")]
		public static Dova.JDK.java.util.Map OPEN_FILES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Set;", "final")]
		public Dova.JDK.java.util.Set openers_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/nio/file/attribute/BasicFileAttributes;", "")]
		public Dova.JDK.java.nio.file.attribute.BasicFileAttributes imageFileAttributes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.BasicFileAttributes>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/HashMap;", "final")]
		public Dova.JDK.java.util.HashMap nodes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/jimage/ImageReader$Directory;", "volatile")]
		public Dova.JDK.jdk.@internal.jimage.ImageReader.Directory rootDir_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.Directory>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/jimage/ImageReader$Directory;", "")]
		public Dova.JDK.jdk.@internal.jimage.ImageReader.Directory packagesDir_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.Directory>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/jimage/ImageReader$Directory;", "")]
		public Dova.JDK.jdk.@internal.jimage.ImageReader.Directory modulesDir_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.Directory>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[8]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[8], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SharedImageReader(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/nio/ByteOrder;)V", "private")]
		public SharedImageReader(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.nio.ByteOrder arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jimage/ImageReader$SharedImageReader;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/internal/jimage/ImageReader$Node;)[B", "")]
		public JavaArray<byte> getResource(Dova.JDK.jdk.@internal.jimage.ImageReader.Node arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/jimage/ImageReader$Resource;)[B", "")]
		public JavaArray<byte> getResource(Dova.JDK.jdk.@internal.jimage.ImageReader.Resource arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/jimage/ImageReader;)V", "public")]
		public void close(Dova.JDK.jdk.@internal.jimage.ImageReader arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/nio/ByteOrder;)Ljdk/internal/jimage/ImageReader;", "public static")]
		public static Dova.JDK.jdk.@internal.jimage.ImageReader open(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.nio.ByteOrder arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/jimage/ImageReader$Node;", "synchronized")]
		public Dova.JDK.jdk.@internal.jimage.ImageReader.Node findNode(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.Node>(ret);
		}

		[JniSignatureAttribute("()Ljdk/internal/jimage/ImageReader$Directory;", "")]
		public Dova.JDK.jdk.@internal.jimage.ImageReader.Directory getRootDirectory()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.Directory>(ret);
		}

		[JniSignatureAttribute("()Ljdk/internal/jimage/ImageReader$Directory;", "synchronized")]
		public Dova.JDK.jdk.@internal.jimage.ImageReader.Directory buildRootDirectory()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.Directory>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljdk/internal/jimage/ImageLocation;)Ljdk/internal/jimage/ImageReader$Node;", "")]
		public Dova.JDK.jdk.@internal.jimage.ImageReader.Node handlePackages(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.@internal.jimage.ImageLocation arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.Node>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljdk/internal/jimage/ImageLocation;)Ljdk/internal/jimage/ImageReader$Node;", "")]
		public Dova.JDK.jdk.@internal.jimage.ImageReader.Node handleModulesSubTree(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.@internal.jimage.ImageLocation arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.Node>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/jimage/ImageReader$Node;", "")]
		public Dova.JDK.jdk.@internal.jimage.ImageReader.Node handleResource(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.Node>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/jimage/ImageReader$Node;", "")]
		public Dova.JDK.jdk.@internal.jimage.ImageReader.Node handleModuleLink(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.Node>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/jimage/ImageReader$Directory;Ljava/lang/String;)Ljdk/internal/jimage/ImageReader$Directory;", "")]
		public Dova.JDK.jdk.@internal.jimage.ImageReader.Directory newDirectory(Dova.JDK.jdk.@internal.jimage.ImageReader.Directory arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.Directory>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/jimage/ImageLocation;)Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String getBaseExt(Dova.JDK.jdk.@internal.jimage.ImageLocation arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/jimage/ImageReader$Directory;Ljava/lang/String;Ljdk/internal/jimage/ImageReader$Node;)Ljdk/internal/jimage/ImageReader$LinkNode;", "")]
		public Dova.JDK.jdk.@internal.jimage.ImageReader.LinkNode newLinkNode(Dova.JDK.jdk.@internal.jimage.ImageReader.Directory arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.jdk.@internal.jimage.ImageReader.Node arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.LinkNode>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/jimage/ImageLocation;Ljdk/internal/jimage/ImageReader$SharedImageReader$LocationVisitor;)V", "")]
		public void visitLocation(Dova.JDK.jdk.@internal.jimage.ImageLocation arg0, Dova.JDK.jdk.@internal.jimage.ImageReader.SharedImageReader.LocationVisitor arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljdk/internal/jimage/ImageLocation;)V", "")]
		public void visitPackageLocation(Dova.JDK.jdk.@internal.jimage.ImageLocation arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/jimage/ImageReader$Directory;", "")]
		public Dova.JDK.jdk.@internal.jimage.ImageReader.Directory makeDirectories(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.Directory>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/jimage/ImageReader$Directory;Ljdk/internal/jimage/ImageLocation;)Ljdk/internal/jimage/ImageReader$Resource;", "")]
		public Dova.JDK.jdk.@internal.jimage.ImageReader.Resource newResource(Dova.JDK.jdk.@internal.jimage.ImageReader.Directory arg0, Dova.JDK.jdk.@internal.jimage.ImageLocation arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.Resource>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/jimage/ImageReader$Node;", "synchronized")]
		public Dova.JDK.jdk.@internal.jimage.ImageReader.Node buildNode(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.Node>(ret);
		}

		[JniSignatureAttribute("()Ljava/nio/file/attribute/BasicFileAttributes;", "")]
		public Dova.JDK.java.nio.file.attribute.BasicFileAttributes imageFileAttributes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.BasicFileAttributes>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljdk/internal/jimage/ImageReader$Directory;)Ljdk/internal/jimage/ImageReader$Directory;", "")]
		public Dova.JDK.jdk.@internal.jimage.ImageReader.Directory makeDirectory(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.@internal.jimage.ImageReader.Directory arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.Directory>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/jimage/ImageReader;)V", "")]
		public void addOpener(Dova.JDK.jdk.@internal.jimage.ImageReader arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		}

		[JniSignatureAttribute("(Ljdk/internal/jimage/ImageReader;)Z", "")]
		public bool removeOpener(Dova.JDK.jdk.@internal.jimage.ImageReader arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
			return ret;
		}

		[JniSignatureAttribute("Ljdk/internal/jimage/ImageReader$SharedImageReader$LocationVisitor;", "abstract static interface")]
		public partial interface LocationVisitor
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static LocationVisitor()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jimage/ImageReader$SharedImageReader$LocationVisitor;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visit", "(Ljdk/internal/jimage/ImageLocation;)V"));
			}

			[JniSignatureAttribute("(Ljdk/internal/jimage/ImageLocation;)V", "public abstract")]
			void visit(Dova.JDK.jdk.@internal.jimage.ImageLocation arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jimage/ImageReader$Directory;", "static final")]
	public partial class Directory
		: Dova.JDK.jdk.@internal.jimage.ImageReader.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Directory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jimage/ImageReader$Directory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "children", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Directory", "(Ljava/lang/String;Ljava/nio/file/attribute/BasicFileAttributes;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "create", "(Ljdk/internal/jimage/ImageReader$Directory;Ljava/lang/String;Ljava/nio/file/attribute/BasicFileAttributes;)Ljdk/internal/jimage/ImageReader$Directory;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "walk", "(Ljava/util/function/Consumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isDirectory", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getChildren", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addChild", "(Ljdk/internal/jimage/ImageReader$Node;)V"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List children_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Directory(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/nio/file/attribute/BasicFileAttributes;)V", "private")]
		public Directory(Dova.JDK.java.lang.String arg0, Dova.JDK.java.nio.file.attribute.BasicFileAttributes arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jimage/ImageReader$Directory;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/internal/jimage/ImageReader$Directory;Ljava/lang/String;Ljava/nio/file/attribute/BasicFileAttributes;)Ljdk/internal/jimage/ImageReader$Directory;", "static")]
		public static Dova.JDK.jdk.@internal.jimage.ImageReader.Directory create(Dova.JDK.jdk.@internal.jimage.ImageReader.Directory arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.nio.file.attribute.BasicFileAttributes arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.Directory>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)V", "public")]
		public void walk(Dova.JDK.java.util.function.Consumer arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isDirectory()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getChildren()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/jimage/ImageReader$Node;)V", "")]
		public void addChild(Dova.JDK.jdk.@internal.jimage.ImageReader.Node arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jimage/ImageReader$Node;", "public abstract static")]
	public partial class Node
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Node()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jimage/ImageReader$Node;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ROOT_DIR", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PACKAGES_DIR", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MODULES_DIR", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "flags", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fileAttrs", "Ljava/nio/file/attribute/BasicFileAttributes;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "completed", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Node", "(Ljava/lang/String;Ljava/nio/file/attribute/BasicFileAttributes;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "size", "()J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLocation", "()Ljdk/internal/jimage/ImageLocation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isDirectory", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "lastModifiedTime", "()Ljava/nio/file/attribute/FileTime;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "lastAccessTime", "()Ljava/nio/file/attribute/FileTime;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "creationTime", "()Ljava/nio/file/attribute/FileTime;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compressedSize", "()J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getChildren", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getNameString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setIsRootDir", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setIsPackagesDir", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setIsModulesDir", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setCompleted", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isCompleted", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isResource", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "extension", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "resolveLink", "()Ljdk/internal/jimage/ImageReader$Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "resolveLink", "(Z)Ljdk/internal/jimage/ImageReader$Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isRootDir", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isPackagesDir", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isModulesDir", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFileAttributes", "()Ljava/nio/file/attribute/BasicFileAttributes;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isLink", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "contentOffset", "()J"));
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int ROOT_DIR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int PACKAGES_DIR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int MODULES_DIR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("I", "private")]
		public int flags_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/nio/file/attribute/BasicFileAttributes;", "private final")]
		public Dova.JDK.java.nio.file.attribute.BasicFileAttributes fileAttrs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.BasicFileAttributes>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "private")]
		public bool completed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Node(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/nio/file/attribute/BasicFileAttributes;)V", "protected")]
		public Node(Dova.JDK.java.lang.String arg0, Dova.JDK.java.nio.file.attribute.BasicFileAttributes arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jimage/ImageReader$Node;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public final")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public final")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public final")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public final")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()J", "public")]
		public long size()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Ljdk/internal/jimage/ImageLocation;", "public")]
		public Dova.JDK.jdk.@internal.jimage.ImageLocation getLocation()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageLocation>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isDirectory()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/nio/file/attribute/FileTime;", "public final")]
		public Dova.JDK.java.nio.file.attribute.FileTime lastModifiedTime()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.FileTime>(ret);
		}

		[JniSignatureAttribute("()Ljava/nio/file/attribute/FileTime;", "public final")]
		public Dova.JDK.java.nio.file.attribute.FileTime lastAccessTime()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.FileTime>(ret);
		}

		[JniSignatureAttribute("()Ljava/nio/file/attribute/FileTime;", "public final")]
		public Dova.JDK.java.nio.file.attribute.FileTime creationTime()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.FileTime>(ret);
		}

		[JniSignatureAttribute("()J", "public")]
		public long compressedSize()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[10]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getChildren()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public final")]
		public Dova.JDK.java.lang.String getNameString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()V", "public final")]
		public void setIsRootDir()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
		}

		[JniSignatureAttribute("()V", "public final")]
		public void setIsPackagesDir()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14]);
		}

		[JniSignatureAttribute("()V", "public final")]
		public void setIsModulesDir()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15]);
		}

		[JniSignatureAttribute("(Z)V", "public")]
		public void setCompleted(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isCompleted()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isResource()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String extension()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljdk/internal/jimage/ImageReader$Node;", "public final")]
		public Dova.JDK.jdk.@internal.jimage.ImageReader.Node resolveLink()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.Node>(ret);
		}

		[JniSignatureAttribute("(Z)Ljdk/internal/jimage/ImageReader$Node;", "public")]
		public Dova.JDK.jdk.@internal.jimage.ImageReader.Node resolveLink(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.Node>(ret);
		}

		[JniSignatureAttribute("()Z", "public final")]
		public bool isRootDir()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public final")]
		public bool isPackagesDir()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public final")]
		public bool isModulesDir()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/nio/file/attribute/BasicFileAttributes;", "public final")]
		public Dova.JDK.java.nio.file.attribute.BasicFileAttributes getFileAttributes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.BasicFileAttributes>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isLink()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26]);
			return ret;
		}

		[JniSignatureAttribute("()J", "public")]
		public long contentOffset()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[27]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jimage/ImageReader$Resource;", "static")]
	public partial class Resource
		: Dova.JDK.jdk.@internal.jimage.ImageReader.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Resource()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jimage/ImageReader$Resource;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "loc", "Ljdk/internal/jimage/ImageLocation;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Resource", "(Ljdk/internal/jimage/ImageLocation;Ljava/nio/file/attribute/BasicFileAttributes;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "size", "()J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLocation", "()Ljdk/internal/jimage/ImageLocation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "create", "(Ljdk/internal/jimage/ImageReader$Directory;Ljdk/internal/jimage/ImageLocation;Ljava/nio/file/attribute/BasicFileAttributes;)Ljdk/internal/jimage/ImageReader$Resource;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compressedSize", "()J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isCompleted", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isResource", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "extension", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "contentOffset", "()J"));
		}

		[JniSignatureAttribute("Ljdk/internal/jimage/ImageLocation;", "private final")]
		public Dova.JDK.jdk.@internal.jimage.ImageLocation loc_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageLocation>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Resource(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/jimage/ImageLocation;Ljava/nio/file/attribute/BasicFileAttributes;)V", "private")]
		public Resource(Dova.JDK.jdk.@internal.jimage.ImageLocation arg0, Dova.JDK.java.nio.file.attribute.BasicFileAttributes arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jimage/ImageReader$Resource;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()J", "public")]
		public long size()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Ljdk/internal/jimage/ImageLocation;", "public")]
		public Dova.JDK.jdk.@internal.jimage.ImageLocation getLocation()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageLocation>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/jimage/ImageReader$Directory;Ljdk/internal/jimage/ImageLocation;Ljava/nio/file/attribute/BasicFileAttributes;)Ljdk/internal/jimage/ImageReader$Resource;", "static")]
		public static Dova.JDK.jdk.@internal.jimage.ImageReader.Resource create(Dova.JDK.jdk.@internal.jimage.ImageReader.Directory arg0, Dova.JDK.jdk.@internal.jimage.ImageLocation arg1, Dova.JDK.java.nio.file.attribute.BasicFileAttributes arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.Resource>(ret);
		}

		[JniSignatureAttribute("()J", "public")]
		public long compressedSize()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isCompleted()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isResource()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String extension()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()J", "public")]
		public long contentOffset()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jimage/ImageReader$LinkNode;", "static")]
	public partial class LinkNode
		: Dova.JDK.jdk.@internal.jimage.ImageReader.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LinkNode()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jimage/ImageReader$LinkNode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "link", "Ljdk/internal/jimage/ImageReader$Node;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "LinkNode", "(Ljava/lang/String;Ljdk/internal/jimage/ImageReader$Node;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "create", "(Ljdk/internal/jimage/ImageReader$Directory;Ljava/lang/String;Ljdk/internal/jimage/ImageReader$Node;)Ljdk/internal/jimage/ImageReader$LinkNode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isCompleted", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "resolveLink", "(Z)Ljdk/internal/jimage/ImageReader$Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isLink", "()Z"));
		}

		[JniSignatureAttribute("Ljdk/internal/jimage/ImageReader$Node;", "private final")]
		public Dova.JDK.jdk.@internal.jimage.ImageReader.Node link_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.Node>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LinkNode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljdk/internal/jimage/ImageReader$Node;)V", "private")]
		public LinkNode(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.@internal.jimage.ImageReader.Node arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jimage/ImageReader$LinkNode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/internal/jimage/ImageReader$Directory;Ljava/lang/String;Ljdk/internal/jimage/ImageReader$Node;)Ljdk/internal/jimage/ImageReader$LinkNode;", "static")]
		public static Dova.JDK.jdk.@internal.jimage.ImageReader.LinkNode create(Dova.JDK.jdk.@internal.jimage.ImageReader.Directory arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.jdk.@internal.jimage.ImageReader.Node arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.LinkNode>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isCompleted()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(Z)Ljdk/internal/jimage/ImageReader$Node;", "public")]
		public Dova.JDK.jdk.@internal.jimage.ImageReader.Node resolveLink(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.Node>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isLink()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}
	}
}
