using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Коллекция объектов
///</summary>
namespace mdsLINEComLib.MDSLObjects 
{

	[NVP_Manifest(
		Id = "5D54404F-CEDC-4858-8971-123180CB7D9E", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLObjects.MDSLObjects_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLObjects", 
		NodeName = "_MDSLObjects_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLObjects_Constructor : INode 
	{
		public mdsLINEComLib.IMDSLObjects _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IMDSLObjects;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "8F2D92B1-43F5-416A-9583-80CA73591A0F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLObjects.MDSLObjects_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLObjects", 
		NodeName = "_MDSLObjects_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLObjects_ConstructorCast : INode 
	{
		public mdsLINEComLib.IMDSLObjects _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IMDSLObjects;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "86822CE0-25CD-4E4E-9149-54AC3091FB28", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLObjects.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLObjects", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Item", 
		ViewType = "Data")]
	[NodeInput("MDSLObjects", typeof(object))]

	///<summary>
	///property Item
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
		Id = "4FCA3D1A-D9C2-4908-A2DE-8AC63022DC26", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLObjects.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLObjects", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Count", 
		ViewType = "Data")]
	[NodeInput("MDSLObjects", typeof(object))]

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
