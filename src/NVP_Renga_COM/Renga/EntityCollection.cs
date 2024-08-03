using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.EntityCollection 
{

	[NVP_Manifest(
		Id = "6F7084E7-49F5-4DDB-B52A-F91D5F777718", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.EntityCollection.EntityCollection_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.EntityCollection", 
		NodeName = "_EntityCollection_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class EntityCollection_Constructor : INode 
	{
		public Renga.IEntityCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IEntityCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "11009118-BFD8-45EC-863C-B16CAC90F388", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.EntityCollection.EntityCollection_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.EntityCollection", 
		NodeName = "_EntityCollection_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class EntityCollection_ConstructorCast : INode 
	{
		public Renga.IEntityCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IEntityCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "3F43E501-B602-4796-9AB6-4724D399E9CC", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.EntityCollection.GetById", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.EntityCollection", 
		NodeName = "GetById", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("EntityCollection", typeof(object))]
	[NodeInput("Id", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetById : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetById(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "59D5445C-1794-4069-B46F-57A1F2F50E3B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.EntityCollection.GetIds", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.EntityCollection", 
		NodeName = "GetIds", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("EntityCollection", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetIds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetIds();
			return null;
		}
	}
}
