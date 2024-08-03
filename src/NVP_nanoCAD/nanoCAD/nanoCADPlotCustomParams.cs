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
		Id = "320E20FB-F7B4-4D51-AD9E-2EFD908E2A5B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.nanoCADPlotCustomParams_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "_nanoCADPlotCustomParams_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "C19F4E82-EFF0-4789-95C4-FB49009C78CC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.nanoCADPlotCustomParams_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "_nanoCADPlotCustomParams_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "8928ECF4-1A44-44A8-AE20-515B9197872A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.Params", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "Params", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "3621FB6C-5FCC-4DAD-A737-C0482EC6CD89", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.Set_Params", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "Set_Params", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "6B2AF7FB-4A19-4CE8-A179-4609CDE8195F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.Put_Params", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "Put_Params", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "60476AFC-0FCC-441E-A2D3-D792CE488485", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.ColorMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "ColorMode", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "430D7A28-DB82-4254-BDFD-1E5AFC745516", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.Set_ColorMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "Set_ColorMode", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "C4FCACCC-0781-4BBA-BEBF-D5926742123B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.PrinterDPI", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "PrinterDPI", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "8F359BFC-CFDD-41E8-B428-99BDBA16503D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.Set_PrinterDPI", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "Set_PrinterDPI", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "E5ACE6D3-E5D9-4C41-B137-FFDE3D13BA2E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.UsePrefinedNames", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "UsePrefinedNames", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "6FFCC610-A525-4DAA-AB39-59469A97AAB2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.Set_UsePrefinedNames", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "Set_UsePrefinedNames", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "CD73D2DE-1EF8-42B0-B4E2-08FA62172686", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.IfFileExist", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "IfFileExist", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "EF968F0C-4D20-4CF6-8811-E23131F3159A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.Set_IfFileExist", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "Set_IfFileExist", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "FF60C4DD-7941-4F39-878A-C259962B57CF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.RunPDFApp", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "RunPDFApp", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "4E3E08E2-E756-4B08-8FE2-3C99DB63A0BB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.Set_RunPDFApp", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "Set_RunPDFApp", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "D0E709B6-7507-422C-8C4B-E5EE9DB920A5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.UseDWGPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "UseDWGPath", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "75A803DE-A02D-4D3B-A16F-41FFF70DFC7F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.Set_UseDWGPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "Set_UseDWGPath", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "90A1B40F-5159-4F04-BF1A-511283345BB4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.FileFolder", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "FileFolder", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "B0E56098-1A58-45B8-AC97-F99227AD5827", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.Set_FileFolder", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "Set_FileFolder", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "886E9077-4966-4FEF-B4C7-43E465DE0F3A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.FileMask", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "FileMask", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "FA591FBB-9A4B-418D-A5D0-4B6B80018411", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.Set_FileMask", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "Set_FileMask", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "813283ED-6BFC-4BE2-A94B-01BB9849644D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.PlotToFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "PlotToFile", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "FADA00B8-616E-43A1-A1E2-02FD470E43A1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.Set_PlotToFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "Set_PlotToFile", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "41404A12-E82F-495F-9F2A-A8A4D425F970", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.Multipage", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "Multipage", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "72888401-4C8C-43FC-8272-0052BECBAE39", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.Set_Multipage", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "Set_Multipage", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "9D32D755-B5C1-41A5-B6C9-C782C0866DAF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.InflateWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "InflateWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "DDE634AA-E796-4AF3-BF08-B241E812FC71", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.Set_InflateWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "Set_InflateWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "8765E839-9063-4DB8-98BF-D1F71CDE9EB2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.Alignment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "Alignment", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "8C27FEE6-0748-4F36-9AA6-FE4E8256E362", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.Set_Alignment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "Set_Alignment", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "70879638-B56F-47CA-8EF3-39B959AF3058", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.PaperOutMargins", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "PaperOutMargins", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "A1A5ED1B-B21E-47A8-B352-2B21E2D5CBD6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.Set_PaperOutMargins", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "Set_PaperOutMargins", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "71E60D66-24DF-48D5-AD6F-AD7D8714BC3F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotCustomParams.PlotAreas", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotCustomParams", 
		NodeName = "PlotAreas", 
		NodeType = "Loaded", 
		CADType = "None", 
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
