using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSNodes Interface
///</summary>
namespace mdsUnitsLib.MDSNodes 
{

	[NVP_Manifest(
		Id = "29AB03D4-76B1-4EE2-AC0F-8400CD01E646", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSNodes.MDSNodes_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSNodes", 
		NodeName = "_MDSNodes_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSNodes_Constructor : INode 
	{
		public mdsUnitsLib.IMDSNodes _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IMDSNodes;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "B6336C4B-04BD-422C-950D-32FAF828B043", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSNodes.MDSNodes_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSNodes", 
		NodeName = "_MDSNodes_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSNodes_ConstructorCast : INode 
	{
		public mdsUnitsLib.IMDSNodes _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IMDSNodes;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "92A7069E-FC19-41B9-B3B4-B2EB060E5E8A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSNodes.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSNodes", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method Item", 
		ViewType = "Data")]
	[NodeInput("MDSNodes", typeof(object))]

	///<summary>
	///method Item
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item);

		}
	}


	[NVP_Manifest(
		Id = "14A46B21-978A-4055-B4D0-20C8B2096972", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSNodes.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSNodes", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Count", 
		ViewType = "Data")]
	[NodeInput("MDSNodes", typeof(object))]

	///<summary>
	///property Count
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}
}
