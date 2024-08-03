using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSObjects Interface
///</summary>
namespace mdsUnitsLib.MDSObjects 
{

	[NVP_Manifest(
		Id = "7EA56914-99CC-43A9-A870-AB477C174FDB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSObjects.MDSObjects_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSObjects", 
		NodeName = "_MDSObjects_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSObjects_Constructor : INode 
	{
		public mdsUnitsLib.IMDSObjects _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IMDSObjects;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "BD660340-600D-4AE2-9D06-344338CA2740", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSObjects.MDSObjects_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSObjects", 
		NodeName = "_MDSObjects_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSObjects_ConstructorCast : INode 
	{
		public mdsUnitsLib.IMDSObjects _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IMDSObjects;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "6C36B7A0-1656-431F-99C9-193BFF9F68E1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSObjects.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSObjects", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method Item", 
		ViewType = "Data")]
	[NodeInput("MDSObjects", typeof(object))]

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
		Id = "4B290748-9903-4EDF-B6D2-69CBB46DDEEA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSObjects.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSObjects", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Count", 
		ViewType = "Data")]
	[NodeInput("MDSObjects", typeof(object))]

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
