using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///Specifies display settings.
///</summary>
namespace nanoCAD.nanoCADPreferencesDisplay 
{

	[NVP_Manifest(
		Id = "A751BCC7-E018-472A-A09C-E625A18FD6C1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.nanoCADPreferencesDisplay_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "_nanoCADPreferencesDisplay_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "36C4D6E1-D59A-4D0C-AA61-35B47B4510E5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.nanoCADPreferencesDisplay_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "_nanoCADPreferencesDisplay_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "7001331C-86B7-4073-9BE9-681ACC9922BC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.Application", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "Application", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "861E879F-9093-42F8-B0B3-6F5AF142231E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.Set_LayoutDisplayMargins", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "Set_LayoutDisplayMargins", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "F201CAA2-B838-4215-BA34-5A6F797CB05B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.LayoutDisplayMargins", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "LayoutDisplayMargins", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "238D1B3B-DF41-4051-8487-893A52970E96", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.Set_LayoutDisplayPaper", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "Set_LayoutDisplayPaper", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "FC707D0D-DD62-4FB4-8087-E13FE62FB97C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.LayoutDisplayPaper", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "LayoutDisplayPaper", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "C9A2CE8A-F412-47B2-AE10-096DE5EA7904", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.Set_LayoutDisplayPaperShadow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "Set_LayoutDisplayPaperShadow", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "BF24D1B9-0C18-4FDC-A255-BCBECF588045", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.LayoutDisplayPaperShadow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "LayoutDisplayPaperShadow", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "AB039235-3D9B-4CDC-80E6-73143DAE5BA6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.Set_LayoutShowPlotSetup", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "Set_LayoutShowPlotSetup", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "08F54AC4-4170-43BB-A463-16132849F896", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.LayoutShowPlotSetup", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "LayoutShowPlotSetup", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "30599C68-CA11-4F68-983E-7EA9CBC383BE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.Set_LayoutCreateViewport", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "Set_LayoutCreateViewport", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "E88ABF4D-2BC4-4D01-BE62-E4B345B445A6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.LayoutCreateViewport", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "LayoutCreateViewport", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "75FBBC5F-C024-41E6-ABB0-76B1E88AEC2D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.Set_DisplayScrollBars", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "Set_DisplayScrollBars", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "874ED0E8-DB98-45C1-BFC2-CFF08786AB12", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.DisplayScrollBars", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "DisplayScrollBars", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "6C2CC014-186E-46E2-BBA9-CB9BDED45C94", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.Set_DisplayScreenMenu", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "Set_DisplayScreenMenu", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "B68706D8-AA20-4D5B-BFDC-0B93A59CA95C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.DisplayScreenMenu", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "DisplayScreenMenu", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "03F5A7E8-5460-4DBD-A054-F741D937833E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.Set_CursorSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "Set_CursorSize", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "2E8DC3E0-7ED5-473D-8C08-55FE8DCE2FE2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.CursorSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "CursorSize", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "B0AFDCF7-21FA-4058-9248-79246981BF26", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.Set_DockedVisibleLines", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "Set_DockedVisibleLines", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "9371E7CF-F89D-4068-833A-44B6B8F49BD1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.DockedVisibleLines", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "DockedVisibleLines", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "7C537985-5747-4F44-A5C0-8D0D75988587", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.Set_ShowRasterImage", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "Set_ShowRasterImage", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "A06E136F-2271-4EF6-A98D-1DC5405EA3B5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.ShowRasterImage", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "ShowRasterImage", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "F7852536-B17E-4024-AC2F-E19738784F2B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.Set_GraphicsWinModelBackgrndColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "Set_GraphicsWinModelBackgrndColor", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "66F509ED-4379-4E4A-93B6-7C3C6430B1E1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.GraphicsWinModelBackgrndColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "GraphicsWinModelBackgrndColor", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "FA790045-ECCB-4D25-857F-8CB583297B60", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.Set_ModelCrosshairColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "Set_ModelCrosshairColor", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "6EBB31A8-5960-4425-860B-D58DC23AB85F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.ModelCrosshairColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "ModelCrosshairColor", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "4BDF25C8-5109-44C9-8532-F2F9963B2342", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.Set_GraphicsWinLayoutBackgrndColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "Set_GraphicsWinLayoutBackgrndColor", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "B5CC7E14-E178-4D1D-B729-4AA698D90285", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.GraphicsWinLayoutBackgrndColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "GraphicsWinLayoutBackgrndColor", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "DF522B78-86D3-419A-9538-285CB2A6F8E9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.Set_TextWinBackgrndColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "Set_TextWinBackgrndColor", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "4FCFE6ED-C8EC-4CFB-9266-F7347216A88A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.TextWinBackgrndColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "TextWinBackgrndColor", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "7EF71F30-3A27-4F0C-BAD7-4C38063B4E75", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.Set_TextWinTextColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "Set_TextWinTextColor", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "7817A090-5EAD-45BE-99AD-D0EDCDAEFF87", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.TextWinTextColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "TextWinTextColor", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "79FAE57F-896F-4E3A-BB8F-98E307FF2A5F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.Set_LayoutCrosshairColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "Set_LayoutCrosshairColor", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "4154F59A-8876-4816-8891-E0D994F234F2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.LayoutCrosshairColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "LayoutCrosshairColor", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "C7B15460-F2E6-4A88-9560-BC68AE3D7085", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.Set_AutoTrackingVecColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "Set_AutoTrackingVecColor", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "17C0ADC4-4B44-483F-B6E8-C55A7C8B84DA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.AutoTrackingVecColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "AutoTrackingVecColor", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "3A0E8019-EEC6-4FC6-8967-BAA1153B345A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.Set_TextFont", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "Set_TextFont", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "555A145E-B137-4F9C-AE3E-AC1807BD8910", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.TextFont", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "TextFont", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "35705CAA-FE86-4A8D-B181-29D4C8A97A72", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.Set_TextFontStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "Set_TextFontStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "095F86AE-BA00-43AC-A044-D37A50A0C380", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.TextFontStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "TextFontStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "A34FF5AD-349D-43FD-A2B2-B004D486AAA5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.Set_TextFontSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "Set_TextFontSize", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "F62BF44F-FAA3-49C5-8A91-D5C41B32F7DD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.TextFontSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "TextFontSize", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "E4F837B8-BEFC-4A13-B1EA-D680259CA18E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.Set_HistoryLines", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "Set_HistoryLines", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "48C97243-0FC4-4892-9ABF-B40E30236E00", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.HistoryLines", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "HistoryLines", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "F7DD2DE0-DE27-4FF5-9456-C39EEEE0ECD0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.Set_MaxWindow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "Set_MaxWindow", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "F82F83B5-A91B-47F2-9243-E26CB87E0E65", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.MaxWindow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "MaxWindow", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "306326E2-A486-48BC-8DB5-3981A33773BA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.Set_DisplayLayoutTabs", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "Set_DisplayLayoutTabs", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "548D2640-4E57-4405-8DD0-A295E377F0B1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.DisplayLayoutTabs", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "DisplayLayoutTabs", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "0722058E-A83D-4FA9-804F-C316B4ACFD9A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.Set_ImageFrameHighlight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "Set_ImageFrameHighlight", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "4F93DAAF-DAC7-42C5-AFAB-87C9C731D01A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.ImageFrameHighlight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "ImageFrameHighlight", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "85EABF6D-E589-43B7-981B-16A57E2DCF3F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.Set_TrueColorImages", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "Set_TrueColorImages", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "CA8F2650-FCD7-4B3B-8738-431184F41B31", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.TrueColorImages", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "TrueColorImages", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "B9D2ADD7-88C1-4406-98F6-F28FA362489F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.Set_XRefFadeIntensity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "Set_XRefFadeIntensity", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "4CBEA80C-B97D-465D-A421-ACEA97ED4FBF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDisplay.XRefFadeIntensity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDisplay", 
		NodeName = "XRefFadeIntensity", 
		NodeType = "Loaded", 
		CADType = "None", 
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
