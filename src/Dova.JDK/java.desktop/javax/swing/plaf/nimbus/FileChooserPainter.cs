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

namespace Dova.JDK.javax.swing.plaf.nimbus;

[JniSignatureAttribute("Ljavax/swing/plaf/nimbus/FileChooserPainter;", "final")]
public partial class FileChooserPainter
	: Dova.JDK.javax.swing.plaf.nimbus.AbstractRegionPainter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FileChooserPainter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/nimbus/FileChooserPainter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BACKGROUND_ENABLED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FILEICON_ENABLED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECTORYICON_ENABLED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UPFOLDERICON_ENABLED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NEWFOLDERICON_ENABLED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMPUTERICON_ENABLED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HARDDRIVEICON_ENABLED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOPPYDRIVEICON_ENABLED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HOMEFOLDERICON_ENABLED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DETAILSVIEWICON_ENABLED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LISTVIEWICON_ENABLED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "state", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ctx", "Ljavax/swing/plaf/nimbus/AbstractRegionPainter$PaintContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "path", "Ljava/awt/geom/Path2D;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rect", "Ljava/awt/geom/Rectangle2D;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "roundRect", "Ljava/awt/geom/RoundRectangle2D;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ellipse", "Ljava/awt/geom/Ellipse2D;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color1", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color2", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color3", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color4", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color5", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color6", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color7", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color8", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color9", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color10", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color11", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color12", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color13", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color14", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color15", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color16", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color17", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color18", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color19", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color20", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color21", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color22", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color23", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color24", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color25", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color26", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color27", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color28", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color29", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color30", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color31", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color32", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color33", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color34", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color35", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color36", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color37", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color38", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color39", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color40", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color41", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color42", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color43", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color44", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color45", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color46", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color47", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color48", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color49", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color50", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color51", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color52", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color53", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color54", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color55", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color56", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color57", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color58", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color59", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color60", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color61", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color62", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color63", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color64", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color65", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color66", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color67", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color68", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color69", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color70", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color71", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color72", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color73", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color74", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color75", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color76", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color77", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color78", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color79", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color80", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color81", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color82", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color83", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color84", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color85", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color86", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color87", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color88", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color89", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color90", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color91", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color92", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color93", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color94", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color95", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color96", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color97", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color98", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color99", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color100", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color101", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color102", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color103", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color104", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color105", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color106", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color107", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color108", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color109", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color110", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color111", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color112", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color113", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color114", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color115", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color116", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color117", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color118", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color119", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color120", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color121", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color122", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "componentColors", "[Ljava/lang/Object;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/nimbus/AbstractRegionPainter$PaintContext;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPaintContext", "()Ljavax/swing/plaf/nimbus/AbstractRegionPainter$PaintContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doPaint", "(Ljava/awt/Graphics2D;Ljavax/swing/JComponent;II[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath1", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect1", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath2", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient1", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath3", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath4", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient2", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient3", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient4", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient5", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient6", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient7", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient8", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath5", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient9", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath6", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath7", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath8", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient10", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient11", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient12", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient13", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient14", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient15", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient16", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintBackgroundEnabled", "(Ljava/awt/Graphics2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect2", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect3", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect4", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect5", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath9", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintfileIconEnabled", "(Ljava/awt/Graphics2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintdirectoryIconEnabled", "(Ljava/awt/Graphics2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintupFolderIconEnabled", "(Ljava/awt/Graphics2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintnewFolderIconEnabled", "(Ljava/awt/Graphics2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "painthardDriveIconEnabled", "(Ljava/awt/Graphics2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintfloppyDriveIconEnabled", "(Ljava/awt/Graphics2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "painthomeFolderIconEnabled", "(Ljava/awt/Graphics2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintdetailsViewIconEnabled", "(Ljava/awt/Graphics2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintlistViewIconEnabled", "(Ljava/awt/Graphics2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath10", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath11", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath12", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath13", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath14", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath15", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath16", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath17", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath18", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath19", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath20", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath21", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath22", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRadial1", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect6", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect7", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect8", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath23", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect9", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect10", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeEllipse1", "()Ljava/awt/geom/Ellipse2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath24", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeEllipse2", "()Ljava/awt/geom/Ellipse2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeEllipse3", "()Ljava/awt/geom/Ellipse2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeEllipse4", "()Ljava/awt/geom/Ellipse2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeEllipse5", "()Ljava/awt/geom/Ellipse2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeEllipse6", "()Ljava/awt/geom/Ellipse2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeEllipse7", "()Ljava/awt/geom/Ellipse2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect11", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect12", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect13", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath25", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath26", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient17", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath27", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient18", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath28", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient19", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath29", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect14", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect15", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect16", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect17", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect18", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath30", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath31", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect19", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient20", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect20", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath32", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient21", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect21", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient22", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath33", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient23", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath34", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath35", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient24", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath36", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient25", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect22", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient26", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect23", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient27", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect24", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect25", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect26", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeEllipse8", "()Ljava/awt/geom/Ellipse2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient28", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeEllipse9", "()Ljava/awt/geom/Ellipse2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRadial2", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath37", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient29", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodePath38", "()Ljava/awt/geom/Path2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient30", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect27", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect28", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect29", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect30", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect31", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect32", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient31", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect33", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect34", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient32", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect35", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect36", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect37", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect38", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient33", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect39", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect40", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient34", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect41", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient35", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect42", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect43", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect44", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect45", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect46", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect47", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect48", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect49", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect50", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect51", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRect52", "()Ljava/awt/geom/Rectangle2D;"));
	}

	[JniSignatureAttribute("I", "static final")]
	public static int BACKGROUND_ENABLED_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int FILEICON_ENABLED_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int DIRECTORYICON_ENABLED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int UPFOLDERICON_ENABLED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int NEWFOLDERICON_ENABLED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int COMPUTERICON_ENABLED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int HARDDRIVEICON_ENABLED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int FLOPPYDRIVEICON_ENABLED_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int HOMEFOLDERICON_ENABLED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int DETAILSVIEWICON_ENABLED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int LISTVIEWICON_ENABLED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int state_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/nimbus/AbstractRegionPainter$PaintContext;", "private")]
	public Dova.JDK.javax.swing.plaf.nimbus.AbstractRegionPainter.PaintContext ctx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.nimbus.AbstractRegionPainter.PaintContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D path_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D rect_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/geom/RoundRectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.RoundRectangle2D roundRect_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.RoundRectangle2D>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/geom/Ellipse2D;", "private")]
	public Dova.JDK.java.awt.geom.Ellipse2D ellipse_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Ellipse2D>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color4_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color5_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color6_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color7_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color8_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color9_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color10_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color11_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color12_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color13_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color14_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color15_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color16_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color17_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color18_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color19_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color20_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[36]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color21_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[37]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color22_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[38]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color23_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[39]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color24_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[40]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color25_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[41]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[41], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color26_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[42]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color27_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[43]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color28_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[44]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[44], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color29_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[45]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[45], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color30_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[46]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[46], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color31_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[47]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[47], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color32_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[48]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[48], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color33_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[49]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[49], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color34_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[50]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[50], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color35_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[51]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[51], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color36_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[52]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[52], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color37_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[53]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[53], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color38_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[54]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[54], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color39_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[55]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[55], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color40_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[56]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[56], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color41_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[57]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[57], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color42_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[58]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[58], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color43_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[59]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[59], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color44_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[60]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[60], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color45_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[61]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[61], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color46_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[62]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[62], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color47_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[63]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[63], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color48_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[64]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[64], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color49_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[65]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[65], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color50_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[66]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[66], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color51_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[67]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[67], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color52_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[68]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[68], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color53_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[69]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[69], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color54_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[70]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[70], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color55_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[71]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[71], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color56_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[72]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[72], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color57_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[73]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[73], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color58_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[74]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[74], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color59_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[75]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[75], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color60_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[76]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[76], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color61_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[77]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[77], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color62_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[78]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[78], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color63_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[79]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[79], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color64_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[80]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[80], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color65_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[81]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[81], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color66_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[82]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[82], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color67_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[83]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[83], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color68_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[84]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[84], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color69_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[85]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[85], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color70_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[86]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[86], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color71_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[87]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[87], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color72_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[88]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[88], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color73_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[89]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[89], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color74_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[90]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[90], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color75_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[91]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[91], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color76_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[92]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[92], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color77_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[93]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[93], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color78_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[94]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[94], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color79_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[95]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[95], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color80_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[96]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[96], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color81_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[97]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[97], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color82_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[98]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[98], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color83_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[99]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[99], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color84_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[100]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[100], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color85_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[101]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[101], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color86_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[102]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[102], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color87_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[103]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[103], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color88_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[104]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[104], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color89_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[105]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[105], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color90_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[106]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[106], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color91_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[107]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[107], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color92_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[108]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[108], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color93_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[109]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[109], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color94_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[110]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[110], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color95_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[111]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[111], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color96_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[112]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[112], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color97_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[113]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[113], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color98_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[114]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[114], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color99_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[115]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[115], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color100_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[116]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[116], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color101_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[117]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[117], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color102_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[118]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[118], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color103_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[119]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[119], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color104_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[120]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[120], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color105_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[121]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[121], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color106_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[122]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[122], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color107_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[123]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[123], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color108_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[124]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[124], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color109_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[125]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[125], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color110_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[126]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[126], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color111_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[127]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[127], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color112_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[128]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[128], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color113_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[129]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[129], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color114_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[130]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[130], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color115_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[131]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[131], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color116_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[132]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[132], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color117_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[133]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[133], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color118_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[134]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[134], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color119_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[135]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[135], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color120_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[136]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[136], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color121_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[137]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[137], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color122_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[138]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[138], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/Object;", "private")]
	public JavaArray<Dova.JDK.java.lang.Object> componentColors_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[139]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[139], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public FileChooserPainter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/nimbus/AbstractRegionPainter$PaintContext;I)V", "public")]
	public FileChooserPainter(Dova.JDK.javax.swing.plaf.nimbus.AbstractRegionPainter.PaintContext arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/nimbus/FileChooserPainter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljavax/swing/plaf/nimbus/AbstractRegionPainter$PaintContext;", "protected final")]
	public Dova.JDK.javax.swing.plaf.nimbus.AbstractRegionPainter.PaintContext getPaintContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.nimbus.AbstractRegionPainter.PaintContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics2D;Ljavax/swing/JComponent;II[Ljava/lang/Object;)V", "protected")]
	public void doPaint(Dova.JDK.java.awt.Graphics2D arg0, Dova.JDK.javax.swing.JComponent arg1, int arg2, int arg3, JavaArray<Dova.JDK.java.lang.Object> arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath2()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient1(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath3()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath4()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient2(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient3(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient4(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient5(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient6(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient7(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient8(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath5()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient9(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath6()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath7()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath8()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient10(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient11(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient12(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient13(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient14(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient15(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient16(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics2D;)V", "private")]
	public void paintBackgroundEnabled(Dova.JDK.java.awt.Graphics2D arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect2()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect3()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect4()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect5()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath9()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics2D;)V", "private")]
	public void paintfileIconEnabled(Dova.JDK.java.awt.Graphics2D arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics2D;)V", "private")]
	public void paintdirectoryIconEnabled(Dova.JDK.java.awt.Graphics2D arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics2D;)V", "private")]
	public void paintupFolderIconEnabled(Dova.JDK.java.awt.Graphics2D arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics2D;)V", "private")]
	public void paintnewFolderIconEnabled(Dova.JDK.java.awt.Graphics2D arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics2D;)V", "private")]
	public void painthardDriveIconEnabled(Dova.JDK.java.awt.Graphics2D arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics2D;)V", "private")]
	public void paintfloppyDriveIconEnabled(Dova.JDK.java.awt.Graphics2D arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics2D;)V", "private")]
	public void painthomeFolderIconEnabled(Dova.JDK.java.awt.Graphics2D arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics2D;)V", "private")]
	public void paintdetailsViewIconEnabled(Dova.JDK.java.awt.Graphics2D arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics2D;)V", "private")]
	public void paintlistViewIconEnabled(Dova.JDK.java.awt.Graphics2D arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath10()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath11()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath12()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath13()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath14()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath15()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath16()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath17()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath18()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath19()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath20()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath21()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath22()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeRadial1(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect6()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect7()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect8()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath23()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect9()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect10()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Ellipse2D;", "private")]
	public Dova.JDK.java.awt.geom.Ellipse2D decodeEllipse1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Ellipse2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath24()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Ellipse2D;", "private")]
	public Dova.JDK.java.awt.geom.Ellipse2D decodeEllipse2()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[64]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Ellipse2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Ellipse2D;", "private")]
	public Dova.JDK.java.awt.geom.Ellipse2D decodeEllipse3()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Ellipse2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Ellipse2D;", "private")]
	public Dova.JDK.java.awt.geom.Ellipse2D decodeEllipse4()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[66]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Ellipse2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Ellipse2D;", "private")]
	public Dova.JDK.java.awt.geom.Ellipse2D decodeEllipse5()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Ellipse2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Ellipse2D;", "private")]
	public Dova.JDK.java.awt.geom.Ellipse2D decodeEllipse6()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[68]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Ellipse2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Ellipse2D;", "private")]
	public Dova.JDK.java.awt.geom.Ellipse2D decodeEllipse7()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[69]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Ellipse2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect11()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[70]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect12()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[71]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect13()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[72]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath25()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[73]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath26()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[74]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient17(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[75], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath27()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[76]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient18(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[77], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath28()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[78]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient19(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[79], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath29()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[80]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect14()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[81]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect15()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[82]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect16()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[83]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect17()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[84]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect18()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[85]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath30()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[86]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath31()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[87]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect19()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[88]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient20(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[89], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect20()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[90]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath32()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[91]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient21(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[92], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect21()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[93]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient22(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[94], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath33()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[95]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient23(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[96], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath34()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[97]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath35()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[98]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient24(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[99], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath36()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[100]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient25(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[101], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect22()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[102]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient26(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[103], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect23()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[104]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient27(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[105], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect24()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[106]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect25()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[107]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect26()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[108]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Ellipse2D;", "private")]
	public Dova.JDK.java.awt.geom.Ellipse2D decodeEllipse8()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[109]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Ellipse2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient28(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[110], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Ellipse2D;", "private")]
	public Dova.JDK.java.awt.geom.Ellipse2D decodeEllipse9()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[111]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Ellipse2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeRadial2(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[112], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath37()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[113]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient29(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[114], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D decodePath38()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[115]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient30(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[116], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect27()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[117]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect28()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[118]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect29()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[119]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect30()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[120]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect31()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[121]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect32()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[122]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient31(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[123], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect33()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[124]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect34()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[125]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient32(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[126], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect35()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[127]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect36()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[128]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect37()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[129]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect38()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[130]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient33(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[131], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect39()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[132]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect40()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[133]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient34(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[134], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect41()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[135]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient35(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[136], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect42()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[137]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect43()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[138]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect44()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[139]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect45()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[140]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect46()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[141]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect47()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[142]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect48()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[143]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect49()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[144]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect50()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[145]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect51()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[146]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D decodeRect52()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[147]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}
}
