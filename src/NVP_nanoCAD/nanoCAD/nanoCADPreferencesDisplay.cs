using NVP.API.Nodes;

namespace nanoCAD.nanoCADPreferencesDisplay 
{
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


		///<summary>
		///Returns the Application object.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		public class Application : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Application);

			}
		}


		///<summary>
		///Specifies or returns whether margins display in layouts.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_LayoutDisplayMargins : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LayoutDisplayMargins = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether margins display in layouts.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		public class LayoutDisplayMargins : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LayoutDisplayMargins);

			}
		}


		///<summary>
		///Specifies or returns whether a paper background displays in layouts.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_LayoutDisplayPaper : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LayoutDisplayPaper = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether a paper background displays in layouts.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		public class LayoutDisplayPaper : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LayoutDisplayPaper);

			}
		}


		///<summary>
		///Specifies or returns whether a paper background shadow displays in layouts.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_LayoutDisplayPaperShadow : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LayoutDisplayPaperShadow = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether a paper background shadow displays in layouts.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		public class LayoutDisplayPaperShadow : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LayoutDisplayPaperShadow);

			}
		}


		///<summary>
		///Specifies or returns whether the application prompts for print settings whenever a new layout is created.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_LayoutShowPlotSetup : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LayoutShowPlotSetup = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether the application prompts for print settings whenever a new layout is created.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		public class LayoutShowPlotSetup : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LayoutShowPlotSetup);

			}
		}


		///<summary>
		///Specifies or returns whether a viewport is created automatically for each new layout.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_LayoutCreateViewport : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LayoutCreateViewport = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether a viewport is created automatically for each new layout.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		public class LayoutCreateViewport : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LayoutCreateViewport);

			}
		}


		///<summary>
		///Specifies or returns whether scroll bars display in the drawing window.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_DisplayScrollBars : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.DisplayScrollBars = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether scroll bars display in the drawing window.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		public class DisplayScrollBars : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DisplayScrollBars);

			}
		}


		///<summary>
		///Specifies or returns whether a screen menu displays in the drawing window.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_DisplayScreenMenu : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.DisplayScreenMenu = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether a screen menu displays in the drawing window.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		public class DisplayScreenMenu : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DisplayScreenMenu);

			}
		}


		///<summary>
		///Specifies or returns the size of the crosshair cursor as a percentage of the total screen size.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		[NodeInput("Path", typeof(System.Int32))]
		public class Set_CursorSize : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.CursorSize = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the size of the crosshair cursor as a percentage of the total screen size.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		public class CursorSize : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CursorSize);

			}
		}


		///<summary>
		///Specifies or returns the number of text lines to display in the command window.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		[NodeInput("Path", typeof(System.Int32))]
		public class Set_DockedVisibleLines : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.DockedVisibleLines = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the number of text lines to display in the command window.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		public class DockedVisibleLines : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DockedVisibleLines);

			}
		}


		///<summary>
		///Specifies or returns whether raster images display when using real-time zoom and pan.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_ShowRasterImage : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ShowRasterImage = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether raster images display when using real-time zoom and pan.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		public class ShowRasterImage : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ShowRasterImage);

			}
		}


		///<summary>
		///Specifies or returns the background color of the drawing window when in modelspace.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		[NodeInput("color", typeof(System.Object))]
		public class Set_GraphicsWinModelBackgrndColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.GraphicsWinModelBackgrndColor = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the background color of the drawing window when in modelspace.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		public class GraphicsWinModelBackgrndColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GraphicsWinModelBackgrndColor);

			}
		}


		///<summary>
		///Specifies or returns the color of the crosshair cursor when in modelspace.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		[NodeInput("crossHairColor", typeof(System.Object))]
		public class Set_ModelCrosshairColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ModelCrosshairColor = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the color of the crosshair cursor when in modelspace.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		public class ModelCrosshairColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ModelCrosshairColor);

			}
		}


		///<summary>
		///Specifies or returns the background color when in paperspace.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		[NodeInput("color", typeof(System.Object))]
		public class Set_GraphicsWinLayoutBackgrndColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.GraphicsWinLayoutBackgrndColor = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the background color when in paperspace.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		public class GraphicsWinLayoutBackgrndColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GraphicsWinLayoutBackgrndColor);

			}
		}


		///<summary>
		///Specifies or returns the background color of the text window.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_TextWinBackgrndColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextWinBackgrndColor = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the background color of the text window.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		public class TextWinBackgrndColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextWinBackgrndColor);

			}
		}


		///<summary>
		///Specifies or returns the color of text that displays in the text window.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_TextWinTextColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextWinTextColor = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the color of text that displays in the text window.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		public class TextWinTextColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextWinTextColor);

			}
		}


		///<summary>
		///Specifies or returns the color of the crosshair cursor when in paperspace.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		[NodeInput("crossHairColor", typeof(System.Object))]
		public class Set_LayoutCrosshairColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LayoutCrosshairColor = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the color of the crosshair cursor when in paperspace.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		public class LayoutCrosshairColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LayoutCrosshairColor);

			}
		}


		///<summary>
		///Specifies or returns the color of the auto-tracking vector.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		[NodeInput("AutoTrackingVecColor", typeof(System.Object))]
		public class Set_AutoTrackingVecColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AutoTrackingVecColor = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the color of the auto-tracking vector.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		public class AutoTrackingVecColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.AutoTrackingVecColor);

			}
		}


		///<summary>
		///Specifies or returns the current font assigned to new text.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_TextFont : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextFont = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the current font assigned to new text.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		public class TextFont : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextFont);

			}
		}


		///<summary>
		///Specifies or returns the current font style assigned to new text.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_TextFontStyle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextFontStyle = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the current font style assigned to new text.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		public class TextFontStyle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextFontStyle);

			}
		}


		///<summary>
		///Specifies or returns the current font size assigned to new text.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		[NodeInput("Path", typeof(System.Int32))]
		public class Set_TextFontSize : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextFontSize = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the current font size assigned to new text.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		public class TextFontSize : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextFontSize);

			}
		}


		///<summary>
		///Specifies or returns the number of text lines to keep in memory from the text window.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		[NodeInput("Path", typeof(System.Int32))]
		public class Set_HistoryLines : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.HistoryLines = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the number of text lines to keep in memory from the text window.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		public class HistoryLines : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.HistoryLines);

			}
		}


		///<summary>
		///Specifies or returns whether the application displays in the whole screen area when the application starts.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_MaxWindow : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.MaxWindow = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether the application displays in the whole screen area when the application starts.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		public class MaxWindow : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.MaxWindow);

			}
		}


		///<summary>
		///Specifies or returns whether Model and Layout tabs display in the drawing window.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_DisplayLayoutTabs : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.DisplayLayoutTabs = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether Model and Layout tabs display in the drawing window.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		public class DisplayLayoutTabs : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DisplayLayoutTabs);

			}
		}


		///<summary>
		///Specifies or returns whether raster images or their frames display when selecting entities.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_ImageFrameHighlight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ImageFrameHighlight = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether raster images or their frames display when selecting entities.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		public class ImageFrameHighlight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ImageFrameHighlight);

			}
		}


		///<summary>
		///Specifies or returns whether raster and render images display with the highest level of color capability.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_TrueColorImages : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TrueColorImages = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether raster and render images display with the highest level of color capability.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		public class TrueColorImages : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TrueColorImages);

			}
		}


		///<summary>
		///Specifies the fade percentage level used for external reference files.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_XRefFadeIntensity : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.XRefFadeIntensity = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the fade percentage level used for external reference files.
		///</summary>
		[NodeInput("nanoCADPreferencesDisplay", typeof(object))]
		public class XRefFadeIntensity : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.XRefFadeIntensity);

			}
		}
}
