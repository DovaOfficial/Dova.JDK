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

namespace Dova.JDK.jdk.jpackage.@internal;

[JniSignatureAttribute("Ljdk/jpackage/internal/OverridableResource;", "final")]
public partial class OverridableResource
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static OverridableResource()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jpackage/internal/OverridableResource;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "substitutionData", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "category", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resourceDir", "Ljava/nio/file/Path;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "publicName", "Ljava/nio/file/Path;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "logPublicName", "Ljava/nio/file/Path;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "externalPath", "Ljava/nio/file/Path;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sources", "Ljava/util/List;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHandler", "(Ljdk/jpackage/internal/OverridableResource$Source;)Ljdk/jpackage/internal/OverridableResource$SourceHandler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toPath", "(Ljava/io/File;)Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrintableCategory", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processResourceStream", "(Ljava/io/InputStream;Ljdk/jpackage/internal/OverridableResource$ResourceConsumer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setResourceDir", "(Ljava/io/File;)Ljdk/jpackage/internal/OverridableResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setResourceDir", "(Ljava/nio/file/Path;)Ljdk/jpackage/internal/OverridableResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPublicName", "(Ljava/lang/String;)Ljdk/jpackage/internal/OverridableResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPublicName", "(Ljava/nio/file/Path;)Ljdk/jpackage/internal/OverridableResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLogPublicName", "(Ljava/nio/file/Path;)Ljdk/jpackage/internal/OverridableResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLogPublicName", "(Ljava/lang/String;)Ljdk/jpackage/internal/OverridableResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setExternal", "(Ljava/io/File;)Ljdk/jpackage/internal/OverridableResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setExternal", "(Ljava/nio/file/Path;)Ljdk/jpackage/internal/OverridableResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendToConsumer", "(Ljdk/jpackage/internal/OverridableResource$ResourceConsumer;)Ljdk/jpackage/internal/OverridableResource$Source;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readDefault", "(Ljava/lang/String;)Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "substitute", "(Ljava/util/stream/Stream;Ljava/util/Map;)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSubstitutionData", "(Ljava/util/Map;)Ljdk/jpackage/internal/OverridableResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCategory", "(Ljava/lang/String;)Ljdk/jpackage/internal/OverridableResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "saveToStream", "(Ljava/io/OutputStream;)Ljdk/jpackage/internal/OverridableResource$Source;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createResource", "(Ljava/lang/String;Ljava/util/Map;)Ljdk/jpackage/internal/OverridableResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "useExternal", "(Ljdk/jpackage/internal/OverridableResource$ResourceConsumer;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "useResourceDir", "(Ljdk/jpackage/internal/OverridableResource$ResourceConsumer;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "useDefault", "(Ljdk/jpackage/internal/OverridableResource$ResourceConsumer;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSourceOrder", "([Ljdk/jpackage/internal/OverridableResource$Source;)Ljdk/jpackage/internal/OverridableResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "saveToFile", "(Ljava/io/File;)Ljdk/jpackage/internal/OverridableResource$Source;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "saveToFile", "(Ljava/nio/file/Path;)Ljdk/jpackage/internal/OverridableResource$Source;"));
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map substitutionData_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String category_Property
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

	[JniSignatureAttribute("Ljava/nio/file/Path;", "private")]
	public Dova.JDK.java.nio.file.Path resourceDir_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/nio/file/Path;", "private")]
	public Dova.JDK.java.nio.file.Path publicName_Property
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

	[JniSignatureAttribute("Ljava/nio/file/Path;", "private")]
	public Dova.JDK.java.nio.file.Path logPublicName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/nio/file/Path;", "private")]
	public Dova.JDK.java.nio.file.Path externalPath_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String defaultName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List sources_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public OverridableResource(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
	public OverridableResource(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jpackage/internal/OverridableResource;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/jpackage/internal/OverridableResource$Source;)Ljdk/jpackage/internal/OverridableResource$SourceHandler;", "private")]
	public Dova.JDK.jdk.jpackage.@internal.OverridableResource.SourceHandler getHandler(Dova.JDK.jdk.jpackage.@internal.OverridableResource.Source arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.OverridableResource.SourceHandler>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljava/nio/file/Path;", "private static")]
	public static Dova.JDK.java.nio.file.Path toPath(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getPrintableCategory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljdk/jpackage/internal/OverridableResource$ResourceConsumer;)V", "private")]
	public void processResourceStream(Dova.JDK.java.io.InputStream arg0, Dova.JDK.jdk.jpackage.@internal.OverridableResource.ResourceConsumer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljdk/jpackage/internal/OverridableResource;", "")]
	public Dova.JDK.jdk.jpackage.@internal.OverridableResource setResourceDir(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.OverridableResource>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljdk/jpackage/internal/OverridableResource;", "")]
	public Dova.JDK.jdk.jpackage.@internal.OverridableResource setResourceDir(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.OverridableResource>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/jpackage/internal/OverridableResource;", "")]
	public Dova.JDK.jdk.jpackage.@internal.OverridableResource setPublicName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.OverridableResource>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljdk/jpackage/internal/OverridableResource;", "")]
	public Dova.JDK.jdk.jpackage.@internal.OverridableResource setPublicName(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.OverridableResource>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljdk/jpackage/internal/OverridableResource;", "")]
	public Dova.JDK.jdk.jpackage.@internal.OverridableResource setLogPublicName(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.OverridableResource>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/jpackage/internal/OverridableResource;", "")]
	public Dova.JDK.jdk.jpackage.@internal.OverridableResource setLogPublicName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.OverridableResource>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljdk/jpackage/internal/OverridableResource;", "")]
	public Dova.JDK.jdk.jpackage.@internal.OverridableResource setExternal(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.OverridableResource>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljdk/jpackage/internal/OverridableResource;", "")]
	public Dova.JDK.jdk.jpackage.@internal.OverridableResource setExternal(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.OverridableResource>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jpackage/internal/OverridableResource$ResourceConsumer;)Ljdk/jpackage/internal/OverridableResource$Source;", "private")]
	public Dova.JDK.jdk.jpackage.@internal.OverridableResource.Source sendToConsumer(Dova.JDK.jdk.jpackage.@internal.OverridableResource.ResourceConsumer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.OverridableResource.Source>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/io/InputStream;", "static")]
	public static Dova.JDK.java.io.InputStream readDefault(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/Stream;Ljava/util/Map;)Ljava/util/stream/Stream;", "private static")]
	public static Dova.JDK.java.util.stream.Stream substitute(Dova.JDK.java.util.stream.Stream arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)Ljdk/jpackage/internal/OverridableResource;", "")]
	public Dova.JDK.jdk.jpackage.@internal.OverridableResource setSubstitutionData(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.OverridableResource>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/jpackage/internal/OverridableResource;", "")]
	public Dova.JDK.jdk.jpackage.@internal.OverridableResource setCategory(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.OverridableResource>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/OutputStream;)Ljdk/jpackage/internal/OverridableResource$Source;", "")]
	public Dova.JDK.jdk.jpackage.@internal.OverridableResource.Source saveToStream(Dova.JDK.java.io.OutputStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.OverridableResource.Source>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Map;)Ljdk/jpackage/internal/OverridableResource;", "static")]
	public static Dova.JDK.jdk.jpackage.@internal.OverridableResource createResource(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.OverridableResource>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jpackage/internal/OverridableResource$ResourceConsumer;)Z", "private")]
	public bool useExternal(Dova.JDK.jdk.jpackage.@internal.OverridableResource.ResourceConsumer arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/jpackage/internal/OverridableResource$ResourceConsumer;)Z", "private")]
	public bool useResourceDir(Dova.JDK.jdk.jpackage.@internal.OverridableResource.ResourceConsumer arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/jpackage/internal/OverridableResource$ResourceConsumer;)Z", "private")]
	public bool useDefault(Dova.JDK.jdk.jpackage.@internal.OverridableResource.ResourceConsumer arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("([Ljdk/jpackage/internal/OverridableResource$Source;)Ljdk/jpackage/internal/OverridableResource;", "transient")]
	public Dova.JDK.jdk.jpackage.@internal.OverridableResource setSourceOrder(JavaArray<Dova.JDK.jdk.jpackage.@internal.OverridableResource.Source> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.OverridableResource>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljdk/jpackage/internal/OverridableResource$Source;", "")]
	public Dova.JDK.jdk.jpackage.@internal.OverridableResource.Source saveToFile(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.OverridableResource.Source>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljdk/jpackage/internal/OverridableResource$Source;", "")]
	public Dova.JDK.jdk.jpackage.@internal.OverridableResource.Source saveToFile(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.OverridableResource.Source>(ret);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/OverridableResource$Source;", "static final")]
	public partial class Source
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Source()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jpackage/internal/OverridableResource$Source;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "External", "Ljdk/jpackage/internal/OverridableResource$Source;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ResourceDir", "Ljdk/jpackage/internal/OverridableResource$Source;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DefaultResource", "Ljdk/jpackage/internal/OverridableResource$Source;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/jpackage/internal/OverridableResource$Source;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/jpackage/internal/OverridableResource$Source;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/jpackage/internal/OverridableResource$Source;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/jpackage/internal/OverridableResource$Source;"));
		}

		[JniSignatureAttribute("Ljdk/jpackage/internal/OverridableResource$Source;", "public static final")]
		public static Dova.JDK.jdk.jpackage.@internal.OverridableResource.Source External_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.OverridableResource.Source>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jpackage/internal/OverridableResource$Source;", "public static final")]
		public static Dova.JDK.jdk.jpackage.@internal.OverridableResource.Source ResourceDir_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.OverridableResource.Source>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jpackage/internal/OverridableResource$Source;", "public static final")]
		public static Dova.JDK.jdk.jpackage.@internal.OverridableResource.Source DefaultResource_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.OverridableResource.Source>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/jpackage/internal/OverridableResource$Source;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.jpackage.@internal.OverridableResource.Source> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.jpackage.@internal.OverridableResource.Source>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Source(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Source(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jpackage/internal/OverridableResource$Source;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/jpackage/internal/OverridableResource$Source;", "public static")]
		public static JavaArray<Dova.JDK.jdk.jpackage.@internal.OverridableResource.Source> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.jpackage.@internal.OverridableResource.Source>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/jpackage/internal/OverridableResource$Source;", "public static")]
		public static Dova.JDK.jdk.jpackage.@internal.OverridableResource.Source valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.OverridableResource.Source>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/jpackage/internal/OverridableResource$Source;", "private static")]
		public static JavaArray<Dova.JDK.jdk.jpackage.@internal.OverridableResource.Source> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.jpackage.@internal.OverridableResource.Source>>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/OverridableResource$ResourceConsumer;", "private abstract static interface")]
	public partial interface ResourceConsumer
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ResourceConsumer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jpackage/internal/OverridableResource$ResourceConsumer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "consume", "(Ljava/io/InputStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "publicName", "()Ljava/nio/file/Path;"));
		}

		[JniSignatureAttribute("(Ljava/io/InputStream;)V", "public abstract")]
		void consume(Dova.JDK.java.io.InputStream arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()Ljava/nio/file/Path;", "public abstract")]
		Dova.JDK.java.nio.file.Path publicName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/OverridableResource$SourceHandler;", "private abstract static interface")]
	public partial interface SourceHandler
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SourceHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jpackage/internal/OverridableResource$SourceHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Ljdk/jpackage/internal/OverridableResource$ResourceConsumer;)Z"));
		}

		[JniSignatureAttribute("(Ljdk/jpackage/internal/OverridableResource$ResourceConsumer;)Z", "public abstract")]
		bool apply(Dova.JDK.jdk.jpackage.@internal.OverridableResource.ResourceConsumer arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}
	}
}
