using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Specifies output settings.
///</summary>
namespace NVP_nanoCAD_COM._nanoCAD.nanoCADPreferencesOutput 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferencesOutput_Constructor : INode 
	{
		public nanoCAD.InanoCADPreferencesOutput _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADPreferencesOutput;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferencesOutput_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADPreferencesOutput _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADPreferencesOutput;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Returns the Application object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOutput", typeof(object))]

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
		Text = "Specifies or returns the default printer for new layouts and modelspace.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOutput", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the default printer for new layouts and modelspace.
	///</summary>
	public class Set_DefaultOutputDevice : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DefaultOutputDevice = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the default printer for new layouts and modelspace.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOutput", typeof(object))]

	///<summary>
	///Specifies or returns the default printer for new layouts and modelspace.
	///</summary>
	public class DefaultOutputDevice : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DefaultOutputDevice);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether to display a warning when printing must be spooled.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOutput", typeof(object))]
	[NodeInput("nanoCAD.AcPrinterSpoolAlert", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether to display a warning when printing must be spooled.
	///</summary>
	public class Set_PrinterSpoolAlert : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PrinterSpoolAlert = ((nanoCAD.AcPrinterSpoolAlert)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether to display a warning when printing must be spooled.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOutput", typeof(object))]

	///<summary>
	///Specifies or returns whether to display a warning when printing must be spooled.
	///</summary>
	public class PrinterSpoolAlert : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PrinterSpoolAlert);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether to display a warning when there is a conflict with the specified paper size.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOutput", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether to display a warning when there is a conflict with the specified paper size.
	///</summary>
	public class Set_PrinterPaperSizeAlert : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PrinterPaperSizeAlert = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether to display a warning when there is a conflict with the specified paper size.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOutput", typeof(object))]

	///<summary>
	///Specifies or returns whether to display a warning when there is a conflict with the specified paper size.
	///</summary>
	public class PrinterPaperSizeAlert : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PrinterPaperSizeAlert);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether older print scripts can be used.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOutput", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether older print scripts can be used.
	///</summary>
	public class Set_PlotLegacy : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotLegacy = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether older print scripts can be used.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOutput", typeof(object))]

	///<summary>
	///Specifies or returns whether older print scripts can be used.
	///</summary>
	public class PlotLegacy : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotLegacy);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the print quality of OLE objects.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOutput", typeof(object))]
	[NodeInput("nanoCAD.AcOleQuality", typeof(System.Object))]

	///<summary>
	///Specifies or returns the print quality of OLE objects.
	///</summary>
	public class Set_OLEQuality : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OLEQuality = ((nanoCAD.AcOleQuality)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the print quality of OLE objects.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOutput", typeof(object))]

	///<summary>
	///Specifies or returns the print quality of OLE objects.
	///</summary>
	public class OLEQuality : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OLEQuality);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the print settings are used from the previous successful print job.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOutput", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the print settings are used from the previous successful print job.
	///</summary>
	public class Set_UseLastPlotSettings : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UseLastPlotSettings = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the print settings are used from the previous successful print job.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOutput", typeof(object))]

	///<summary>
	///Specifies or returns whether the print settings are used from the previous successful print job.
	///</summary>
	public class UseLastPlotSettings : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UseLastPlotSettings);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether color-dependent plot style tables are used for new drawings.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOutput", typeof(object))]
	[NodeInput("nanoCAD.AcPlotPolicy", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether color-dependent plot style tables are used for new drawings.
	///</summary>
	public class Set_PlotPolicy : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotPolicy = ((nanoCAD.AcPlotPolicy)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether color-dependent plot style tables are used for new drawings.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOutput", typeof(object))]

	///<summary>
	///Specifies or returns whether color-dependent plot style tables are used for new drawings.
	///</summary>
	public class PlotPolicy : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotPolicy);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the default plot style table.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOutput", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the default plot style table.
	///</summary>
	public class Set_DefaultPlotStyleTable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DefaultPlotStyleTable = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the default plot style table.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOutput", typeof(object))]

	///<summary>
	///Specifies or returns the default plot style table.
	///</summary>
	public class DefaultPlotStyleTable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DefaultPlotStyleTable);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the default print style table for new drawings.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOutput", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the default print style table for new drawings.
	///</summary>
	public class Set_DefaultPlotStyleForObjects : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DefaultPlotStyleForObjects = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the default print style table for new drawings.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOutput", typeof(object))]

	///<summary>
	///Specifies or returns the default print style table for new drawings.
	///</summary>
	public class DefaultPlotStyleForObjects : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DefaultPlotStyleForObjects);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the default print style for new drawings.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOutput", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the default print style for new drawings.
	///</summary>
	public class Set_DefaultPlotStyleForLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DefaultPlotStyleForLayer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the default print style for new drawings.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOutput", typeof(object))]

	///<summary>
	///Specifies or returns the default print style for new drawings.
	///</summary>
	public class DefaultPlotStyleForLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DefaultPlotStyleForLayer);

		}
	}
}
