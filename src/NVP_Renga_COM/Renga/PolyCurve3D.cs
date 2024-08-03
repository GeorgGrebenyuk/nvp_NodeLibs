using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.PolyCurve3D 
{

	[NVP_Manifest(
		Id = "CE0BF417-4179-417D-9B91-4632089DF7E7", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PolyCurve3D.PolyCurve3D_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PolyCurve3D", 
		NodeName = "_PolyCurve3D_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PolyCurve3D_Constructor : INode 
	{
		public Renga.IPolyCurve3D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IPolyCurve3D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "CCE7ACB9-D566-4B1F-9522-CC31660A5D3C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PolyCurve3D.PolyCurve3D_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PolyCurve3D", 
		NodeName = "_PolyCurve3D_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PolyCurve3D_ConstructorCast : INode 
	{
		public Renga.IPolyCurve3D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IPolyCurve3D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "8D5F5DCE-3358-44AF-91F0-318B54BA3D20", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PolyCurve3D.GetSegmentCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PolyCurve3D", 
		NodeName = "GetSegmentCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("PolyCurve3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetSegmentCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetSegmentCount);

		}
	}


	[NVP_Manifest(
		Id = "24CB0E9B-A32A-4373-8D7D-AE34020F985C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PolyCurve3D.GetSegment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PolyCurve3D", 
		NodeName = "GetSegment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("PolyCurve3D", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetSegment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetSegment(inputs[1].Value));

		}
	}
}
