using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.QuantityContainer 
{

	[NVP_Manifest(
		Id = "7EB31ABF-651F-490F-900E-854E19F4CFB0", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.QuantityContainer.QuantityContainer_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.QuantityContainer", 
		NodeName = "_QuantityContainer_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class QuantityContainer_Constructor : INode 
	{
		public Renga.IQuantityContainer _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IQuantityContainer;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "02CE3BFD-2EBD-4B06-97E8-E18B40CCFA73", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.QuantityContainer.QuantityContainer_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.QuantityContainer", 
		NodeName = "_QuantityContainer_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class QuantityContainer_ConstructorCast : INode 
	{
		public Renga.IQuantityContainer _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IQuantityContainer;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "12E21A1E-1CF9-43DB-9C13-8AFA72503B50", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.QuantityContainer.Contains", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.QuantityContainer", 
		NodeName = "Contains", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("QuantityContainer", typeof(object))]
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
		Id = "CEE5BF64-E752-4EF9-B1BD-4A2B3CD9C041", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.QuantityContainer.Get", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.QuantityContainer", 
		NodeName = "Get", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("QuantityContainer", typeof(object))]
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
		Id = "45A1D455-28A6-4F33-B2F4-9785A07CD7A9", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.QuantityContainer.ContainsS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.QuantityContainer", 
		NodeName = "ContainsS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("QuantityContainer", typeof(object))]
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
		Id = "77C5E740-4A53-4A8A-9335-ABB08838E07F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.QuantityContainer.GetS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.QuantityContainer", 
		NodeName = "GetS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("QuantityContainer", typeof(object))]
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
