using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ICADLibQuery Interface
///</summary>
namespace mdsLibManagerLib.CADLibQuery 
{

	[NVP_Manifest(
		Id = "68F7A8AC-AE61-495A-9C09-B66598814235", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLibManagerLib.CADLibQuery.CADLibQuery_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLibManagerLib.CADLibQuery", 
		NodeName = "_CADLibQuery_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class CADLibQuery_Constructor : INode 
	{
		public mdsLibManagerLib.ICADLibQuery _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLibManagerLib.ICADLibQuery;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "21826389-6401-4BEC-893D-9D6B9D432C31", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLibManagerLib.CADLibQuery.CADLibQuery_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLibManagerLib.CADLibQuery", 
		NodeName = "_CADLibQuery_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class CADLibQuery_ConstructorCast : INode 
	{
		public mdsLibManagerLib.ICADLibQuery _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLibManagerLib.ICADLibQuery;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "62AB5C34-C266-48D7-ABF0-E73278D1F88C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLibManagerLib.CADLibQuery.AddCondition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLibManagerLib.CADLibQuery", 
		NodeName = "AddCondition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method AddCondition", 
		ViewType = "Modifier")]
	[NodeInput("CADLibQuery", typeof(object))]
	[NodeInput("ParamName", typeof(System.String))]
	[NodeInput("Relation", typeof(System.Object))]
	[NodeInput("Value", typeof(System.String))]

	///<summary>
	///method AddCondition
	///</summary>
	public class AddCondition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddCondition(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "154637CF-414B-4C19-8BB5-3EB19F1827A9", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLibManagerLib.CADLibQuery.Execute2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLibManagerLib.CADLibQuery", 
		NodeName = "Execute", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method Execute", 
		ViewType = "Data")]
	[NodeInput("CADLibQuery", typeof(object))]

	///<summary>
	///method Execute
	///</summary>
	public class Execute2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Execute);

		}
	}


	[NVP_Manifest(
		Id = "D0B87CBD-FF4B-4387-97C6-EC43458814CA", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLibManagerLib.CADLibQuery.Search", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLibManagerLib.CADLibQuery", 
		NodeName = "Search", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method Search", 
		ViewType = "Data")]
	[NodeInput("CADLibQuery", typeof(object))]
	[NodeInput("hWndParent", typeof(System.Object))]
	[NodeInput("bsCaption", typeof(System.String))]

	///<summary>
	///method Search
	///</summary>
	public class Search : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Search(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "6F05DB51-3C23-4FCA-9F2C-CF9C32E7932B", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLibManagerLib.CADLibQuery.SelectObjects", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLibManagerLib.CADLibQuery", 
		NodeName = "SelectObjects", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method SelectObjects", 
		ViewType = "Data")]
	[NodeInput("CADLibQuery", typeof(object))]
	[NodeInput("hWndParent", typeof(System.Object))]
	[NodeInput("Caption", typeof(System.String))]
	[NodeInput("Options", typeof(System.Object))]

	///<summary>
	///method SelectObjects
	///</summary>
	public class SelectObjects : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SelectObjects(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}
}
