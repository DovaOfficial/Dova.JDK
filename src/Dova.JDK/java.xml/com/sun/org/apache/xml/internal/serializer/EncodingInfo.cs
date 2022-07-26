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

namespace Dova.JDK.com.sun.org.apache.xml.@internal.serializer;

[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/serializer/EncodingInfo;", "public final")]
public partial class EncodingInfo
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static EncodingInfo()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xml/internal/serializer/EncodingInfo;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "javaName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_encoding", "Lcom/sun/org/apache/xml/internal/serializer/EncodingInfo$InEncoding;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInEncoding", "(C)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInEncoding", "(CC)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "inEncoding", "(C[B)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "inEncoding", "(CLjava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "inEncoding", "(CCLjava/lang/String;)Z"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String name_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String javaName_Property
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

	[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/serializer/EncodingInfo$InEncoding;", "private")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.serializer.EncodingInfo.InEncoding m_encoding_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.serializer.EncodingInfo.InEncoding>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public EncodingInfo(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public EncodingInfo(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xml/internal/serializer/EncodingInfo;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(C)Z", "public")]
	public bool isInEncoding(char arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(CC)Z", "public")]
	public bool isInEncoding(char arg0, char arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(C[B)Z", "private static")]
	public static bool inEncoding(char arg0, JavaArray<byte> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(CLjava/lang/String;)Z", "private static")]
	public static bool inEncoding(char arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(CCLjava/lang/String;)Z", "private static")]
	public static bool inEncoding(char arg0, char arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/serializer/EncodingInfo$InEncoding;", "private abstract static interface")]
	public partial interface InEncoding
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InEncoding()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xml/internal/serializer/EncodingInfo$InEncoding;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInEncoding", "(C)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInEncoding", "(CC)Z"));
		}

		[JniSignatureAttribute("(C)Z", "public abstract")]
		bool isInEncoding(char arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(CC)Z", "public abstract")]
		bool isInEncoding(char arg0, char arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/serializer/EncodingInfo$EncodingImpl;", "private")]
	public partial class EncodingImpl
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.org.apache.xml.@internal.serializer.EncodingInfo.InEncoding
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EncodingImpl()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xml/internal/serializer/EncodingInfo$EncodingImpl;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_encoding", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_first", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_explFirst", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_explLast", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_last", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_before", "Lcom/sun/org/apache/xml/internal/serializer/EncodingInfo$InEncoding;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_after", "Lcom/sun/org/apache/xml/internal/serializer/EncodingInfo$InEncoding;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RANGE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_alreadyKnown", "[Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_isInEncoding", "[Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/org/apache/xml/internal/serializer/EncodingInfo;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xml/internal/serializer/EncodingInfo;Ljava/lang/String;III)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xml/internal/serializer/EncodingInfo;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInEncoding", "(CC)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInEncoding", "(C)Z"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String m_encoding_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int m_first_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int m_explFirst_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int m_explLast_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int m_last_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/serializer/EncodingInfo$InEncoding;", "private")]
		public Dova.JDK.com.sun.org.apache.xml.@internal.serializer.EncodingInfo.InEncoding m_before_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.serializer.EncodingInfo.InEncoding>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/serializer/EncodingInfo$InEncoding;", "private")]
		public Dova.JDK.com.sun.org.apache.xml.@internal.serializer.EncodingInfo.InEncoding m_after_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.serializer.EncodingInfo.InEncoding>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int RANGE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
			}
		}

		[JniSignatureAttribute("[Z", "private final")]
		public JavaArray<bool> m_alreadyKnown_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<JavaArray<bool>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Z", "private final")]
		public JavaArray<bool> m_isInEncoding_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<JavaArray<bool>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/serializer/EncodingInfo;", "final")]
		public Dova.JDK.com.sun.org.apache.xml.@internal.serializer.EncodingInfo this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.serializer.EncodingInfo>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EncodingImpl(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/serializer/EncodingInfo;Ljava/lang/String;III)V", "private")]
		public EncodingImpl(Dova.JDK.com.sun.org.apache.xml.@internal.serializer.EncodingInfo arg0, Dova.JDK.java.lang.String arg1, int arg2, int arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/serializer/EncodingInfo;)V", "private")]
		public EncodingImpl(Dova.JDK.com.sun.org.apache.xml.@internal.serializer.EncodingInfo arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xml/internal/serializer/EncodingInfo$EncodingImpl;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(CC)Z", "public")]
		public bool isInEncoding(char arg0, char arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(C)Z", "public")]
		public bool isInEncoding(char arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}
}
