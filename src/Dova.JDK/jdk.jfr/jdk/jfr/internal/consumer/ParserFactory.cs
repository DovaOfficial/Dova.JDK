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

namespace Dova.JDK.jdk.jfr.@internal.consumer;

[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ParserFactory;", "final")]
public partial class ParserFactory
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ParserFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/consumer/ParserFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "parsers", "Ljdk/jfr/internal/LongMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "timeConverter", "Ljdk/jfr/internal/consumer/TimeConverter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "types", "Ljdk/jfr/internal/LongMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "constantLookups", "Ljdk/jfr/internal/LongMap;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ParserFactory", "(Ljdk/jfr/internal/MetadataDescriptor;Ljdk/jfr/internal/LongMap;Ljdk/jfr/internal/consumer/TimeConverter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getParsers", "()Ljdk/jfr/internal/LongMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getTypeMap", "()Ljdk/jfr/internal/LongMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createCompositeParser", "(Ljdk/jfr/internal/Type;Z)Ljdk/jfr/internal/consumer/ParserFactory$CompositeParser;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createEventParser", "(Ljdk/jfr/EventType;)Ljdk/jfr/internal/consumer/EventParser;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createParser", "(Ljdk/jfr/ValueDescriptor;Z)Ljdk/jfr/internal/consumer/Parser;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createPrimitiveParser", "(Ljdk/jfr/internal/Type;Z)Ljdk/jfr/internal/consumer/Parser;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "registerParserType", "(Ljdk/jfr/internal/Type;Ljdk/jfr/internal/consumer/Parser;)Ljdk/jfr/internal/consumer/Parser;"));
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/LongMap;", "private final")]
	public Dova.JDK.jdk.jfr.@internal.LongMap parsers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.LongMap>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/TimeConverter;", "private final")]
	public Dova.JDK.jdk.jfr.@internal.consumer.TimeConverter timeConverter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.TimeConverter>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/LongMap;", "private final")]
	public Dova.JDK.jdk.jfr.@internal.LongMap types_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.LongMap>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/LongMap;", "private final")]
	public Dova.JDK.jdk.jfr.@internal.LongMap constantLookups_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.LongMap>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ParserFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/MetadataDescriptor;Ljdk/jfr/internal/LongMap;Ljdk/jfr/internal/consumer/TimeConverter;)V", "public")]
	public ParserFactory(Dova.JDK.jdk.jfr.@internal.MetadataDescriptor arg0, Dova.JDK.jdk.jfr.@internal.LongMap arg1, Dova.JDK.jdk.jfr.@internal.consumer.TimeConverter arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jfr/internal/consumer/ParserFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljdk/jfr/internal/LongMap;", "public")]
	public Dova.JDK.jdk.jfr.@internal.LongMap getParsers()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.LongMap>(ret);
	}

	[JniSignatureAttribute("()Ljdk/jfr/internal/LongMap;", "public")]
	public Dova.JDK.jdk.jfr.@internal.LongMap getTypeMap()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.LongMap>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/Type;Z)Ljdk/jfr/internal/consumer/ParserFactory$CompositeParser;", "private")]
	public Dova.JDK.jdk.jfr.@internal.consumer.ParserFactory.CompositeParser createCompositeParser(Dova.JDK.jdk.jfr.@internal.Type arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.ParserFactory.CompositeParser>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/EventType;)Ljdk/jfr/internal/consumer/EventParser;", "private")]
	public Dova.JDK.jdk.jfr.@internal.consumer.EventParser createEventParser(Dova.JDK.jdk.jfr.EventType arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.EventParser>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/ValueDescriptor;Z)Ljdk/jfr/internal/consumer/Parser;", "private")]
	public Dova.JDK.jdk.jfr.@internal.consumer.Parser createParser(Dova.JDK.jdk.jfr.ValueDescriptor arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.Parser>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/Type;Z)Ljdk/jfr/internal/consumer/Parser;", "private")]
	public Dova.JDK.jdk.jfr.@internal.consumer.Parser createPrimitiveParser(Dova.JDK.jdk.jfr.@internal.Type arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.Parser>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/Type;Ljdk/jfr/internal/consumer/Parser;)Ljdk/jfr/internal/consumer/Parser;", "private")]
	public Dova.JDK.jdk.jfr.@internal.consumer.Parser registerParserType(Dova.JDK.jdk.jfr.@internal.Type arg0, Dova.JDK.jdk.jfr.@internal.consumer.Parser arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.Parser>(ret);
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ParserFactory$CompositeParser;", "private static final")]
	public partial class CompositeParser
		: Dova.JDK.jdk.jfr.@internal.consumer.Parser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CompositeParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/consumer/ParserFactory$CompositeParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "parsers", "[Ljdk/jfr/internal/consumer/Parser;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CompositeParser", "([Ljdk/jfr/internal/consumer/Parser;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "skip", "(Ljdk/jfr/internal/consumer/RecordingInput;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parse", "(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("[Ljdk/jfr/internal/consumer/Parser;", "private final")]
		public JavaArray<Dova.JDK.jdk.jfr.@internal.consumer.Parser> parsers_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.jfr.@internal.consumer.Parser>>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CompositeParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([Ljdk/jfr/internal/consumer/Parser;)V", "public")]
		public CompositeParser(JavaArray<Dova.JDK.jdk.jfr.@internal.consumer.Parser> arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jfr/internal/consumer/ParserFactory$CompositeParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)V", "public")]
		public void skip(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object parse(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ParserFactory$ArrayParser;", "private static final")]
	public partial class ArrayParser
		: Dova.JDK.jdk.jfr.@internal.consumer.Parser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ArrayParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/consumer/ParserFactory$ArrayParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "elementParser", "Ljdk/jfr/internal/consumer/Parser;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ArrayParser", "(Ljdk/jfr/internal/consumer/Parser;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "skip", "(Ljdk/jfr/internal/consumer/RecordingInput;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parse", "(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Ljdk/jfr/internal/consumer/Parser;", "private final")]
		public Dova.JDK.jdk.jfr.@internal.consumer.Parser elementParser_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.Parser>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ArrayParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/Parser;)V", "public")]
		public ArrayParser(Dova.JDK.jdk.jfr.@internal.consumer.Parser arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jfr/internal/consumer/ParserFactory$ArrayParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)V", "public")]
		public void skip(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object parse(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ParserFactory$EventValueConstantParser;", "private static final")]
	public partial class EventValueConstantParser
		: Dova.JDK.jdk.jfr.@internal.consumer.Parser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EventValueConstantParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/consumer/ParserFactory$EventValueConstantParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "lookup", "Ljdk/jfr/internal/consumer/ConstantLookup;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "lastValue", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "lastKey", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "EventValueConstantParser", "(Ljdk/jfr/internal/consumer/ConstantLookup;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "skip", "(Ljdk/jfr/internal/consumer/RecordingInput;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parse", "(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ConstantLookup;", "private final")]
		public Dova.JDK.jdk.jfr.@internal.consumer.ConstantLookup lookup_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.ConstantLookup>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "private")]
		public Dova.JDK.java.lang.Object lastValue_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("J", "private")]
		public long lastKey_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EventValueConstantParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/ConstantLookup;)V", "")]
		public EventValueConstantParser(Dova.JDK.jdk.jfr.@internal.consumer.ConstantLookup arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jfr/internal/consumer/ParserFactory$EventValueConstantParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)V", "public")]
		public void skip(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object parse(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ParserFactory$ConstantValueParser;", "private static final")]
	public partial class ConstantValueParser
		: Dova.JDK.jdk.jfr.@internal.consumer.Parser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ConstantValueParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/consumer/ParserFactory$ConstantValueParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "lookup", "Ljdk/jfr/internal/consumer/ConstantLookup;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ConstantValueParser", "(Ljdk/jfr/internal/consumer/ConstantLookup;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "skip", "(Ljdk/jfr/internal/consumer/RecordingInput;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parse", "(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ConstantLookup;", "private final")]
		public Dova.JDK.jdk.jfr.@internal.consumer.ConstantLookup lookup_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.ConstantLookup>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ConstantValueParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/ConstantLookup;)V", "")]
		public ConstantValueParser(Dova.JDK.jdk.jfr.@internal.consumer.ConstantLookup arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jfr/internal/consumer/ParserFactory$ConstantValueParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)V", "public")]
		public void skip(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object parse(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ParserFactory$IntegerParser;", "private static final")]
	public partial class IntegerParser
		: Dova.JDK.jdk.jfr.@internal.consumer.Parser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IntegerParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/consumer/ParserFactory$IntegerParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "lastIntegergObject", "Ljava/lang/Integer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "last", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "IntegerParser", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "skip", "(Ljdk/jfr/internal/consumer/RecordingInput;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parse", "(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Ljava/lang/Integer;", "private")]
		public Dova.JDK.java.lang.Integer lastIntegergObject_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "private")]
		public int last_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public IntegerParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public IntegerParser() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jfr/internal/consumer/ParserFactory$IntegerParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)V", "public")]
		public void skip(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object parse(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ParserFactory$LongParser;", "private static final")]
	public partial class LongParser
		: Dova.JDK.jdk.jfr.@internal.consumer.Parser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LongParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/consumer/ParserFactory$LongParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "lastLongObject", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "last", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "LongParser", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "skip", "(Ljdk/jfr/internal/consumer/RecordingInput;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parse", "(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "private")]
		public Dova.JDK.java.lang.Object lastLongObject_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("J", "private")]
		public long last_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LongParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public LongParser() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jfr/internal/consumer/ParserFactory$LongParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)V", "public")]
		public void skip(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object parse(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ParserFactory$FloatParser;", "private static final")]
	public partial class FloatParser
		: Dova.JDK.jdk.jfr.@internal.consumer.Parser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FloatParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/consumer/ParserFactory$FloatParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "FloatParser", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "skip", "(Ljdk/jfr/internal/consumer/RecordingInput;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parse", "(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FloatParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public FloatParser() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jfr/internal/consumer/ParserFactory$FloatParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)V", "public")]
		public void skip(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object parse(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ParserFactory$DoubleParser;", "private static final")]
	public partial class DoubleParser
		: Dova.JDK.jdk.jfr.@internal.consumer.Parser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DoubleParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/consumer/ParserFactory$DoubleParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DoubleParser", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "skip", "(Ljdk/jfr/internal/consumer/RecordingInput;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parse", "(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DoubleParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public DoubleParser() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jfr/internal/consumer/ParserFactory$DoubleParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)V", "public")]
		public void skip(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object parse(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ParserFactory$CharacterParser;", "private static final")]
	public partial class CharacterParser
		: Dova.JDK.jdk.jfr.@internal.consumer.Parser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CharacterParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/consumer/ParserFactory$CharacterParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CharacterParser", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "skip", "(Ljdk/jfr/internal/consumer/RecordingInput;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parse", "(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CharacterParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public CharacterParser() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jfr/internal/consumer/ParserFactory$CharacterParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)V", "public")]
		public void skip(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object parse(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ParserFactory$BooleanParser;", "private static final")]
	public partial class BooleanParser
		: Dova.JDK.jdk.jfr.@internal.consumer.Parser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BooleanParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/consumer/ParserFactory$BooleanParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BooleanParser", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "skip", "(Ljdk/jfr/internal/consumer/RecordingInput;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parse", "(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BooleanParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public BooleanParser() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jfr/internal/consumer/ParserFactory$BooleanParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)V", "public")]
		public void skip(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object parse(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ParserFactory$ShortParser;", "private static final")]
	public partial class ShortParser
		: Dova.JDK.jdk.jfr.@internal.consumer.Parser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ShortParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/consumer/ParserFactory$ShortParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ShortParser", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "skip", "(Ljdk/jfr/internal/consumer/RecordingInput;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parse", "(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ShortParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public ShortParser() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jfr/internal/consumer/ParserFactory$ShortParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)V", "public")]
		public void skip(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object parse(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ParserFactory$ByteParser;", "private static final")]
	public partial class ByteParser
		: Dova.JDK.jdk.jfr.@internal.consumer.Parser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ByteParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/consumer/ParserFactory$ByteParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ByteParser", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "skip", "(Ljdk/jfr/internal/consumer/RecordingInput;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parse", "(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ByteParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public ByteParser() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jfr/internal/consumer/ParserFactory$ByteParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)V", "public")]
		public void skip(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/RecordingInput;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object parse(Dova.JDK.jdk.jfr.@internal.consumer.RecordingInput arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}
}
