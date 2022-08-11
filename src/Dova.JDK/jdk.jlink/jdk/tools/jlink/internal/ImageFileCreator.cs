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

namespace Dova.JDK.jdk.tools.jlink.@internal;

[JniSignatureAttribute("Ljdk/tools/jlink/internal/ImageFileCreator;", "public final")]
public partial class ImageFileCreator
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ImageFileCreator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/tools/jlink/internal/ImageFileCreator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "entriesForModule", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "plugins", "Ljdk/tools/jlink/internal/ImagePluginStack;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/tools/jlink/internal/ImagePluginStack;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toPackage", "(Ljava/lang/String;Z)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toPackage", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Ljava/util/Set;Ljava/nio/ByteOrder;Ljdk/tools/jlink/internal/ImagePluginStack;)Ljdk/tools/jlink/internal/ExecutableImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Ljava/util/Set;Ljava/nio/ByteOrder;)Ljdk/tools/jlink/internal/ExecutableImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Ljava/util/Set;Ljdk/tools/jlink/internal/ImagePluginStack;)Ljdk/tools/jlink/internal/ExecutableImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "resourceName", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "generateJImage", "(Ljdk/tools/jlink/internal/ResourcePoolManager;Ljdk/tools/jlink/internal/BasicImageWriter;Ljdk/tools/jlink/internal/ImagePluginStack;Ljava/io/DataOutputStream;)Ljdk/tools/jlink/plugin/ResourcePool;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createPoolManager", "(Ljava/util/Set;Ljava/util/Map;Ljava/nio/ByteOrder;Ljdk/tools/jlink/internal/BasicImageWriter;)Ljdk/tools/jlink/internal/ResourcePoolManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "recreateJimage", "(Ljava/nio/file/Path;Ljava/util/Set;Ljdk/tools/jlink/internal/ImagePluginStack;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readAllEntries", "(Ljava/util/Set;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "splitPath", "(Ljava/lang/String;)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeImage", "(Ljava/util/Set;Ljava/nio/ByteOrder;)V"));
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map entriesForModule_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/tools/jlink/internal/ImagePluginStack;", "private final")]
	public Dova.JDK.jdk.tools.jlink.@internal.ImagePluginStack plugins_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.ImagePluginStack>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ImageFileCreator(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/tools/jlink/internal/ImagePluginStack;)V", "private")]
	public ImageFileCreator(Dova.JDK.jdk.tools.jlink.@internal.ImagePluginStack arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/tools/jlink/internal/ImageFileCreator;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;Z)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String toPackage(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String toPackage(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Set;Ljava/nio/ByteOrder;Ljdk/tools/jlink/internal/ImagePluginStack;)Ljdk/tools/jlink/internal/ExecutableImage;", "public static")]
	public static Dova.JDK.jdk.tools.jlink.@internal.ExecutableImage create(Dova.JDK.java.util.Set arg0, Dova.JDK.java.nio.ByteOrder arg1, Dova.JDK.jdk.tools.jlink.@internal.ImagePluginStack arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.ExecutableImage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Set;Ljava/nio/ByteOrder;)Ljdk/tools/jlink/internal/ExecutableImage;", "public static")]
	public static Dova.JDK.jdk.tools.jlink.@internal.ExecutableImage create(Dova.JDK.java.util.Set arg0, Dova.JDK.java.nio.ByteOrder arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.ExecutableImage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Set;Ljdk/tools/jlink/internal/ImagePluginStack;)Ljdk/tools/jlink/internal/ExecutableImage;", "public static")]
	public static Dova.JDK.jdk.tools.jlink.@internal.ExecutableImage create(Dova.JDK.java.util.Set arg0, Dova.JDK.jdk.tools.jlink.@internal.ImagePluginStack arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.ExecutableImage>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String resourceName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/tools/jlink/internal/ResourcePoolManager;Ljdk/tools/jlink/internal/BasicImageWriter;Ljdk/tools/jlink/internal/ImagePluginStack;Ljava/io/DataOutputStream;)Ljdk/tools/jlink/plugin/ResourcePool;", "private static")]
	public static Dova.JDK.jdk.tools.jlink.plugin.ResourcePool generateJImage(Dova.JDK.jdk.tools.jlink.@internal.ResourcePoolManager arg0, Dova.JDK.jdk.tools.jlink.@internal.BasicImageWriter arg1, Dova.JDK.jdk.tools.jlink.@internal.ImagePluginStack arg2, Dova.JDK.java.io.DataOutputStream arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.plugin.ResourcePool>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Set;Ljava/util/Map;Ljava/nio/ByteOrder;Ljdk/tools/jlink/internal/BasicImageWriter;)Ljdk/tools/jlink/internal/ResourcePoolManager;", "private static")]
	public static Dova.JDK.jdk.tools.jlink.@internal.ResourcePoolManager createPoolManager(Dova.JDK.java.util.Set arg0, Dova.JDK.java.util.Map arg1, Dova.JDK.java.nio.ByteOrder arg2, Dova.JDK.jdk.tools.jlink.@internal.BasicImageWriter arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.tools.jlink.@internal.ResourcePoolManager>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/util/Set;Ljdk/tools/jlink/internal/ImagePluginStack;)V", "public static")]
	public static void recreateJimage(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.util.Set arg1, Dova.JDK.jdk.tools.jlink.@internal.ImagePluginStack arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/util/Set;)V", "private")]
	public void readAllEntries(Dova.JDK.java.util.Set arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[Ljava/lang/String;", "public static")]
	public static JavaArray<Dova.JDK.java.lang.String> splitPath(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Set;Ljava/nio/ByteOrder;)V", "private")]
	public void writeImage(Dova.JDK.java.util.Set arg0, Dova.JDK.java.nio.ByteOrder arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}
}
