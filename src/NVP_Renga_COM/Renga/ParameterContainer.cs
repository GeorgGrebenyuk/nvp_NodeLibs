using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ParameterContainer 
{

	[NVP_Manifest(
		Id = "6403D8F4-F1F3-4C94-B8F5-E52C070F9238", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ParameterContainer.ParameterContainer_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ParameterContainer", 
		NodeName = "_ParameterContainer_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ParameterContainer_Constructor : INode 
	{
		public Renga.IParameterContainer _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IParameterContainer;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "F049A6D5-66FF-4630-8581-4CE2701535D7", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ParameterContainer.ParameterContainer_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ParameterContainer", 
		NodeName = "_ParameterContainer_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ParameterContainer_ConstructorCast : INode 
	{
		public Renga.IParameterContainer _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IParameterContainer;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "A83F1E25-3B58-4CAE-9354-55318F3B474D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ParameterContainer.GetIds", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ParameterContainer", 
		NodeName = "GetIds", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ParameterContainer", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetIds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetIds);

		}
	}


	[NVP_Manifest(
		Id = "6FF0F5AA-C997-4F2A-B6B9-B9744AB21FFA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ParameterContainer.Contains", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ParameterContainer", 
		NodeName = "Contains", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ParameterContainer", typeof(object))]
	[NodeInput("Id", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Contains : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Contains(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "3B5C56D3-4ECC-4CD3-8689-8B8441572C7F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ParameterContainer.Get", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ParameterContainer", 
		NodeName = "Get", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ParameterContainer", typeof(object))]
	[NodeInput("Id", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Get : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Get(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "996FE039-B7ED-4020-8335-782176F644D0", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ParameterContainer.ContainsS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ParameterContainer", 
		NodeName = "ContainsS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ParameterContainer", typeof(object))]
	[NodeInput("Id", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class ContainsS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ContainsS(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "5A59B499-72AF-465E-BD21-FA297712862E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ParameterContainer.GetS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ParameterContainer", 
		NodeName = "GetS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ParameterContainer", typeof(object))]
	[NodeInput("Id", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class GetS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetS(inputs[1].Value));

		}
	}
}
