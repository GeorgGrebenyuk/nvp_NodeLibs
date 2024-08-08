using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrReinfAsm Interface
///</summary>
namespace ironObjComLib.WrReinfAsm 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrReinfAsm_Constructor : INode 
	{
		public ironObjComLib.IWrReinfAsm _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrReinfAsm;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrReinfAsm_ConstructorCast : INode 
	{
		public ironObjComLib.IWrReinfAsm _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrReinfAsm;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("WrReinfAsm", typeof(object))]

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
	[NodeInput("WrReinfAsm", typeof(object))]
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
		Text = "property Mark", 
		ViewType = "Data")]
	[NodeInput("WrReinfAsm", typeof(object))]

	///<summary>
	///property Mark
	///</summary>
	public class Mark : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Mark);

		}
	}


	[NVP_Manifest(
		Text = "property Group", 
		ViewType = "Data")]
	[NodeInput("WrReinfAsm", typeof(object))]

	///<summary>
	///property Group
	///</summary>
	public class Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Group);

		}
	}


	[NVP_Manifest(
		Text = "property Parent", 
		ViewType = "Data")]
	[NodeInput("WrReinfAsm", typeof(object))]

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
	[NodeInput("WrReinfAsm", typeof(object))]
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
		Text = "property X", 
		ViewType = "Data")]
	[NodeInput("WrReinfAsm", typeof(object))]

	///<summary>
	///property X
	///</summary>
	public class X : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.X);

		}
	}


	[NVP_Manifest(
		Text = "property X", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfAsm", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property X
	///</summary>
	public class Set_X : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.X = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Y", 
		ViewType = "Data")]
	[NodeInput("WrReinfAsm", typeof(object))]

	///<summary>
	///property Y
	///</summary>
	public class Y : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Y);

		}
	}


	[NVP_Manifest(
		Text = "property Y", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfAsm", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Y
	///</summary>
	public class Set_Y : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Y = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Z", 
		ViewType = "Data")]
	[NodeInput("WrReinfAsm", typeof(object))]

	///<summary>
	///property Z
	///</summary>
	public class Z : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Z);

		}
	}


	[NVP_Manifest(
		Text = "property Z", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfAsm", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Z
	///</summary>
	public class Set_Z : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Z = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "master assembly check", 
		ViewType = "Data")]
	[NodeInput("WrReinfAsm", typeof(object))]

	///<summary>
	///master assembly check
	///</summary>
	public class isMasterAssemblyReference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.isMasterAssemblyReference);

		}
	}
}
