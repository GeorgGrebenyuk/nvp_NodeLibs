using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Level mark
///</summary>
namespace McCOM2.SymSpdsLevel 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsLevel_Constructor : INode 
	{
		public McCOM2.ISymSpdsLevel _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsLevel;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsLevel_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsLevel _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsLevel;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x00000396", 
		ViewType = "Data")]
	[NodeInput("SymSpdsLevel", typeof(object))]

	///<summary>
	///0x00000396
	///</summary>
	public class Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Value);

		}
	}


	[NVP_Manifest(
		Text = "0x00000396", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsLevel", typeof(object))]
	[NodeInput("pvResult", typeof(System.Object))]

	///<summary>
	///0x00000396
	///</summary>
	public class Set_Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Value = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000388", 
		ViewType = "Data")]
	[NodeInput("SymSpdsLevel", typeof(object))]

	///<summary>
	///0x00000388
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
		Text = "0x00000389", 
		ViewType = "Data")]
	[NodeInput("SymSpdsLevel", typeof(object))]

	///<summary>
	///0x00000389
	///</summary>
	public class Footer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Footer);

		}
	}


	[NVP_Manifest(
		Text = "0x00000389", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsLevel", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x00000389
	///</summary>
	public class Set_Footer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Footer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000383", 
		ViewType = "Data")]
	[NodeInput("SymSpdsLevel", typeof(object))]

	///<summary>
	///0x00000383
	///</summary>
	public class Base : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Base);

		}
	}


	[NVP_Manifest(
		Text = "0x00000383", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsLevel", typeof(object))]
	[NodeInput("ppBase", typeof(System.Object))]

	///<summary>
	///0x00000383
	///</summary>
	public class Set_Base : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Base = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000392", 
		ViewType = "Data")]
	[NodeInput("SymSpdsLevel", typeof(object))]

	///<summary>
	///0x00000392
	///</summary>
	public class Origin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Origin);

		}
	}


	[NVP_Manifest(
		Text = "0x00000392", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsLevel", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000392
	///</summary>
	public class Set_Origin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Origin = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000393", 
		ViewType = "Data")]
	[NodeInput("SymSpdsLevel", typeof(object))]

	///<summary>
	///0x00000393
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
		Text = "0x00000393", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsLevel", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000393
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
		Text = "0x00000395", 
		ViewType = "Data")]
	[NodeInput("SymSpdsLevel", typeof(object))]

	///<summary>
	///0x00000395
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
		Text = "0x00000395", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsLevel", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000395
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
		Text = "0x00000382", 
		ViewType = "Data")]
	[NodeInput("SymSpdsLevel", typeof(object))]

	///<summary>
	///0x00000382
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
		Text = "0x00000382", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsLevel", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x00000382
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
		Text = "0x0000038f", 
		ViewType = "Data")]
	[NodeInput("SymSpdsLevel", typeof(object))]

	///<summary>
	///0x0000038f
	///</summary>
	public class Mirrored : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Mirrored);

		}
	}


	[NVP_Manifest(
		Text = "0x0000038f", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsLevel", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x0000038f
	///</summary>
	public class Set_Mirrored : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Mirrored = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000037a", 
		ViewType = "Data")]
	[NodeInput("SymSpdsLevel", typeof(object))]

	///<summary>
	///0x0000037a
	///</summary>
	public class AffectsTo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AffectsTo);

		}
	}
}
