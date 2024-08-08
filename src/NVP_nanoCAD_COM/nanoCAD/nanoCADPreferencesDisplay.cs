using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Specifies display settings.
///</summary>
namespace nanoCAD.nanoCADPreferencesDisplay 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferencesDisplay_Constructor : INode 
	{
		public nanoCAD.InanoCADPreferencesDisplay _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADPreferencesDisplay;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferencesDisplay_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADPreferencesDisplay _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADPreferencesDisplay;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Returns the Application object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]

	///<summary>
	///Returns the Application object.
	///</summary>
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether margins display in layouts.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether margins display in layouts.
	///</summary>
	public class Set_LayoutDisplayMargins : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LayoutDisplayMargins = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether margins display in layouts.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]

	///<summary>
	///Specifies or returns whether margins display in layouts.
	///</summary>
	public class LayoutDisplayMargins : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LayoutDisplayMargins);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a paper background displays in layouts.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a paper background displays in layouts.
	///</summary>
	public class Set_LayoutDisplayPaper : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LayoutDisplayPaper = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a paper background displays in layouts.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]

	///<summary>
	///Specifies or returns whether a paper background displays in layouts.
	///</summary>
	public class LayoutDisplayPaper : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LayoutDisplayPaper);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a paper background shadow displays in layouts.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a paper background shadow displays in layouts.
	///</summary>
	public class Set_LayoutDisplayPaperShadow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LayoutDisplayPaperShadow = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a paper background shadow displays in layouts.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]

	///<summary>
	///Specifies or returns whether a paper background shadow displays in layouts.
	///</summary>
	public class LayoutDisplayPaperShadow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LayoutDisplayPaperShadow);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the application prompts for print settings whenever a new layout is created.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the application prompts for print settings whenever a new layout is created.
	///</summary>
	public class Set_LayoutShowPlotSetup : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LayoutShowPlotSetup = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the application prompts for print settings whenever a new layout is created.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]

	///<summary>
	///Specifies or returns whether the application prompts for print settings whenever a new layout is created.
	///</summary>
	public class LayoutShowPlotSetup : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LayoutShowPlotSetup);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a viewport is created automatically for each new layout.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a viewport is created automatically for each new layout.
	///</summary>
	public class Set_LayoutCreateViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LayoutCreateViewport = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a viewport is created automatically for each new layout.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]

	///<summary>
	///Specifies or returns whether a viewport is created automatically for each new layout.
	///</summary>
	public class LayoutCreateViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LayoutCreateViewport);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether scroll bars display in the drawing window.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether scroll bars display in the drawing window.
	///</summary>
	public class Set_DisplayScrollBars : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DisplayScrollBars = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether scroll bars display in the drawing window.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]

	///<summary>
	///Specifies or returns whether scroll bars display in the drawing window.
	///</summary>
	public class DisplayScrollBars : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DisplayScrollBars);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a screen menu displays in the drawing window.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a screen menu displays in the drawing window.
	///</summary>
	public class Set_DisplayScreenMenu : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DisplayScreenMenu = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a screen menu displays in the drawing window.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]

	///<summary>
	///Specifies or returns whether a screen menu displays in the drawing window.
	///</summary>
	public class DisplayScreenMenu : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DisplayScreenMenu);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the size of the crosshair cursor as a percentage of the total screen size.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
	[NodeInput("Path", typeof(System.Int32))]

	///<summary>
	///Specifies or returns the size of the crosshair cursor as a percentage of the total screen size.
	///</summary>
	public class Set_CursorSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CursorSize = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the size of the crosshair cursor as a percentage of the total screen size.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]

	///<summary>
	///Specifies or returns the size of the crosshair cursor as a percentage of the total screen size.
	///</summary>
	public class CursorSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CursorSize);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of text lines to display in the command window.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
	[NodeInput("Path", typeof(System.Int32))]

	///<summary>
	///Specifies or returns the number of text lines to display in the command window.
	///</summary>
	public class Set_DockedVisibleLines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DockedVisibleLines = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of text lines to display in the command window.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]

	///<summary>
	///Specifies or returns the number of text lines to display in the command window.
	///</summary>
	public class DockedVisibleLines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DockedVisibleLines);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether raster images display when using real-time zoom and pan.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether raster images display when using real-time zoom and pan.
	///</summary>
	public class Set_ShowRasterImage : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShowRasterImage = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether raster images display when using real-time zoom and pan.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]

	///<summary>
	///Specifies or returns whether raster images display when using real-time zoom and pan.
	///</summary>
	public class ShowRasterImage : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShowRasterImage);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the background color of the drawing window when in modelspace.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
	[NodeInput("color", typeof(System.Object))]

	///<summary>
	///Specifies or returns the background color of the drawing window when in modelspace.
	///</summary>
	public class Set_GraphicsWinModelBackgrndColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GraphicsWinModelBackgrndColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the background color of the drawing window when in modelspace.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]

	///<summary>
	///Specifies or returns the background color of the drawing window when in modelspace.
	///</summary>
	public class GraphicsWinModelBackgrndColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GraphicsWinModelBackgrndColor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of the crosshair cursor when in modelspace.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
	[NodeInput("crossHairColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of the crosshair cursor when in modelspace.
	///</summary>
	public class Set_ModelCrosshairColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ModelCrosshairColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of the crosshair cursor when in modelspace.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]

	///<summary>
	///Specifies or returns the color of the crosshair cursor when in modelspace.
	///</summary>
	public class ModelCrosshairColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ModelCrosshairColor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the background color when in paperspace.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
	[NodeInput("color", typeof(System.Object))]

	///<summary>
	///Specifies or returns the background color when in paperspace.
	///</summary>
	public class Set_GraphicsWinLayoutBackgrndColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GraphicsWinLayoutBackgrndColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the background color when in paperspace.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]

	///<summary>
	///Specifies or returns the background color when in paperspace.
	///</summary>
	public class GraphicsWinLayoutBackgrndColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GraphicsWinLayoutBackgrndColor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the background color of the text window.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns the background color of the text window.
	///</summary>
	public class Set_TextWinBackgrndColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextWinBackgrndColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the background color of the text window.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]

	///<summary>
	///Specifies or returns the background color of the text window.
	///</summary>
	public class TextWinBackgrndColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextWinBackgrndColor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of text that displays in the text window.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of text that displays in the text window.
	///</summary>
	public class Set_TextWinTextColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextWinTextColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of text that displays in the text window.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]

	///<summary>
	///Specifies or returns the color of text that displays in the text window.
	///</summary>
	public class TextWinTextColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextWinTextColor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of the crosshair cursor when in paperspace.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
	[NodeInput("crossHairColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of the crosshair cursor when in paperspace.
	///</summary>
	public class Set_LayoutCrosshairColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LayoutCrosshairColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of the crosshair cursor when in paperspace.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]

	///<summary>
	///Specifies or returns the color of the crosshair cursor when in paperspace.
	///</summary>
	public class LayoutCrosshairColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LayoutCrosshairColor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of the auto-tracking vector.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
	[NodeInput("AutoTrackingVecColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of the auto-tracking vector.
	///</summary>
	public class Set_AutoTrackingVecColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AutoTrackingVecColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of the auto-tracking vector.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]

	///<summary>
	///Specifies or returns the color of the auto-tracking vector.
	///</summary>
	public class AutoTrackingVecColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AutoTrackingVecColor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the current font assigned to new text.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the current font assigned to new text.
	///</summary>
	public class Set_TextFont : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextFont = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the current font assigned to new text.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]

	///<summary>
	///Specifies or returns the current font assigned to new text.
	///</summary>
	public class TextFont : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextFont);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the current font style assigned to new text.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
	[NodeInput("nanoCAD.AcTextFontStyle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the current font style assigned to new text.
	///</summary>
	public class Set_TextFontStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextFontStyle = ((nanoCAD.AcTextFontStyle)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the current font style assigned to new text.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]

	///<summary>
	///Specifies or returns the current font style assigned to new text.
	///</summary>
	public class TextFontStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextFontStyle);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the current font size assigned to new text.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
	[NodeInput("Path", typeof(System.Int32))]

	///<summary>
	///Specifies or returns the current font size assigned to new text.
	///</summary>
	public class Set_TextFontSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextFontSize = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the current font size assigned to new text.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]

	///<summary>
	///Specifies or returns the current font size assigned to new text.
	///</summary>
	public class TextFontSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextFontSize);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of text lines to keep in memory from the text window.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
	[NodeInput("Path", typeof(System.Int32))]

	///<summary>
	///Specifies or returns the number of text lines to keep in memory from the text window.
	///</summary>
	public class Set_HistoryLines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HistoryLines = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of text lines to keep in memory from the text window.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]

	///<summary>
	///Specifies or returns the number of text lines to keep in memory from the text window.
	///</summary>
	public class HistoryLines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HistoryLines);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the application displays in the whole screen area when the application starts.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the application displays in the whole screen area when the application starts.
	///</summary>
	public class Set_MaxWindow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MaxWindow = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the application displays in the whole screen area when the application starts.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]

	///<summary>
	///Specifies or returns whether the application displays in the whole screen area when the application starts.
	///</summary>
	public class MaxWindow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MaxWindow);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether Model and Layout tabs display in the drawing window.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether Model and Layout tabs display in the drawing window.
	///</summary>
	public class Set_DisplayLayoutTabs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DisplayLayoutTabs = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether Model and Layout tabs display in the drawing window.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]

	///<summary>
	///Specifies or returns whether Model and Layout tabs display in the drawing window.
	///</summary>
	public class DisplayLayoutTabs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DisplayLayoutTabs);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether raster images or their frames display when selecting entities.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether raster images or their frames display when selecting entities.
	///</summary>
	public class Set_ImageFrameHighlight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ImageFrameHighlight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether raster images or their frames display when selecting entities.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]

	///<summary>
	///Specifies or returns whether raster images or their frames display when selecting entities.
	///</summary>
	public class ImageFrameHighlight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ImageFrameHighlight);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether raster and render images display with the highest level of color capability.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether raster and render images display with the highest level of color capability.
	///</summary>
	public class Set_TrueColorImages : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TrueColorImages = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether raster and render images display with the highest level of color capability.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]

	///<summary>
	///Specifies or returns whether raster and render images display with the highest level of color capability.
	///</summary>
	public class TrueColorImages : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TrueColorImages);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the fade percentage level used for external reference files.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies the fade percentage level used for external reference files.
	///</summary>
	public class Set_XRefFadeIntensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.XRefFadeIntensity = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the fade percentage level used for external reference files.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDisplay", typeof(object))]

	///<summary>
	///Specifies the fade percentage level used for external reference files.
	///</summary>
	public class XRefFadeIntensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.XRefFadeIntensity);

		}
	}
}
