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

namespace Dova.JDK.com.sun.org.apache.xml.@internal.security.signature.reference;

[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/security/signature/reference/ReferenceOctetStreamData;", "public")]
public partial class ReferenceOctetStreamData
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.org.apache.xml.@internal.security.signature.reference.ReferenceData
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ReferenceOctetStreamData()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/org/apache/xml/internal/security/signature/reference/ReferenceOctetStreamData;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "octetStream", "Ljava/io/InputStream;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "uri", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "mimeType", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ReferenceOctetStreamData", "(Ljava/io/InputStream;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ReferenceOctetStreamData", "(Ljava/io/InputStream;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getURI", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getMimeType", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getOctetStream", "()Ljava/io/InputStream;"));
	}

	[JniSignatureAttribute("Ljava/io/InputStream;", "private")]
	public Dova.JDK.java.io.InputStream octetStream_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String uri_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String mimeType_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ReferenceOctetStreamData(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)V", "public")]
	public ReferenceOctetStreamData(Dova.JDK.java.io.InputStream arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public ReferenceOctetStreamData(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xml/internal/security/signature/reference/ReferenceOctetStreamData;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getURI()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getMimeType()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/InputStream;", "public")]
	public Dova.JDK.java.io.InputStream getOctetStream()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}
}
