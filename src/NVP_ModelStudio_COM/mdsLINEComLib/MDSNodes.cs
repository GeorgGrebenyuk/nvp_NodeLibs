using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSNodes Interface
///</summary>
namespace mdsLINEComLib.MDSNodes 
{

	[NVP_Manifest(
		Id = "A54390BD-7A4E-42C6-8355-D4FAF8A7687F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSNodes.MDSNodes_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSNodes", 
		NodeName = "_MDSNodes_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSNodes_Constructor : INode 
	{
		public mdsLINEComLib.IMDSNodes _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IMDSNodes;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "AB9F5AB7-9FFC-45D0-9DFB-C65A994CE24F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSNodes.MDSNodes_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSNodes", 
		NodeName = "_MDSNodes_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSNodes_ConstructorCast : INode 
	{
		public mdsLINEComLib.IMDSNodes _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IMDSNodes;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "60D7A61D-E901-4BBE-A915-39C00671AEDB", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSNodes.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSNodes", 
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
		Id = "FA0656D7-0C83-4155-AB12-65531D14865F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSNodes.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSNodes", 
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
