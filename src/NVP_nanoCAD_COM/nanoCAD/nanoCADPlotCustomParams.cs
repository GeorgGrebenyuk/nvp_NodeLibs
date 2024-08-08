using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///The set of methods and properties used for plotting layouts
///</summary>
namespace nanoCAD.nanoCADPlotCustomParams 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPlotCustomParams_Constructor : INode 
	{
		public nanoCAD.InanoCADPlotCustomParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADPlotCustomParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPlotCustomParams_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADPlotCustomParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADPlotCustomParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "value", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]

	///<summary>
	///value
	///</summary>
	public class Params : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Params);

		}
	}


	[NVP_Manifest(
		Text = "value", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]
	[NodeInput("param", typeof(System.Object))]

	///<summary>
	///value
	///</summary>
	public class Set_Params : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Params = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "value", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]
	[NodeInput("param", typeof(System.Object))]

	///<summary>
	///value
	///</summary>
	public class Put_Params : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Params = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves color mode value", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]

	///<summary>
	///Retrieves color mode value
	///</summary>
	public class ColorMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColorMode);

		}
	}


	[NVP_Manifest(
		Text = "Retrieves color mode value", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves color mode value
	///</summary>
	public class Set_ColorMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ColorMode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves PrinterDPI value", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]

	///<summary>
	///Retrieves PrinterDPI value
	///</summary>
	public class PrinterDPI : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PrinterDPI);

		}
	}


	[NVP_Manifest(
		Text = "Retrieves PrinterDPI value", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves PrinterDPI value
	///</summary>
	public class Set_PrinterDPI : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PrinterDPI = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves UsePrefinedNames value", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]

	///<summary>
	///Retrieves UsePrefinedNames value
	///</summary>
	public class UsePrefinedNames : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UsePrefinedNames);

		}
	}


	[NVP_Manifest(
		Text = "Retrieves UsePrefinedNames value", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves UsePrefinedNames value
	///</summary>
	public class Set_UsePrefinedNames : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UsePrefinedNames = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves IfFileExist value", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]

	///<summary>
	///Retrieves IfFileExist value
	///</summary>
	public class IfFileExist : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IfFileExist);

		}
	}


	[NVP_Manifest(
		Text = "Retrieves IfFileExist value", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]
	[NodeInput("nanoCAD.FileExistAction", typeof(System.Object))]

	///<summary>
	///Retrieves IfFileExist value
	///</summary>
	public class Set_IfFileExist : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IfFileExist = ((nanoCAD.FileExistAction)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves RunPDFApp value", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]

	///<summary>
	///Retrieves RunPDFApp value
	///</summary>
	public class RunPDFApp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RunPDFApp);

		}
	}


	[NVP_Manifest(
		Text = "Retrieves RunPDFApp value", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves RunPDFApp value
	///</summary>
	public class Set_RunPDFApp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RunPDFApp = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves UseDWGPath value", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]

	///<summary>
	///Retrieves UseDWGPath value
	///</summary>
	public class UseDWGPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UseDWGPath);

		}
	}


	[NVP_Manifest(
		Text = "Retrieves UseDWGPath value", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves UseDWGPath value
	///</summary>
	public class Set_UseDWGPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UseDWGPath = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves FileFolder value", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]

	///<summary>
	///Retrieves FileFolder value
	///</summary>
	public class FileFolder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FileFolder);

		}
	}


	[NVP_Manifest(
		Text = "Retrieves FileFolder value", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]
	[NodeInput("val", typeof(System.String))]

	///<summary>
	///Retrieves FileFolder value
	///</summary>
	public class Set_FileFolder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FileFolder = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves FileMask value", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]

	///<summary>
	///Retrieves FileMask value
	///</summary>
	public class FileMask : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FileMask);

		}
	}


	[NVP_Manifest(
		Text = "Retrieves FileMask value", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]
	[NodeInput("val", typeof(System.String))]

	///<summary>
	///Retrieves FileMask value
	///</summary>
	public class Set_FileMask : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FileMask = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves PlotToFile value", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]

	///<summary>
	///Retrieves PlotToFile value
	///</summary>
	public class PlotToFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotToFile);

		}
	}


	[NVP_Manifest(
		Text = "Retrieves PlotToFile value", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves PlotToFile value
	///</summary>
	public class Set_PlotToFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotToFile = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves Multipage value", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]

	///<summary>
	///Retrieves Multipage value
	///</summary>
	public class Multipage : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Multipage);

		}
	}


	[NVP_Manifest(
		Text = "Retrieves Multipage value", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves Multipage value
	///</summary>
	public class Set_Multipage : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Multipage = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves InflateWidth value", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]

	///<summary>
	///Retrieves InflateWidth value
	///</summary>
	public class InflateWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InflateWidth);

		}
	}


	[NVP_Manifest(
		Text = "Retrieves InflateWidth value", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]
	[NodeInput("val", typeof(System.Double))]

	///<summary>
	///Retrieves InflateWidth value
	///</summary>
	public class Set_InflateWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InflateWidth = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves Alignment value", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]

	///<summary>
	///Retrieves Alignment value
	///</summary>
	public class Alignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Alignment);

		}
	}


	[NVP_Manifest(
		Text = "Retrieves Alignment value", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves Alignment value
	///</summary>
	public class Set_Alignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Alignment = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves PaperOutMargins value", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]

	///<summary>
	///Retrieves PaperOutMargins value
	///</summary>
	public class PaperOutMargins : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PaperOutMargins);

		}
	}


	[NVP_Manifest(
		Text = "Retrieves PaperOutMargins value", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves PaperOutMargins value
	///</summary>
	public class Set_PaperOutMargins : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PaperOutMargins = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves Plot Areas", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotCustomParams", typeof(object))]

	///<summary>
	///Retrieves Plot Areas
	///</summary>
	public class PlotAreas : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotAreas);

		}
	}
}
