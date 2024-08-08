using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///The set of methods and properties used for plotting layouts
///</summary>
namespace nanoCAD.nanoCADPlotArea 
{

	[NVP_Manifest(
		Id = "2DD240E3-F95D-495A-8D3A-481E19A5D050", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea.nanoCADPlotArea_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea", 
		NodeName = "_nanoCADPlotArea_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPlotArea_Constructor : INode 
	{
		public nanoCAD.InanoCADPlotArea _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADPlotArea;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "0F95F4F0-AB84-4475-A68B-0FDE403782D9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea.nanoCADPlotArea_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea", 
		NodeName = "_nanoCADPlotArea_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPlotArea_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADPlotArea _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADPlotArea;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "7615E42A-478E-410A-9CF6-45048AB561E5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea.Offset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea", 
		NodeName = "Offset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves offset val", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotArea", typeof(object))]

	///<summary>
	///Retrieves offset val
	///</summary>
	public class Offset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Offset);

		}
	}


	[NVP_Manifest(
		Id = "4A034B9A-F50F-4C50-9142-7AF527753DC5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea.Set_Offset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea", 
		NodeName = "Set_Offset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves offset val", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotArea", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves offset val
	///</summary>
	public class Set_Offset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Offset = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D3CEA1C3-A778-411A-B42B-3F81FCBA3F69", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea.ptMin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea", 
		NodeName = "ptMin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves ptMin val", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotArea", typeof(object))]

	///<summary>
	///Retrieves ptMin val
	///</summary>
	public class ptMin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ptMin);

		}
	}


	[NVP_Manifest(
		Id = "4FD613C3-66DD-4543-AE36-1ECF51E187EC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea.Set_ptMin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea", 
		NodeName = "Set_ptMin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves ptMin val", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotArea", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves ptMin val
	///</summary>
	public class Set_ptMin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ptMin = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BF0EE5BB-AC2C-4990-88A9-2A5938E50B96", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea.ptMax", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea", 
		NodeName = "ptMax", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves ptMax val", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotArea", typeof(object))]

	///<summary>
	///Retrieves ptMax val
	///</summary>
	public class ptMax : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ptMax);

		}
	}


	[NVP_Manifest(
		Id = "CB3F3705-32F9-463B-8CEB-74B39425CDED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotArea.Set_ptMax", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotArea", 
		NodeName = "Set_ptMax", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves ptMax val", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotArea", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves ptMax val
	///</summary>
	public class Set_ptMax : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ptMax = inputs[1].Value;
			return null;
		}
	}
}
