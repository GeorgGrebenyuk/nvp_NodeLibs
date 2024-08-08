using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Specifies output settings.
///</summary>
namespace nanoCAD.nanoCADPreferencesOutput 
{

	[NVP_Manifest(
		Id = "0C5EB38D-8913-41A3-9399-1E8EF14CFF66", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOutput.nanoCADPreferencesOutput_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOutput", 
		NodeName = "_nanoCADPreferencesOutput_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "79F734F8-A9F7-4BEE-B05A-E4CB9C1CCE49", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOutput.nanoCADPreferencesOutput_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOutput", 
		NodeName = "_nanoCADPreferencesOutput_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "3656662D-90D6-43B2-8E75-88DB4F69A8CB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOutput.Application", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOutput", 
		NodeName = "Application", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "34057E15-A592-4B22-9192-BCBDAC358E79", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOutput.Set_DefaultOutputDevice", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOutput", 
		NodeName = "Set_DefaultOutputDevice", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "F72F2885-B261-4EB2-9082-7195422C20E5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOutput.DefaultOutputDevice", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOutput", 
		NodeName = "DefaultOutputDevice", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "C2B3EBB0-DDCE-415A-9598-1EB53C900348", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOutput.Set_PrinterSpoolAlert", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOutput", 
		NodeName = "Set_PrinterSpoolAlert", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "48643ED3-DFF3-4E32-A223-57FBB797651A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOutput.PrinterSpoolAlert", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOutput", 
		NodeName = "PrinterSpoolAlert", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "E7EB7F85-72DC-45C7-88B8-F873BE52CB6F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOutput.Set_PrinterPaperSizeAlert", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOutput", 
		NodeName = "Set_PrinterPaperSizeAlert", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "EB7B2DC0-4974-4C39-B7F6-A64A3D103BE9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOutput.PrinterPaperSizeAlert", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOutput", 
		NodeName = "PrinterPaperSizeAlert", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "ADFCE947-5A68-4341-AC64-C403967648A0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOutput.Set_PlotLegacy", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOutput", 
		NodeName = "Set_PlotLegacy", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "647D97A1-F4F1-44FA-969C-B90475E7B668", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOutput.PlotLegacy", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOutput", 
		NodeName = "PlotLegacy", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "D61193D4-43B3-4BF4-84A7-18C0269CFF38", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOutput.Set_OLEQuality", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOutput", 
		NodeName = "Set_OLEQuality", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "75D7DE25-9842-4FB0-AE1D-D255AB5BEFB9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOutput.OLEQuality", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOutput", 
		NodeName = "OLEQuality", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "BAACFD63-D4EA-4707-94E6-227014A78502", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOutput.Set_UseLastPlotSettings", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOutput", 
		NodeName = "Set_UseLastPlotSettings", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "016D828B-73ED-4D38-B906-43F0A5D66B9B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOutput.UseLastPlotSettings", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOutput", 
		NodeName = "UseLastPlotSettings", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "8CC6A57D-48DD-42F8-B9D6-E345BB46E6D4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOutput.Set_PlotPolicy", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOutput", 
		NodeName = "Set_PlotPolicy", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "79420462-20EA-4F32-B175-BB65F8FAA7CB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOutput.PlotPolicy", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOutput", 
		NodeName = "PlotPolicy", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "643AE35D-D628-4EE4-AC8A-AAA8E37B541C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOutput.Set_DefaultPlotStyleTable", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOutput", 
		NodeName = "Set_DefaultPlotStyleTable", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "CFC2AD69-AC14-49FF-AA71-1ECA602F5C8B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOutput.DefaultPlotStyleTable", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOutput", 
		NodeName = "DefaultPlotStyleTable", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "17367B57-C12D-47F2-9B89-375C9CEEEB0A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOutput.Set_DefaultPlotStyleForObjects", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOutput", 
		NodeName = "Set_DefaultPlotStyleForObjects", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "7B53236F-FBF7-4129-8377-1344CBEEE7E5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOutput.DefaultPlotStyleForObjects", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOutput", 
		NodeName = "DefaultPlotStyleForObjects", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "C0AE271E-F206-4768-A5E3-1891076E3DFD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOutput.Set_DefaultPlotStyleForLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOutput", 
		NodeName = "Set_DefaultPlotStyleForLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "39ACCB44-6931-4B3F-AB2E-F4F909B833D7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOutput.DefaultPlotStyleForLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOutput", 
		NodeName = "DefaultPlotStyleForLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
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
