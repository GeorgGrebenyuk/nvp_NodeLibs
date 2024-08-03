using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ModelObject 
{

	[NVP_Manifest(
		Id = "66E472A8-6229-4876-9300-BA615ACC6903", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ModelObject.ModelObject_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ModelObject", 
		NodeName = "_ModelObject_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ModelObject_Constructor : INode 
	{
		public Renga.IModelObject _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IModelObject;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "8C7926F3-4785-4D98-BA9B-DCB22D76A05B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ModelObject.ModelObject_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ModelObject", 
		NodeName = "_ModelObject_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ModelObject_ConstructorCast : INode 
	{
		public Renga.IModelObject _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IModelObject;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "71FCE53D-566E-4A55-AB7A-53E781948EDC", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ModelObject.ObjectType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ModelObject", 
		NodeName = "ObjectType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ModelObject", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ObjectType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectType);

		}
	}


	[NVP_Manifest(
		Id = "7BE18C54-00EC-4D22-BDAA-F48280E9DE94", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ModelObject.Id", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ModelObject", 
		NodeName = "Id", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ModelObject", typeof(object))]

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
		Id = "A800B902-BC53-4CCD-AA1E-305839A65E7B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ModelObject.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ModelObject", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ModelObject", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Id = "560B0C93-C9BA-462D-A6A8-119989B7724C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ModelObject.GetProperties", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ModelObject", 
		NodeName = "GetProperties", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ModelObject", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetProperties : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetProperties);

		}
	}


	[NVP_Manifest(
		Id = "F3503B3D-9558-45D9-9686-153F85FDE869", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ModelObject.GetQuantities", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ModelObject", 
		NodeName = "GetQuantities", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ModelObject", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetQuantities : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetQuantities);

		}
	}


	[NVP_Manifest(
		Id = "601984C4-0395-42FB-A398-D0C537D1CA8A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ModelObject.ObjectTypeS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ModelObject", 
		NodeName = "ObjectTypeS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ModelObject", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ObjectTypeS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectTypeS);

		}
	}
}
