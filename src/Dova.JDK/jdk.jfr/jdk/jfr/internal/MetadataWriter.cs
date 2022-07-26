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

namespace Dova.JDK.jdk.jfr.@internal;

[JniSignatureAttribute("Ljdk/jfr/internal/MetadataWriter;", "final")]
public partial class MetadataWriter
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MetadataWriter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/MetadataWriter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "metadata", "Ljdk/jfr/internal/MetadataDescriptor$Element;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "root", "Ljdk/jfr/internal/MetadataDescriptor$Element;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/jfr/internal/MetadataDescriptor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljava/io/DataOutput;Ljdk/jfr/internal/MetadataDescriptor$Element;Ljava/util/HashMap;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeInt", "(Ljava/io/DataOutput;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeString", "(Ljava/io/DataOutput;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeBinary", "(Ljava/io/DataOutput;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildStringPool", "(Ljdk/jfr/internal/MetadataDescriptor$Element;Ljava/util/Set;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeSettingElement", "(Ljdk/jfr/internal/MetadataDescriptor$Element;Ljdk/jfr/SettingDescriptor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeFieldElement", "(Ljdk/jfr/internal/MetadataDescriptor$Element;Ljdk/jfr/ValueDescriptor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeAnnotation", "(Ljdk/jfr/internal/MetadataDescriptor$Element;Ljdk/jfr/AnnotationElement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeTypeElement", "(Ljdk/jfr/internal/MetadataDescriptor$Element;Ljdk/jfr/internal/Type;)V"));
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/MetadataDescriptor$Element;", "private final")]
	public Dova.JDK.jdk.jfr.@internal.MetadataDescriptor.Element metadata_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.MetadataDescriptor.Element>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/MetadataDescriptor$Element;", "private final")]
	public Dova.JDK.jdk.jfr.@internal.MetadataDescriptor.Element root_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.MetadataDescriptor.Element>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MetadataWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/MetadataDescriptor;)V", "public")]
	public MetadataWriter(Dova.JDK.jdk.jfr.@internal.MetadataDescriptor arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jfr/internal/MetadataWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/io/DataOutput;Ljdk/jfr/internal/MetadataDescriptor$Element;Ljava/util/HashMap;)V", "private")]
	public void write(Dova.JDK.java.io.DataOutput arg0, Dova.JDK.jdk.jfr.@internal.MetadataDescriptor.Element arg1, Dova.JDK.java.util.HashMap arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/io/DataOutput;I)V", "private")]
	public void writeInt(Dova.JDK.java.io.DataOutput arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/io/DataOutput;Ljava/lang/String;)V", "private")]
	public void writeString(Dova.JDK.java.io.DataOutput arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/io/DataOutput;)V", "public")]
	public void writeBinary(Dova.JDK.java.io.DataOutput arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/MetadataDescriptor$Element;Ljava/util/Set;)V", "private")]
	public void buildStringPool(Dova.JDK.jdk.jfr.@internal.MetadataDescriptor.Element arg0, Dova.JDK.java.util.Set arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/MetadataDescriptor$Element;Ljdk/jfr/SettingDescriptor;)V", "private")]
	public void makeSettingElement(Dova.JDK.jdk.jfr.@internal.MetadataDescriptor.Element arg0, Dova.JDK.jdk.jfr.SettingDescriptor arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/MetadataDescriptor$Element;Ljdk/jfr/ValueDescriptor;)V", "private")]
	public void makeFieldElement(Dova.JDK.jdk.jfr.@internal.MetadataDescriptor.Element arg0, Dova.JDK.jdk.jfr.ValueDescriptor arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/MetadataDescriptor$Element;Ljdk/jfr/AnnotationElement;)V", "private")]
	public void makeAnnotation(Dova.JDK.jdk.jfr.@internal.MetadataDescriptor.Element arg0, Dova.JDK.jdk.jfr.AnnotationElement arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/MetadataDescriptor$Element;Ljdk/jfr/internal/Type;)V", "private")]
	public void makeTypeElement(Dova.JDK.jdk.jfr.@internal.MetadataDescriptor.Element arg0, Dova.JDK.jdk.jfr.@internal.Type arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}
}
