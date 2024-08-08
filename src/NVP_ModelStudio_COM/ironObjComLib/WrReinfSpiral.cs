using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrReinfSpiral Interface
///</summary>
namespace ironObjComLib.WrReinfSpiral 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrReinfSpiral_Constructor : INode 
	{
		public ironObjComLib.IWrReinfSpiral _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrReinfSpiral;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrReinfSpiral_ConstructorCast : INode 
	{
		public ironObjComLib.IWrReinfSpiral _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrReinfSpiral;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("WrReinfSpiral", typeof(object))]

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
	[NodeInput("WrReinfSpiral", typeof(object))]
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
	[NodeInput("WrReinfSpiral", typeof(object))]

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
	[NodeInput("WrReinfSpiral", typeof(object))]
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
	[NodeInput("WrReinfSpiral", typeof(object))]

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
	[NodeInput("WrReinfSpiral", typeof(object))]
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
	[NodeInput("WrReinfSpiral", typeof(object))]

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
		Text = "property Class", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfSpiral", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Class
	///</summary>
	public class Set_Class : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Class = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Diameter", 
		ViewType = "Data")]
	[NodeInput("WrReinfSpiral", typeof(object))]

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
		Text = "property Diameter", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfSpiral", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Diameter
	///</summary>
	public class Set_Diameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Diameter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Height", 
		ViewType = "Data")]
	[NodeInput("WrReinfSpiral", typeof(object))]

	///<summary>
	///property Height
	///</summary>
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	[NVP_Manifest(
		Text = "property Height", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfSpiral", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Height
	///</summary>
	public class Set_Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Height = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Details", 
		ViewType = "Data")]
	[NodeInput("WrReinfSpiral", typeof(object))]

	///<summary>
	///property Details
	///</summary>
	public class Details : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Details);

		}
	}


	[NVP_Manifest(
		Text = "property Details", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfSpiral", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Details
	///</summary>
	public class Set_Details : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Details = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Radius", 
		ViewType = "Data")]
	[NodeInput("WrReinfSpiral", typeof(object))]

	///<summary>
	///property Radius
	///</summary>
	public class Radius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Radius);

		}
	}


	[NVP_Manifest(
		Text = "property Radius", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfSpiral", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Radius
	///</summary>
	public class Set_Radius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Radius = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Step", 
		ViewType = "Data")]
	[NodeInput("WrReinfSpiral", typeof(object))]

	///<summary>
	///property Step
	///</summary>
	public class Step : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Step);

		}
	}


	[NVP_Manifest(
		Text = "property Step", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfSpiral", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Step
	///</summary>
	public class Set_Step : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Step = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property RunWeight", 
		ViewType = "Data")]
	[NodeInput("WrReinfSpiral", typeof(object))]

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
	[NodeInput("WrReinfSpiral", typeof(object))]
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
	[NodeInput("WrReinfSpiral", typeof(object))]

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
	[NodeInput("WrReinfSpiral", typeof(object))]
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
	[NodeInput("WrReinfSpiral", typeof(object))]

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
	[NodeInput("WrReinfSpiral", typeof(object))]
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
	[NodeInput("WrReinfSpiral", typeof(object))]

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
