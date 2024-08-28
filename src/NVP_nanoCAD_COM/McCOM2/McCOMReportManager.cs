using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMcCOMReportManager Interface
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.McCOMReportManager 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class McCOMReportManager_Constructor : INode 
	{
		public McCOM2.IMcCOMReportManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IMcCOMReportManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class McCOMReportManager_ConstructorCast : INode 
	{
		public McCOM2.IMcCOMReportManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IMcCOMReportManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "method AddKeyword", 
		ViewType = "Modifier")]
	[NodeInput("McCOMReportManager", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("Value", typeof(System.String))]

	///<summary>
	///method AddKeyword
	///</summary>
	public class AddKeyword : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddKeyword(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}
}
