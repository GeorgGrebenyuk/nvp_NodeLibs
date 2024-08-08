using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrIronReinf Interface
///</summary>
namespace ironObjComLib.WrIronReinf 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrIronReinf_Constructor : INode 
	{
		public ironObjComLib.IWrIronReinf _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrIronReinf;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrIronReinf_ConstructorCast : INode 
	{
		public ironObjComLib.IWrIronReinf _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrIronReinf;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("WrIronReinf", typeof(object))]

	///<summary>
	///property Element
	///</summary>
	public class Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Element);

		}
	}


	[NVP_Manifest(
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("WrIronReinf", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Element
	///</summary>
	public class Set_Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Element = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Parent", 
		ViewType = "Data")]
	[NodeInput("WrIronReinf", typeof(object))]

	///<summary>
	///property Parent
	///</summary>
	public class Parent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Parent);

		}
	}


	[NVP_Manifest(
		Text = "property Parent", 
		ViewType = "Modifier")]
	[NodeInput("WrIronReinf", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Parent
	///</summary>
	public class Set_Parent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Parent = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Name", 
		ViewType = "Data")]
	[NodeInput("WrIronReinf", typeof(object))]

	///<summary>
	///property Name
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
		Text = "property Name", 
		ViewType = "Modifier")]
	[NodeInput("WrIronReinf", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Name
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Class", 
		ViewType = "Data")]
	[NodeInput("WrIronReinf", typeof(object))]

	///<summary>
	///property Class
	///</summary>
	public class Class : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Class);

		}
	}


	[NVP_Manifest(
		Text = "property Diameter", 
		ViewType = "Data")]
	[NodeInput("WrIronReinf", typeof(object))]

	///<summary>
	///property Diameter
	///</summary>
	public class Diameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Diameter);

		}
	}


	[NVP_Manifest(
		Text = "property MinBendAngle", 
		ViewType = "Data")]
	[NodeInput("WrIronReinf", typeof(object))]

	///<summary>
	///property MinBendAngle
	///</summary>
	public class MinBendAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinBendAngle);

		}
	}


	[NVP_Manifest(
		Text = "property MinBendAngle", 
		ViewType = "Modifier")]
	[NodeInput("WrIronReinf", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property MinBendAngle
	///</summary>
	public class Set_MinBendAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MinBendAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property MinBendDiameter", 
		ViewType = "Data")]
	[NodeInput("WrIronReinf", typeof(object))]

	///<summary>
	///property MinBendDiameter
	///</summary>
	public class MinBendDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinBendDiameter);

		}
	}


	[NVP_Manifest(
		Text = "property MinBendDiameter", 
		ViewType = "Modifier")]
	[NodeInput("WrIronReinf", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property MinBendDiameter
	///</summary>
	public class Set_MinBendDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MinBendDiameter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property RunWeight", 
		ViewType = "Data")]
	[NodeInput("WrIronReinf", typeof(object))]

	///<summary>
	///property RunWeight
	///</summary>
	public class RunWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RunWeight);

		}
	}


	[NVP_Manifest(
		Text = "property RunWeight", 
		ViewType = "Modifier")]
	[NodeInput("WrIronReinf", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property RunWeight
	///</summary>
	public class Set_RunWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RunWeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property SecArea", 
		ViewType = "Data")]
	[NodeInput("WrIronReinf", typeof(object))]

	///<summary>
	///property SecArea
	///</summary>
	public class SecArea : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SecArea);

		}
	}


	[NVP_Manifest(
		Text = "property SecArea", 
		ViewType = "Modifier")]
	[NodeInput("WrIronReinf", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property SecArea
	///</summary>
	public class Set_SecArea : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SecArea = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Length", 
		ViewType = "Data")]
	[NodeInput("WrIronReinf", typeof(object))]

	///<summary>
	///property Length
	///</summary>
	public class Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Length);

		}
	}


	[NVP_Manifest(
		Text = "property Length", 
		ViewType = "Modifier")]
	[NodeInput("WrIronReinf", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Length
	///</summary>
	public class Set_Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Length = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Weight", 
		ViewType = "Data")]
	[NodeInput("WrIronReinf", typeof(object))]

	///<summary>
	///property Weight
	///</summary>
	public class Weight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Weight);

		}
	}
}
