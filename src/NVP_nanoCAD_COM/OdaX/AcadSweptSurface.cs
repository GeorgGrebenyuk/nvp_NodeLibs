using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a surface created by sweeping a 2D curve along a path
///</summary>
namespace OdaX.AcadSweptSurface 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSweptSurface_Constructor : INode 
	{
		public OdaX.IAcadSweptSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSweptSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSweptSurface_ConstructorCast : INode 
	{
		public OdaX.IAcadSweptSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSweptSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the rotation of the profile used for a swept surface.", 
		ViewType = "Data")]
	[NodeInput("AcadSweptSurface", typeof(object))]

	///<summary>
	///Specifies or returns the rotation of the profile used for a swept surface.
	///</summary>
	public class ProfileRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ProfileRotation);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the rotation of the profile used for a swept surface.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSweptSurface", typeof(object))]
	[NodeInput("profileRotationAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the rotation of the profile used for a swept surface.
	///</summary>
	public class Set_ProfileRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ProfileRotation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the profile of a swept surface is banked along the path.", 
		ViewType = "Data")]
	[NodeInput("AcadSweptSurface", typeof(object))]

	///<summary>
	///Specifies or returns whether the profile of a swept surface is banked along the path.
	///</summary>
	public class Bank : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bank);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the profile of a swept surface is banked along the path.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSweptSurface", typeof(object))]
	[NodeInput("bBank", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the profile of a swept surface is banked along the path.
	///</summary>
	public class Set_Bank : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bank = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the rotation value applied along the path of a swept surface.", 
		ViewType = "Data")]
	[NodeInput("AcadSweptSurface", typeof(object))]

	///<summary>
	///Specifies or returns the rotation value applied along the path of a swept surface.
	///</summary>
	public class Twist : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Twist);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the rotation value applied along the path of a swept surface.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSweptSurface", typeof(object))]
	[NodeInput("TwistAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the rotation value applied along the path of a swept surface.
	///</summary>
	public class Set_Twist : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Twist = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the scale factor of a swept surface.", 
		ViewType = "Data")]
	[NodeInput("AcadSweptSurface", typeof(object))]

	///<summary>
	///Specifies or returns the scale factor of a swept surface.
	///</summary>
	public class scale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.scale);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the scale factor of a swept surface.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSweptSurface", typeof(object))]
	[NodeInput("scale", typeof(System.Double))]

	///<summary>
	///Specifies or returns the scale factor of a swept surface.
	///</summary>
	public class Set_scale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.scale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Returns the length of the path for a swept surface.", 
		ViewType = "Data")]
	[NodeInput("AcadSweptSurface", typeof(object))]

	///<summary>
	///Not implemented. Returns the length of the path for a swept surface.
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
