using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Roughness of surface
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.SymRoughness 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymRoughness_Constructor : INode 
	{
		public McCOM2.ISymRoughness _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymRoughness;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymRoughness_ConstructorCast : INode 
	{
		public McCOM2.ISymRoughness _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymRoughness;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x000002f2", 
		ViewType = "Data")]
	[NodeInput("SymRoughness", typeof(object))]

	///<summary>
	///0x000002f2
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
		Text = "0x000002f2", 
		ViewType = "Modifier")]
	[NodeInput("SymRoughness", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000002f2
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
		Text = "0x000002dc", 
		ViewType = "Data")]
	[NodeInput("SymRoughness", typeof(object))]

	///<summary>
	///0x000002dc
	///</summary>
	public class Angle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Angle);

		}
	}


	[NVP_Manifest(
		Text = "0x000002dc", 
		ViewType = "Modifier")]
	[NodeInput("SymRoughness", typeof(object))]
	[NodeInput("prValue", typeof(System.Double))]

	///<summary>
	///0x000002dc
	///</summary>
	public class Set_Angle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Angle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000002e3", 
		ViewType = "Data")]
	[NodeInput("SymRoughness", typeof(object))]

	///<summary>
	///0x000002e3
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
		Text = "0x000002e3", 
		ViewType = "Modifier")]
	[NodeInput("SymRoughness", typeof(object))]
	[NodeInput("prDirection", typeof(System.Object))]

	///<summary>
	///0x000002e3
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
		Text = "0x000002f1", 
		ViewType = "Data")]
	[NodeInput("SymRoughness", typeof(object))]

	///<summary>
	///0x000002f1
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
		Text = "0x000002f1", 
		ViewType = "Modifier")]
	[NodeInput("SymRoughness", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x000002f1
	///</summary>
	public class Set_Technology : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Technology = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000002ed", 
		ViewType = "Data")]
	[NodeInput("SymRoughness", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x000002ed
	///</summary>
	public class Parameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Parameter(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "0x000002ed", 
		ViewType = "Modifier")]
	[NodeInput("SymRoughness", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x000002ed
	///</summary>
	public class Set_Parameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Parameter[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000002e1", 
		ViewType = "Data")]
	[NodeInput("SymRoughness", typeof(object))]

	///<summary>
	///0x000002e1
	///</summary>
	public class Default : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Default);

		}
	}


	[NVP_Manifest(
		Text = "0x000002e1", 
		ViewType = "Modifier")]
	[NodeInput("SymRoughness", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000002e1
	///</summary>
	public class Set_Default : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Default = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000002df", 
		ViewType = "Data")]
	[NodeInput("SymRoughness", typeof(object))]

	///<summary>
	///0x000002df
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
		Text = "0x000002df", 
		ViewType = "Modifier")]
	[NodeInput("SymRoughness", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000002df
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
		Text = "0x000002ef", 
		ViewType = "Data")]
	[NodeInput("SymRoughness", typeof(object))]

	///<summary>
	///0x000002ef
	///</summary>
	public class ProcessingType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ProcessingType);

		}
	}


	[NVP_Manifest(
		Text = "0x000002ef", 
		ViewType = "Modifier")]
	[NodeInput("SymRoughness", typeof(object))]
	[NodeInput("McCOM2.RoughnessProcessingType", typeof(System.Object))]

	///<summary>
	///0x000002ef
	///</summary>
	public class Set_ProcessingType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ProcessingType = ((McCOM2.RoughnessProcessingType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000002e4", 
		ViewType = "Data")]
	[NodeInput("SymRoughness", typeof(object))]

	///<summary>
	///0x000002e4
	///</summary>
	public class Frame : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Frame);

		}
	}


	[NVP_Manifest(
		Text = "0x000002e4", 
		ViewType = "Modifier")]
	[NodeInput("SymRoughness", typeof(object))]
	[NodeInput("ppFrame", typeof(System.Object))]

	///<summary>
	///0x000002e4
	///</summary>
	public class Set_Frame : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Frame = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000002ee", 
		ViewType = "Data")]
	[NodeInput("SymRoughness", typeof(object))]

	///<summary>
	///0x000002ee
	///</summary>
	public class ProcessingDir : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ProcessingDir);

		}
	}


	[NVP_Manifest(
		Text = "0x000002ee", 
		ViewType = "Modifier")]
	[NodeInput("SymRoughness", typeof(object))]
	[NodeInput("McCOM2.RoughnessProcessingDirection", typeof(System.Object))]

	///<summary>
	///0x000002ee
	///</summary>
	public class Set_ProcessingDir : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ProcessingDir = ((McCOM2.RoughnessProcessingDirection)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000002e7", 
		ViewType = "Data")]
	[NodeInput("SymRoughness", typeof(object))]

	///<summary>
	///0x000002e7
	///</summary>
	public class Leaders : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Leaders);

		}
	}
}
