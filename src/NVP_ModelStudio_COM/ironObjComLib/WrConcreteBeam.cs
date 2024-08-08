using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrConcreteBeam Interface
///</summary>
namespace ironObjComLib.WrConcreteBeam 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrConcreteBeam_Constructor : INode 
	{
		public ironObjComLib.IWrConcreteBeam _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrConcreteBeam;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrConcreteBeam_ConstructorCast : INode 
	{
		public ironObjComLib.IWrConcreteBeam _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrConcreteBeam;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("WrConcreteBeam", typeof(object))]

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
	[NodeInput("WrConcreteBeam", typeof(object))]
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
	[NodeInput("WrConcreteBeam", typeof(object))]

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
	[NodeInput("WrConcreteBeam", typeof(object))]
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
	[NodeInput("WrConcreteBeam", typeof(object))]

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
	[NodeInput("WrConcreteBeam", typeof(object))]
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
		Text = "property ProfileName", 
		ViewType = "Data")]
	[NodeInput("WrConcreteBeam", typeof(object))]

	///<summary>
	///property ProfileName
	///</summary>
	public class ProfileName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ProfileName);

		}
	}


	[NVP_Manifest(
		Text = "property ProfileName", 
		ViewType = "Modifier")]
	[NodeInput("WrConcreteBeam", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property ProfileName
	///</summary>
	public class Set_ProfileName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ProfileName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Length", 
		ViewType = "Data")]
	[NodeInput("WrConcreteBeam", typeof(object))]

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
	[NodeInput("WrConcreteBeam", typeof(object))]
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
	[NodeInput("WrConcreteBeam", typeof(object))]

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


	[NVP_Manifest(
		Text = "property Mark", 
		ViewType = "Data")]
	[NodeInput("WrConcreteBeam", typeof(object))]

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
		Text = "property Mark", 
		ViewType = "Modifier")]
	[NodeInput("WrConcreteBeam", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Mark
	///</summary>
	public class Set_Mark : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Mark = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property StartPoint", 
		ViewType = "Data")]
	[NodeInput("WrConcreteBeam", typeof(object))]

	///<summary>
	///property StartPoint
	///</summary>
	public class StartPt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartPt);

		}
	}


	[NVP_Manifest(
		Text = "property StartPoint", 
		ViewType = "Modifier")]
	[NodeInput("WrConcreteBeam", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property StartPoint
	///</summary>
	public class Set_StartPt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartPt = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property EndPoint", 
		ViewType = "Data")]
	[NodeInput("WrConcreteBeam", typeof(object))]

	///<summary>
	///property EndPoint
	///</summary>
	public class EndPt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndPt);

		}
	}


	[NVP_Manifest(
		Text = "property EndPoint", 
		ViewType = "Modifier")]
	[NodeInput("WrConcreteBeam", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property EndPoint
	///</summary>
	public class Set_EndPt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndPt = inputs[1].Value;
			return null;
		}
	}
}
