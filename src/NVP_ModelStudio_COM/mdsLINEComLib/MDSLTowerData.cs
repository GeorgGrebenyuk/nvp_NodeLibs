using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TowerData Interface
///</summary>
namespace mdsLINEComLib.MDSLTowerData 
{

	[NVP_Manifest(
		Id = "6F161C72-D35F-4394-807B-1C08206C8FDF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLTowerData.MDSLTowerData_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLTowerData", 
		NodeName = "_MDSLTowerData_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLTowerData_Constructor : INode 
	{
		public mdsLINEComLib.IMDSLTowerData _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IMDSLTowerData;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "256488FD-ADB5-4B75-A816-0798A865A935", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLTowerData.MDSLTowerData_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLTowerData", 
		NodeName = "_MDSLTowerData_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLTowerData_ConstructorCast : INode 
	{
		public mdsLINEComLib.IMDSLTowerData _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IMDSLTowerData;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "0C7EACC7-5379-45C7-AC35-3DFEC918B043", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLTowerData.TowerName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLTowerData", 
		NodeName = "TowerName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property TowerName", 
		ViewType = "Data")]
	[NodeInput("MDSLTowerData", typeof(object))]

	///<summary>
	///property TowerName
	///</summary>
	public class TowerName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TowerName);

		}
	}


	[NVP_Manifest(
		Id = "AA49EE09-C5EC-471B-AF5F-A6A985FE49B7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLTowerData.DataRoot", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLTowerData", 
		NodeName = "DataRoot", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DataRoot", 
		ViewType = "Data")]
	[NodeInput("MDSLTowerData", typeof(object))]

	///<summary>
	///property DataRoot
	///</summary>
	public class DataRoot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DataRoot);

		}
	}


	[NVP_Manifest(
		Id = "5747E752-353C-4AE0-BA24-B3CB9F6FC094", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLTowerData.LinkData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLTowerData", 
		NodeName = "LinkData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method LinkData", 
		ViewType = "Data")]
	[NodeInput("MDSLTowerData", typeof(object))]
	[NodeInput("phaseName", typeof(System.String))]
	[NodeInput("bLeft", typeof(System.Object))]

	///<summary>
	///method LinkData
	///</summary>
	public class LinkData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LinkData(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "8CB540AA-2CB2-42B1-AC03-DC715FDC9B87", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLTowerData.climateData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLTowerData", 
		NodeName = "climateData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method ClimateData", 
		ViewType = "Data")]
	[NodeInput("MDSLTowerData", typeof(object))]

	///<summary>
	///method ClimateData
	///</summary>
	public class climateData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.climateData);

		}
	}
}
