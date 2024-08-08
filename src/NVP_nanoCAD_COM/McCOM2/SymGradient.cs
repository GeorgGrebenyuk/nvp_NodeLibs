using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Gradient or taper designation
///</summary>
namespace McCOM2.SymGradient 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymGradient_Constructor : INode 
	{
		public McCOM2.ISymGradient _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymGradient;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymGradient_ConstructorCast : INode 
	{
		public McCOM2.ISymGradient _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymGradient;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x0000025e", 
		ViewType = "Data")]
	[NodeInput("SymGradient", typeof(object))]

	///<summary>
	///0x0000025e
	///</summary>
	public class Taper : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Taper);

		}
	}


	[NVP_Manifest(
		Text = "0x0000025e", 
		ViewType = "Modifier")]
	[NodeInput("SymGradient", typeof(object))]
	[NodeInput("pvbType", typeof(System.Object))]

	///<summary>
	///0x0000025e
	///</summary>
	public class Set_Taper : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Taper = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000025d", 
		ViewType = "Data")]
	[NodeInput("SymGradient", typeof(object))]

	///<summary>
	///0x0000025d
	///</summary>
	public class RightToLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RightToLeft);

		}
	}


	[NVP_Manifest(
		Text = "0x0000025d", 
		ViewType = "Modifier")]
	[NodeInput("SymGradient", typeof(object))]
	[NodeInput("pvbType", typeof(System.Object))]

	///<summary>
	///0x0000025d
	///</summary>
	public class Set_RightToLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RightToLeft = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000261", 
		ViewType = "Data")]
	[NodeInput("SymGradient", typeof(object))]

	///<summary>
	///0x00000261
	///</summary>
	public class Units : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Units);

		}
	}


	[NVP_Manifest(
		Text = "0x00000261", 
		ViewType = "Modifier")]
	[NodeInput("SymGradient", typeof(object))]
	[NodeInput("McCOM2.GradientUnitType", typeof(System.Object))]

	///<summary>
	///0x00000261
	///</summary>
	public class Set_Units : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Units = ((McCOM2.GradientUnitType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000024a", 
		ViewType = "Data")]
	[NodeInput("SymGradient", typeof(object))]

	///<summary>
	///0x0000024a
	///</summary>
	public class Associative : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Associative);

		}
	}


	[NVP_Manifest(
		Text = "0x0000024a", 
		ViewType = "Modifier")]
	[NodeInput("SymGradient", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x0000024a
	///</summary>
	public class Set_Associative : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Associative = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000259", 
		ViewType = "Data")]
	[NodeInput("SymGradient", typeof(object))]

	///<summary>
	///0x00000259
	///</summary>
	public class OnPlane : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OnPlane);

		}
	}


	[NVP_Manifest(
		Text = "0x00000259", 
		ViewType = "Modifier")]
	[NodeInput("SymGradient", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x00000259
	///</summary>
	public class Set_OnPlane : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnPlane = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000250", 
		ViewType = "Data")]
	[NodeInput("SymGradient", typeof(object))]

	///<summary>
	///0x00000250
	///</summary>
	public class DisplayText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DisplayText);

		}
	}


	[NVP_Manifest(
		Text = "0x0000025f", 
		ViewType = "Data")]
	[NodeInput("SymGradient", typeof(object))]

	///<summary>
	///0x0000025f
	///</summary>
	public class Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Text);

		}
	}


	[NVP_Manifest(
		Text = "0x0000025f", 
		ViewType = "Modifier")]
	[NodeInput("SymGradient", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x0000025f
	///</summary>
	public class Set_Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Text = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000025a", 
		ViewType = "Data")]
	[NodeInput("SymGradient", typeof(object))]

	///<summary>
	///0x0000025a
	///</summary>
	public class Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position);

		}
	}


	[NVP_Manifest(
		Text = "0x0000025a", 
		ViewType = "Modifier")]
	[NodeInput("SymGradient", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x0000025a
	///</summary>
	public class Set_Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000260", 
		ViewType = "Data")]
	[NodeInput("SymGradient", typeof(object))]

	///<summary>
	///0x00000260
	///</summary>
	public class TextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextPosition);

		}
	}


	[NVP_Manifest(
		Text = "0x00000260", 
		ViewType = "Modifier")]
	[NodeInput("SymGradient", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000260
	///</summary>
	public class Set_TextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextPosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000025c", 
		ViewType = "Data")]
	[NodeInput("SymGradient", typeof(object))]

	///<summary>
	///0x0000025c
	///</summary>
	public class ReferenceDir : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ReferenceDir);

		}
	}


	[NVP_Manifest(
		Text = "0x0000025c", 
		ViewType = "Modifier")]
	[NodeInput("SymGradient", typeof(object))]
	[NodeInput("pvVector", typeof(System.Object))]

	///<summary>
	///0x0000025c
	///</summary>
	public class Set_ReferenceDir : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ReferenceDir = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000024f", 
		ViewType = "Data")]
	[NodeInput("SymGradient", typeof(object))]

	///<summary>
	///0x0000024f
	///</summary>
	public class Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Direction);

		}
	}


	[NVP_Manifest(
		Text = "0x0000024f", 
		ViewType = "Modifier")]
	[NodeInput("SymGradient", typeof(object))]
	[NodeInput("pvVector", typeof(System.Object))]

	///<summary>
	///0x0000024f
	///</summary>
	public class Set_Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Direction = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000258", 
		ViewType = "Data")]
	[NodeInput("SymGradient", typeof(object))]

	///<summary>
	///0x00000258
	///</summary>
	public class Object : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Object);

		}
	}
}
