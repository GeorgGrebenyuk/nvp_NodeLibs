using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ModelObjectCollection 
{

	[NVP_Manifest(
		Id = "BE46A04B-5B64-4C7C-A8DF-F6EB21352170", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ModelObjectCollection.ModelObjectCollection_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ModelObjectCollection", 
		NodeName = "_ModelObjectCollection_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ModelObjectCollection_Constructor : INode 
	{
		public Renga.IModelObjectCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IModelObjectCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "EA7F3F99-E022-4A20-B65A-19A154CCD229", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ModelObjectCollection.ModelObjectCollection_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ModelObjectCollection", 
		NodeName = "_ModelObjectCollection_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ModelObjectCollection_ConstructorCast : INode 
	{
		public Renga.IModelObjectCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IModelObjectCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "482A2D49-638D-442D-8EF5-C2F768451345", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ModelObjectCollection.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ModelObjectCollection", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ModelObjectCollection", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	[NVP_Manifest(
		Id = "2F24F737-886C-475A-98A9-4F04D72A26AC", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ModelObjectCollection.GetByIndex", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ModelObjectCollection", 
		NodeName = "GetByIndex", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ModelObjectCollection", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetByIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetByIndex(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "409A2E7B-A007-4089-A040-13EA9C628F88", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ModelObjectCollection.GetById", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ModelObjectCollection", 
		NodeName = "GetById", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ModelObjectCollection", typeof(object))]
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
		Id = "A7D0635C-87CB-458C-8B6E-6A71B1C74342", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ModelObjectCollection.GetIds", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ModelObjectCollection", 
		NodeName = "GetIds", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ModelObjectCollection", typeof(object))]

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
