using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ProjectCloseEvent 
{

	[NVP_Manifest(
		Id = "12048B1B-1B26-424E-9936-550ED93E905C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ProjectCloseEvent.ProjectCloseEvent_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ProjectCloseEvent", 
		NodeName = "_ProjectCloseEvent_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ProjectCloseEvent_Constructor : INode 
	{
		public Renga.IProjectCloseEvent _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IProjectCloseEvent;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "996B2813-B101-41A8-9B25-5C7BDAC8B69F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ProjectCloseEvent.ProjectCloseEvent_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ProjectCloseEvent", 
		NodeName = "_ProjectCloseEvent_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ProjectCloseEvent_ConstructorCast : INode 
	{
		public Renga.IProjectCloseEvent _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IProjectCloseEvent;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "52191BEC-BBB5-4DBC-BA20-9FD29CD66C96", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ProjectCloseEvent.Prevent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ProjectCloseEvent", 
		NodeName = "Prevent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ProjectCloseEvent", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Prevent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Prevent();
			return null;
		}
	}
}
