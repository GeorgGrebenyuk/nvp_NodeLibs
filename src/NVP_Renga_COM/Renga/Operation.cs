using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Operation 
{

	[NVP_Manifest(
		Id = "CC12645B-ADFB-4CD3-8F66-497403DD74CB", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Operation.Operation_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Operation", 
		NodeName = "_Operation_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Operation_Constructor : INode 
	{
		public Renga.IOperation _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IOperation;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "F0B7F9AA-0959-42F3-9046-F360A710D333", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Operation.Operation_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Operation", 
		NodeName = "_Operation_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Operation_ConstructorCast : INode 
	{
		public Renga.IOperation _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IOperation;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "72657EC5-ED40-4849-A36A-344AB0F465B5", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Operation.Start", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Operation", 
		NodeName = "Start", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Operation", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Start : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Start();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DF9C1AF5-1846-4592-863A-DE6F8E33AA63", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Operation.Apply", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Operation", 
		NodeName = "Apply", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Operation", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Apply : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Apply();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C20076FC-BA99-46C9-AAB6-92AC27D4AA35", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Operation.Rollback", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Operation", 
		NodeName = "Rollback", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Operation", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Rollback : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rollback();
			return null;
		}
	}
}
