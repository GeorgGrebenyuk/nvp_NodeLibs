using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMcCOMPlugin Interface
///</summary>
namespace McCOM2.McCOMPlugin2 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class McCOMPlugin2_Constructor : INode 
	{
		public McCOM2.IMcCOMPlugin2 _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IMcCOMPlugin2;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class McCOMPlugin2_ConstructorCast : INode 
	{
		public McCOM2.IMcCOMPlugin2 _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IMcCOMPlugin2;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "method Activate", 
		ViewType = "Modifier")]
	[NodeInput("McCOMPlugin2", typeof(object))]
	[NodeInput("pServer", typeof(System.Object))]

	///<summary>
	///method Activate
	///</summary>
	public class Activate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Activate(inputs[1].Value);
			return null;
		}
	}
}
