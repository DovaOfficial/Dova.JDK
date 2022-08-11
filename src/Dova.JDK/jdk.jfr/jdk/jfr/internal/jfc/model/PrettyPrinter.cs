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

namespace Dova.JDK.jdk.jfr.@internal.jfc.model;

[JniSignatureAttribute("Ljdk/jfr/internal/jfc/model/PrettyPrinter;", "final")]
public partial class PrettyPrinter
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PrettyPrinter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/jfc/model/PrettyPrinter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "out", "Ljava/io/PrintWriter;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/PrintWriter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "print", "(Ljdk/jfr/internal/jfc/model/XmlConfiguration;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printHeader", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prettyPrint", "(Ljava/lang/String;Ljdk/jfr/internal/jfc/model/XmlElement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printComment", "(Ljava/lang/String;Ljdk/jfr/internal/jfc/model/XmlElement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printAttributes", "(Ljava/util/Map;)V"));
	}

	[JniSignatureAttribute("Ljava/io/PrintWriter;", "private final")]
	public Dova.JDK.java.io.PrintWriter @out_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PrettyPrinter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/io/PrintWriter;)V", "")]
	public PrettyPrinter(Dova.JDK.java.io.PrintWriter arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jfr/internal/jfc/model/PrettyPrinter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/jfr/internal/jfc/model/XmlConfiguration;)V", "")]
	public void print(Dova.JDK.jdk.jfr.@internal.jfc.model.XmlConfiguration arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void printHeader()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljdk/jfr/internal/jfc/model/XmlElement;)V", "private")]
	public void prettyPrint(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.jfr.@internal.jfc.model.XmlElement arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljdk/jfr/internal/jfc/model/XmlElement;)V", "private")]
	public void printComment(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.jfr.@internal.jfc.model.XmlElement arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)V", "private")]
	public void printAttributes(Dova.JDK.java.util.Map arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}
}
