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

[JniSignatureAttribute("Ljdk/jfr/internal/jfc/model/Parser;", "final")]
public partial class Parser
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Parser()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/jfc/model/Parser;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parse", "(Ljava/nio/file/Path;)Ljdk/jfr/internal/jfc/model/XmlConfiguration;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Parser(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public Parser() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jfr/internal/jfc/model/Parser;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljdk/jfr/internal/jfc/model/XmlConfiguration;", "static")]
	public static Dova.JDK.jdk.jfr.@internal.jfc.model.XmlConfiguration parse(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.jfc.model.XmlConfiguration>(ret);
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/jfc/model/Parser$ConfigurationHandler;", "private static final")]
	public partial class ConfigurationHandler
		: Dova.JDK.jdk.@internal.org.xml.sax.helpers.DefaultHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ConfigurationHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/jfc/model/Parser$ConfigurationHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stack", "Ljava/util/Deque;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "buffer", "Ljava/lang/StringBuilder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "configuration", "Ljdk/jfr/internal/jfc/model/XmlConfiguration;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addAttributes", "(Ljdk/jfr/internal/jfc/model/XmlElement;Ljdk/internal/org/xml/sax/Attributes;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljdk/internal/org/xml/sax/Attributes;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "characters", "([CII)V"));
		}

		[JniSignatureAttribute("Ljava/util/Deque;", "private final")]
		public Dova.JDK.java.util.Deque stack_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Deque>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/StringBuilder;", "private final")]
		public Dova.JDK.java.lang.StringBuilder buffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jfr/internal/jfc/model/XmlConfiguration;", "private")]
		public Dova.JDK.jdk.jfr.@internal.jfc.model.XmlConfiguration configuration_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.jfc.model.XmlConfiguration>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ConfigurationHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public ConfigurationHandler() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jfr/internal/jfc/model/Parser$ConfigurationHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/jfr/internal/jfc/model/XmlElement;Ljdk/internal/org/xml/sax/Attributes;)V", "private")]
		public void addAttributes(Dova.JDK.jdk.jfr.@internal.jfc.model.XmlElement arg0, Dova.JDK.jdk.@internal.org.xml.sax.Attributes arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljdk/internal/org/xml/sax/Attributes;)V", "public")]
		public void startElement(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.jdk.@internal.org.xml.sax.Attributes arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
		public void endElement(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("([CII)V", "public")]
		public void characters(JavaArray<char> arg0, int arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		}
	}
}
