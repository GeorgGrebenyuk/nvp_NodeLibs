using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of an object composed of an arrowhead attached to splines or straight line segments
///</summary>
namespace OdaX.AcadLeader 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadLeader_Constructor : INode 
	{
		public OdaX.IAcadLeader _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadLeader;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadLeader_ConstructorCast : INode 
	{
		public OdaX.IAcadLeader _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadLeader;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the vertices of a leader.", 
		ViewType = "Data")]
	[NodeInput("AcadLeader", typeof(object))]

	///<summary>
	///Specifies or returns the vertices of a leader.
	///</summary>
	public class Coordinates : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Coordinates);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the vertices of a leader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("Coordinates", typeof(System.Object))]

	///<summary>
	///Specifies or returns the vertices of a leader.
	///</summary>
	public class Set_Coordinates : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Coordinates = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Data")]
	[NodeInput("AcadLeader", typeof(object))]

	///<summary>
	///Specifies the x, y, and z coordinates of the normal direction vector.
	///</summary>
	public class Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Normal);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the style of a leader.", 
		ViewType = "Data")]
	[NodeInput("AcadLeader", typeof(object))]

	///<summary>
	///Specifies or returns the style of a leader.
	///</summary>
	public class StyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StyleName);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the style of a leader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies or returns the style of a leader.
	///</summary>
	public class Set_StyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StyleName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the type of a leader.", 
		ViewType = "Data")]
	[NodeInput("AcadLeader", typeof(object))]

	///<summary>
	///Specifies or returns the type of a leader.
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
		Text = "Specifies or returns the type of a leader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("OdaX.AcLeaderType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the type of a leader.
	///</summary>
	public class Set_Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Type = ((OdaX.AcLeaderType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Evaluates and updates a leader and its associated entity and annotation.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLeader", typeof(object))]

	///<summary>
	///Evaluates and updates a leader and its associated entity and annotation.
	///</summary>
	public class Evaluate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Evaluate();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the coordinate of a single vertex in an object.", 
		ViewType = "Data")]
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Specifies or returns the coordinate of a single vertex in an object.
	///</summary>
	public class Coordinate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Coordinate(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the coordinate of a single vertex in an object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the coordinate of a single vertex in an object.
	///</summary>
	public class Set_Coordinate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Coordinate[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the annotation of a leader.", 
		ViewType = "Data")]
	[NodeInput("AcadLeader", typeof(object))]

	///<summary>
	///Specifies or returns the annotation of a leader.
	///</summary>
	public class Annotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Annotation);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the annotation of a leader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the annotation of a leader.
	///</summary>
	public class Set_Annotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Annotation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the arrowhead size of a leader.", 
		ViewType = "Data")]
	[NodeInput("AcadLeader", typeof(object))]

	///<summary>
	///Specifies or returns the arrowhead size of a leader.
	///</summary>
	public class ArrowheadSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowheadSize);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the arrowhead size of a leader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("size", typeof(System.Double))]

	///<summary>
	///Specifies or returns the arrowhead size of a leader.
	///</summary>
	public class Set_ArrowheadSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowheadSize = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the arrowhead type of a leader.", 
		ViewType = "Data")]
	[NodeInput("AcadLeader", typeof(object))]

	///<summary>
	///Specifies or returns the arrowhead type of a leader.
	///</summary>
	public class ArrowheadType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowheadType);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the arrowhead type of a leader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("OdaX.AcDimArrowheadType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the arrowhead type of a leader.
	///</summary>
	public class Set_ArrowheadType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowheadType = ((OdaX.AcDimArrowheadType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the line color of a leader.", 
		ViewType = "Data")]
	[NodeInput("AcadLeader", typeof(object))]

	///<summary>
	///Specifies or returns the line color of a leader.
	///</summary>
	public class DimensionLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimensionLineColor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the line color of a leader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]

	///<summary>
	///Specifies or returns the line color of a leader.
	///</summary>
	public class Set_DimensionLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimensionLineColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lineweight of a leader.", 
		ViewType = "Data")]
	[NodeInput("AcadLeader", typeof(object))]

	///<summary>
	///Specifies or returns the lineweight of a leader.
	///</summary>
	public class DimensionLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimensionLineWeight);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lineweight of a leader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("weight", typeof(System.Object))]

	///<summary>
	///Specifies or returns the lineweight of a leader.
	///</summary>
	public class Set_DimensionLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimensionLineWeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the scale of a leader.", 
		ViewType = "Data")]
	[NodeInput("AcadLeader", typeof(object))]

	///<summary>
	///Specifies or returns the scale of a leader.
	///</summary>
	public class ScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleFactor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the scale of a leader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("factor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the scale of a leader.
	///</summary>
	public class Set_ScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the vertical placement of a leader annotation.", 
		ViewType = "Data")]
	[NodeInput("AcadLeader", typeof(object))]

	///<summary>
	///Specifies or returns the vertical placement of a leader annotation.
	///</summary>
	public class VerticalTextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VerticalTextPosition);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the vertical placement of a leader annotation.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("OdaX.AcDimVerticalJustification", typeof(System.Object))]

	///<summary>
	///Specifies or returns the vertical placement of a leader annotation.
	///</summary>
	public class Set_VerticalTextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VerticalTextPosition = ((OdaX.AcDimVerticalJustification)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the distance between the leader and the annotation.", 
		ViewType = "Data")]
	[NodeInput("AcadLeader", typeof(object))]

	///<summary>
	///Specifies or returns the distance between the leader and the annotation.
	///</summary>
	public class TextGap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextGap);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the distance between the leader and the annotation.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("Offset", typeof(System.Double))]

	///<summary>
	///Specifies or returns the distance between the leader and the annotation.
	///</summary>
	public class Set_TextGap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextGap = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the block used for a custom arrowhead of a leader.", 
		ViewType = "Data")]
	[NodeInput("AcadLeader", typeof(object))]

	///<summary>
	///Specifies or returns the block used for a custom arrowhead of a leader.
	///</summary>
	public class ArrowheadBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowheadBlock);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the block used for a custom arrowhead of a leader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("BlockName", typeof(System.String))]

	///<summary>
	///Specifies or returns the block used for a custom arrowhead of a leader.
	///</summary>
	public class Set_ArrowheadBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowheadBlock = inputs[1].Value;
			return null;
		}
	}
}
