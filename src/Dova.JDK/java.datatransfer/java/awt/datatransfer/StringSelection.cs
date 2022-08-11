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

namespace Dova.JDK.java.awt.datatransfer;

[JniSignatureAttribute("Ljava/awt/datatransfer/StringSelection;", "public")]
public partial class StringSelection
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.awt.datatransfer.Transferable
	, Dova.JDK.java.awt.datatransfer.ClipboardOwner
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StringSelection()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/datatransfer/StringSelection;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STRING", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PLAIN_TEXT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "flavors", "[Ljava/awt/datatransfer/DataFlavor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "data", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransferDataFlavors", "()[Ljava/awt/datatransfer/DataFlavor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDataFlavorSupported", "(Ljava/awt/datatransfer/DataFlavor;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransferData", "(Ljava/awt/datatransfer/DataFlavor;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lostOwnership", "(Ljava/awt/datatransfer/Clipboard;Ljava/awt/datatransfer/Transferable;)V"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int STRING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int PLAIN_TEXT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("[Ljava/awt/datatransfer/DataFlavor;", "private static final")]
	public static JavaArray<Dova.JDK.java.awt.datatransfer.DataFlavor> flavors_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.datatransfer.DataFlavor>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String data_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public StringSelection(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public StringSelection(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/datatransfer/StringSelection;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Ljava/awt/datatransfer/DataFlavor;", "public")]
	public JavaArray<Dova.JDK.java.awt.datatransfer.DataFlavor> getTransferDataFlavors()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.datatransfer.DataFlavor>>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/datatransfer/DataFlavor;)Z", "public")]
	public bool isDataFlavorSupported(Dova.JDK.java.awt.datatransfer.DataFlavor arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/datatransfer/DataFlavor;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getTransferData(Dova.JDK.java.awt.datatransfer.DataFlavor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/datatransfer/Clipboard;Ljava/awt/datatransfer/Transferable;)V", "public")]
	public void lostOwnership(Dova.JDK.java.awt.datatransfer.Clipboard arg0, Dova.JDK.java.awt.datatransfer.Transferable arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}
}
