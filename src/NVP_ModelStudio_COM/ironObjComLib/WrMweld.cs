using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrMweld Interface
///</summary>
namespace ironObjComLib.WrMweld 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrMweld_Constructor : INode 
	{
		public ironObjComLib.IWrMweld _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrMweld;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrMweld_ConstructorCast : INode 
	{
		public ironObjComLib.IWrMweld _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrMweld;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("WrMweld", typeof(object))]

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
	[NodeInput("WrMweld", typeof(object))]
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
		Text = "property CONTINUOUSNESS", 
		ViewType = "Data")]
	[NodeInput("WrMweld", typeof(object))]

	///<summary>
	///property CONTINUOUSNESS
	///</summary>
	public class continuousness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.continuousness);

		}
	}


	[NVP_Manifest(
		Text = "property CONTINUOUSNESS", 
		ViewType = "Modifier")]
	[NodeInput("WrMweld", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property CONTINUOUSNESS
	///</summary>
	public class Set_continuousness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.continuousness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property JOINT_TYPE", 
		ViewType = "Data")]
	[NodeInput("WrMweld", typeof(object))]

	///<summary>
	///property JOINT_TYPE
	///</summary>
	public class joint_type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.joint_type);

		}
	}


	[NVP_Manifest(
		Text = "property JOINT_TYPE", 
		ViewType = "Modifier")]
	[NodeInput("WrMweld", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property JOINT_TYPE
	///</summary>
	public class Set_joint_type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.joint_type = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property CONVENTION", 
		ViewType = "Data")]
	[NodeInput("WrMweld", typeof(object))]

	///<summary>
	///property CONVENTION
	///</summary>
	public class convention : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.convention);

		}
	}


	[NVP_Manifest(
		Text = "property CONVENTION", 
		ViewType = "Modifier")]
	[NodeInput("WrMweld", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property CONVENTION
	///</summary>
	public class Set_convention : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.convention = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property PRODUCTION_TYPE", 
		ViewType = "Data")]
	[NodeInput("WrMweld", typeof(object))]

	///<summary>
	///property PRODUCTION_TYPE
	///</summary>
	public class production_type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.production_type);

		}
	}


	[NVP_Manifest(
		Text = "property PRODUCTION_TYPE", 
		ViewType = "Modifier")]
	[NodeInput("WrMweld", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property PRODUCTION_TYPE
	///</summary>
	public class Set_production_type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.production_type = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property CATHETUS_LENGTH", 
		ViewType = "Data")]
	[NodeInput("WrMweld", typeof(object))]

	///<summary>
	///property CATHETUS_LENGTH
	///</summary>
	public class cathetus : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.cathetus);

		}
	}


	[NVP_Manifest(
		Text = "property CATHETUS_LENGTH", 
		ViewType = "Modifier")]
	[NodeInput("WrMweld", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property CATHETUS_LENGTH
	///</summary>
	public class Set_cathetus : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.cathetus = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property LENGTH", 
		ViewType = "Data")]
	[NodeInput("WrMweld", typeof(object))]

	///<summary>
	///property LENGTH
	///</summary>
	public class Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Length);

		}
	}
}
