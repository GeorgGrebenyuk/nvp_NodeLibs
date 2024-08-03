using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.View 
{

	[NVP_Manifest(
		Id = "DAFDD0C6-297F-49B9-ADA1-815250CB5FF3", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.View.View_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.View", 
		NodeName = "_View_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class View_Constructor : INode 
	{
		public Renga.IView _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IView;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "8416B6D8-C97D-4EE7-A6D9-E677EDFEB36F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.View.View_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.View", 
		NodeName = "_View_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class View_ConstructorCast : INode 
	{
		public Renga.IView _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IView;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "02CA81CA-1C67-4E55-ADBE-25ACF5CF9648", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.View.Id", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.View", 
		NodeName = "Id", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("View", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Id : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Id);

		}
	}


	[NVP_Manifest(
		Id = "9C7E0B4C-4DEA-4154-8104-7377F24D0C0D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.View.Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.View", 
		NodeName = "Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("View", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Type);

		}
	}
}
