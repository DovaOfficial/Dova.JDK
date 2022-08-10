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

namespace Dova.JDK.javax.print;

[JniSignatureAttribute("Ljavax/print/PrintServiceLookup;", "public abstract")]
public partial class PrintServiceLookup
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PrintServiceLookup()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/print/PrintServiceLookup;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PrintServiceLookup", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getServices", "(Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)Ljava/util/ArrayList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getServicesForContext", "()Ljavax/print/PrintServiceLookup$Services;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getMultiDocServices", "([Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)Ljava/util/ArrayList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAllLookupServices", "()Ljava/util/ArrayList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDefaultPrintService", "()Ljavax/print/PrintService;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getListOfLookupServices", "()Ljava/util/ArrayList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getRegisteredServices", "()Ljava/util/ArrayList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "initRegisteredServices", "()Ljava/util/ArrayList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "initListOfLookupServices", "()Ljava/util/ArrayList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPrintServices", "(Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)[Ljavax/print/PrintService;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPrintServices", "()[Ljavax/print/PrintService;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMultiDocPrintServices", "([Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)[Ljavax/print/MultiDocPrintService;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "lookupPrintServices", "(Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)[Ljavax/print/PrintService;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "lookupMultiDocPrintServices", "([Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)[Ljavax/print/MultiDocPrintService;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "lookupDefaultPrintService", "()Ljavax/print/PrintService;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "registerServiceProvider", "(Ljavax/print/PrintServiceLookup;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "registerService", "(Ljavax/print/PrintService;)Z"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PrintServiceLookup(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public PrintServiceLookup() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/print/PrintServiceLookup;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)Ljava/util/ArrayList;", "private static")]
	public static Dova.JDK.java.util.ArrayList getServices(Dova.JDK.javax.print.DocFlavor arg0, Dova.JDK.javax.print.attribute.AttributeSet arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
	}

	[JniSignatureAttribute("()Ljavax/print/PrintServiceLookup$Services;", "private static")]
	public static Dova.JDK.javax.print.PrintServiceLookup.Services getServicesForContext()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.print.PrintServiceLookup.Services>(ret);
	}

	[JniSignatureAttribute("([Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)Ljava/util/ArrayList;", "private static")]
	public static Dova.JDK.java.util.ArrayList getMultiDocServices(JavaArray<Dova.JDK.javax.print.DocFlavor> arg0, Dova.JDK.javax.print.attribute.AttributeSet arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/ArrayList;", "private static")]
	public static Dova.JDK.java.util.ArrayList getAllLookupServices()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
	}

	[JniSignatureAttribute("()Ljavax/print/PrintService;", "public abstract")]
	public Dova.JDK.javax.print.PrintService getDefaultPrintService()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.print.PrintService>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/ArrayList;", "private static")]
	public static Dova.JDK.java.util.ArrayList getListOfLookupServices()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/ArrayList;", "private static")]
	public static Dova.JDK.java.util.ArrayList getRegisteredServices()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/ArrayList;", "private static")]
	public static Dova.JDK.java.util.ArrayList initRegisteredServices()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/ArrayList;", "private static")]
	public static Dova.JDK.java.util.ArrayList initListOfLookupServices()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
	}

	[JniSignatureAttribute("(Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)[Ljavax/print/PrintService;", "public abstract")]
	public JavaArray<Dova.JDK.javax.print.PrintService> getPrintServices(Dova.JDK.javax.print.DocFlavor arg0, Dova.JDK.javax.print.attribute.AttributeSet arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.print.PrintService>>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/print/PrintService;", "public abstract")]
	public JavaArray<Dova.JDK.javax.print.PrintService> getPrintServices()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.print.PrintService>>(ret);
	}

	[JniSignatureAttribute("([Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)[Ljavax/print/MultiDocPrintService;", "public abstract")]
	public JavaArray<Dova.JDK.javax.print.MultiDocPrintService> getMultiDocPrintServices(JavaArray<Dova.JDK.javax.print.DocFlavor> arg0, Dova.JDK.javax.print.attribute.AttributeSet arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.print.MultiDocPrintService>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)[Ljavax/print/PrintService;", "public static final")]
	public static JavaArray<Dova.JDK.javax.print.PrintService> lookupPrintServices(Dova.JDK.javax.print.DocFlavor arg0, Dova.JDK.javax.print.attribute.AttributeSet arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.print.PrintService>>(ret);
	}

	[JniSignatureAttribute("([Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)[Ljavax/print/MultiDocPrintService;", "public static final")]
	public static JavaArray<Dova.JDK.javax.print.MultiDocPrintService> lookupMultiDocPrintServices(JavaArray<Dova.JDK.javax.print.DocFlavor> arg0, Dova.JDK.javax.print.attribute.AttributeSet arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.print.MultiDocPrintService>>(ret);
	}

	[JniSignatureAttribute("()Ljavax/print/PrintService;", "public static final")]
	public static Dova.JDK.javax.print.PrintService lookupDefaultPrintService()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.print.PrintService>(ret);
	}

	[JniSignatureAttribute("(Ljavax/print/PrintServiceLookup;)Z", "public static")]
	public static bool registerServiceProvider(Dova.JDK.javax.print.PrintServiceLookup arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/print/PrintService;)Z", "public static")]
	public static bool registerService(Dova.JDK.javax.print.PrintService arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("Ljavax/print/PrintServiceLookup$Services;", "static")]
	public partial class Services
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Services()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/print/PrintServiceLookup$Services;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "listOfLookupServices", "Ljava/util/ArrayList;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "registeredServices", "Ljava/util/ArrayList;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Services", "()V"));
		}

		[JniSignatureAttribute("Ljava/util/ArrayList;", "private")]
		public Dova.JDK.java.util.ArrayList listOfLookupServices_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/ArrayList;", "private")]
		public Dova.JDK.java.util.ArrayList registeredServices_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Services(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public Services() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/print/PrintServiceLookup$Services;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
