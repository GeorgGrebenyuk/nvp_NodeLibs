using NVP.API.Nodes;

namespace OdaX.AcadLeader 
{
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


	///<summary>
	///Specifies or returns the vertices of a leader.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	public class Coordinates : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Coordinates);

		}
	}


	///<summary>
	///Specifies or returns the vertices of a leader.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("Coordinates", typeof(System.Object))]
	public class Set_Coordinates : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Coordinates = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the x, y, and z coordinates of the normal direction vector.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	public class Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Normal);

		}
	}


	///<summary>
	///Specifies or returns the style of a leader.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	public class StyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StyleName);

		}
	}


	///<summary>
	///Specifies or returns the style of a leader.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]
	public class Set_StyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StyleName = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the type of a leader.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	public class Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Type);

		}
	}


	///<summary>
	///Specifies or returns the type of a leader.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]
	public class Set_Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Type = inputs[1];
			return null;
		}
	}


	///<summary>
	///Evaluates and updates a leader and its associated entity and annotation.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	public class Evaluate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Evaluate();
			return null;
		}
	}


	///<summary>
	///Specifies or returns the coordinate of a single vertex in an object.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	public class Coordinate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Coordinate(inputs[1]));

		}
	}


	///<summary>
	///Specifies or returns the coordinate of a single vertex in an object.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_Coordinate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Coordinate[inputs[1]] = inputs[2];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the annotation of a leader.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	public class Annotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Annotation);

		}
	}


	///<summary>
	///Specifies or returns the annotation of a leader.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_Annotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Annotation = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the arrowhead size of a leader.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	public class ArrowheadSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowheadSize);

		}
	}


	///<summary>
	///Specifies or returns the arrowhead size of a leader.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("size", typeof(System.Double))]
	public class Set_ArrowheadSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowheadSize = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the arrowhead type of a leader.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	public class ArrowheadType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowheadType);

		}
	}


	///<summary>
	///Specifies or returns the arrowhead type of a leader.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]
	public class Set_ArrowheadType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowheadType = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the line color of a leader.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	public class DimensionLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimensionLineColor);

		}
	}


	///<summary>
	///Specifies or returns the line color of a leader.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]
	public class Set_DimensionLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimensionLineColor = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the lineweight of a leader.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	public class DimensionLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimensionLineWeight);

		}
	}


	///<summary>
	///Specifies or returns the lineweight of a leader.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("weight", typeof(System.Object))]
	public class Set_DimensionLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimensionLineWeight = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the scale of a leader.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	public class ScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleFactor);

		}
	}


	///<summary>
	///Specifies or returns the scale of a leader.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("factor", typeof(System.Object))]
	public class Set_ScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleFactor = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the vertical placement of a leader annotation.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	public class VerticalTextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VerticalTextPosition);

		}
	}


	///<summary>
	///Specifies or returns the vertical placement of a leader annotation.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]
	public class Set_VerticalTextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VerticalTextPosition = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the distance between the leader and the annotation.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	public class TextGap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextGap);

		}
	}


	///<summary>
	///Specifies or returns the distance between the leader and the annotation.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("Offset", typeof(System.Double))]
	public class Set_TextGap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextGap = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the block used for a custom arrowhead of a leader.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	public class ArrowheadBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowheadBlock);

		}
	}


	///<summary>
	///Specifies or returns the block used for a custom arrowhead of a leader.
	///</summary>
	[NodeInput("AcadLeader", typeof(object))]
	[NodeInput("BlockName", typeof(System.String))]
	public class Set_ArrowheadBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowheadBlock = inputs[1];
			return null;
		}
	}
}
