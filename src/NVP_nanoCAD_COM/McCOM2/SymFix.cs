using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Permanent connection mark
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.SymFix 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymFix_Constructor : INode 
	{
		public McCOM2.ISymFix _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymFix;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymFix_ConstructorCast : INode 
	{
		public McCOM2.ISymFix _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymFix;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x0000021e", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x0000021e
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
		Text = "0x0000021e", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x0000021e
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
		Text = "0x00000224", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x00000224
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
		Text = "0x00000224", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000224
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
		Text = "0x00000223", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x00000223
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
		Text = "0x00000223", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x00000223
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
		Text = "0x00000214", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x00000214
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
		Text = "0x00000214", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x00000214
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
		Text = "0x00000212", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x00000212
	///</summary>
	public class Documentation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Documentation);

		}
	}


	[NVP_Manifest(
		Text = "0x00000212", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x00000212
	///</summary>
	public class Set_Documentation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Documentation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000218", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x00000218
	///</summary>
	public class LeaderText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderText);

		}
	}


	[NVP_Manifest(
		Text = "0x00000218", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x00000218
	///</summary>
	public class Set_LeaderText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderText = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000217", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x00000217
	///</summary>
	public class LeaderFooter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderFooter);

		}
	}


	[NVP_Manifest(
		Text = "0x00000217", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x00000217
	///</summary>
	public class Set_LeaderFooter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderFooter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000225", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x00000225
	///</summary>
	public class Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Type);

		}
	}


	[NVP_Manifest(
		Text = "0x00000225", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("McCOM2.SymFixType", typeof(System.Object))]

	///<summary>
	///0x00000225
	///</summary>
	public class Set_Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Type = ((McCOM2.SymFixType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000222", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x00000222
	///</summary>
	public class Technology : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Technology);

		}
	}


	[NVP_Manifest(
		Text = "0x00000222", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("McCOM2.SymFixTechnology", typeof(System.Object))]

	///<summary>
	///0x00000222
	///</summary>
	public class Set_Technology : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Technology = ((McCOM2.SymFixTechnology)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000213", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x00000213
	///</summary>
	public class Face : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Face);

		}
	}


	[NVP_Manifest(
		Text = "0x00000213", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x00000213
	///</summary>
	public class Set_Face : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Face = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000020f", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x0000020f
	///</summary>
	public class Closed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Closed);

		}
	}


	[NVP_Manifest(
		Text = "0x0000020f", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x0000020f
	///</summary>
	public class Set_Closed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Closed = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000020c", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x0000020c
	///</summary>
	public class Assembly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Assembly);

		}
	}


	[NVP_Manifest(
		Text = "0x0000020c", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("pvbAssembly", typeof(System.Object))]

	///<summary>
	///0x0000020c
	///</summary>
	public class Set_Assembly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Assembly = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000220", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x00000220
	///</summary>
	public class SeamCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SeamCount);

		}
	}


	[NVP_Manifest(
		Text = "0x00000220", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x00000220
	///</summary>
	public class Set_SeamCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SeamCount = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000221", 
		ViewType = "Data")]
	[NodeInput("SymFix", typeof(object))]

	///<summary>
	///0x00000221
	///</summary>
	public class SeamDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SeamDistance);

		}
	}


	[NVP_Manifest(
		Text = "0x00000221", 
		ViewType = "Modifier")]
	[NodeInput("SymFix", typeof(object))]
	[NodeInput("prValue", typeof(System.Double))]

	///<summary>
	///0x00000221
	///</summary>
	public class Set_SeamDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SeamDistance = inputs[1].Value;
			return null;
		}
	}
}
