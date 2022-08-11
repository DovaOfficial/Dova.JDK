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

namespace Dova.JDK.sun.awt.datatransfer;

[JniSignatureAttribute("Lsun/awt/datatransfer/ClipboardTransferable;", "public")]
public partial class ClipboardTransferable
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.awt.datatransfer.Transferable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ClipboardTransferable()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/datatransfer/ClipboardTransferable;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flavorsToData", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flavors", "[Ljava/awt/datatransfer/DataFlavor;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/awt/datatransfer/SunClipboard;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fetchOneFlavor", "(Lsun/awt/datatransfer/SunClipboard;Ljava/awt/datatransfer/DataFlavor;JLjava/util/Map;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransferDataFlavors", "()[Ljava/awt/datatransfer/DataFlavor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDataFlavorSupported", "(Ljava/awt/datatransfer/DataFlavor;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransferData", "(Ljava/awt/datatransfer/DataFlavor;)Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map flavorsToData_Property
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

	[JniSignatureAttribute("[Ljava/awt/datatransfer/DataFlavor;", "private")]
	public JavaArray<Dova.JDK.java.awt.datatransfer.DataFlavor> flavors_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.datatransfer.DataFlavor>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ClipboardTransferable(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/awt/datatransfer/SunClipboard;)V", "public")]
	public ClipboardTransferable(Dova.JDK.sun.awt.datatransfer.SunClipboard arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/datatransfer/ClipboardTransferable;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/awt/datatransfer/SunClipboard;Ljava/awt/datatransfer/DataFlavor;JLjava/util/Map;)Z", "private")]
	public bool fetchOneFlavor(Dova.JDK.sun.awt.datatransfer.SunClipboard arg0, Dova.JDK.java.awt.datatransfer.DataFlavor arg1, long arg2, Dova.JDK.java.util.Map arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("()[Ljava/awt/datatransfer/DataFlavor;", "public")]
	public JavaArray<Dova.JDK.java.awt.datatransfer.DataFlavor> getTransferDataFlavors()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.datatransfer.DataFlavor>>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/datatransfer/DataFlavor;)Z", "public")]
	public bool isDataFlavorSupported(Dova.JDK.java.awt.datatransfer.DataFlavor arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/datatransfer/DataFlavor;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getTransferData(Dova.JDK.java.awt.datatransfer.DataFlavor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("Lsun/awt/datatransfer/ClipboardTransferable$DataFactory;", "private final")]
	public partial class DataFactory
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DataFactory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/datatransfer/ClipboardTransferable$DataFactory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "format", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "data", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/awt/datatransfer/ClipboardTransferable;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/awt/datatransfer/ClipboardTransferable;J[B)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransferData", "(Ljava/awt/datatransfer/DataFlavor;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("J", "final")]
		public long format_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("[B", "final")]
		public JavaArray<byte> data_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/awt/datatransfer/ClipboardTransferable;", "final")]
		public Dova.JDK.sun.awt.datatransfer.ClipboardTransferable this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.datatransfer.ClipboardTransferable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DataFactory(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/awt/datatransfer/ClipboardTransferable;J[B)V", "")]
		public DataFactory(Dova.JDK.sun.awt.datatransfer.ClipboardTransferable arg0, long arg1, JavaArray<byte> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/datatransfer/ClipboardTransferable$DataFactory;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/datatransfer/DataFlavor;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object getTransferData(Dova.JDK.java.awt.datatransfer.DataFlavor arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}
}
