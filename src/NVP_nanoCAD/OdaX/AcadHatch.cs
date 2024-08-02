using NVP.API.Nodes;

namespace OdaX.AcadHatch 
{
	[NodeInput("dynamic", typeof(object))]
	public class AcadHatch_Constructor : INode 
	{
		public OdaX.IAcadHatch _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadHatch;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class AcadHatch_ConstructorCast : INode 
	{
		public OdaX.IAcadHatch _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadHatch;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	public class Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Normal);

		}
	}


	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("Normal", typeof(System.Object))]
	public class Set_Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Normal = inputs[1];
			return null;
		}
	}


	///<summary>
	///Returns the number of loops in a hatch.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	public class NumberOfLoops : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumberOfLoops);

		}
	}


	///<summary>
	///Returns the pattern type of a hatch.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	public class PatternType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PatternType);

		}
	}


	///<summary>
	///Returns the pattern name of a hatch.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	public class PatternName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PatternName);

		}
	}


	///<summary>
	///Specifies or returns the pattern angle of a hatch.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	public class PatternAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PatternAngle);

		}
	}


	///<summary>
	///Specifies or returns the pattern angle of a hatch.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("PatternAngle", typeof(System.Object))]
	public class Set_PatternAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PatternAngle = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the pattern scale of a hatch.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	public class PatternScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PatternScale);

		}
	}


	///<summary>
	///Specifies or returns the pattern scale of a hatch.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("PatternScale", typeof(System.Object))]
	public class Set_PatternScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PatternScale = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the pattern spacing of a hatch.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	public class PatternSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PatternSpace);

		}
	}


	///<summary>
	///Specifies or returns the pattern spacing of a hatch.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("PatternSpace", typeof(System.Double))]
	public class Set_PatternSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PatternSpace = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the ISO pen width of an ISO hatch pattern.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	public class ISOPenWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ISOPenWidth);

		}
	}


	///<summary>
	///Specifies or returns the ISO pen width of an ISO hatch pattern.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("penWidth", typeof(System.Object))]
	public class Set_ISOPenWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ISOPenWidth = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether cross-hatching is used to create a double pattern.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	public class PatternDouble : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PatternDouble);

		}
	}


	///<summary>
	///Specifies or returns whether cross-hatching is used to create a double pattern.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("bDouble", typeof(System.Object))]
	public class Set_PatternDouble : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PatternDouble = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the elevation of the hatch relative to the z-axis of the object's coordinate system.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	public class Elevation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Elevation);

		}
	}


	///<summary>
	///Specifies or returns the elevation of the hatch relative to the z-axis of the object's coordinate system.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("Elevation", typeof(System.Double))]
	public class Set_Elevation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Elevation = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether a hatch updates automatically when its boundary changes.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	public class AssociativeHatch : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AssociativeHatch);

		}
	}


	///<summary>
	///Specifies or returns whether a hatch updates automatically when its boundary changes.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("fAssoc", typeof(System.Object))]
	public class Set_AssociativeHatch : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AssociativeHatch = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the hatch style.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	public class HatchStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HatchStyle);

		}
	}


	///<summary>
	///Specifies or returns the hatch style.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("HatchStyle", typeof(System.Object))]
	public class Set_HatchStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HatchStyle = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the pattern of a hatch.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("PatternType", typeof(System.Int32))]
	[NodeInput("PatternName", typeof(System.String))]
	public class SetPattern : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetPattern(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Adds the outer loop to a hatch.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("ObjectArray", typeof(System.Object))]
	public class AppendOuterLoop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AppendOuterLoop(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Adds an inner loop to a hatch.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("ObjectArray", typeof(System.Object))]
	public class AppendInnerLoop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AppendInnerLoop(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Adds a loop at a specified index of a hatch.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("LoopType", typeof(System.Object))]
	[NodeInput("ObjectArray", typeof(System.Object))]
	public class InsertLoopAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertLoopAt(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Returns a loop at a specified index of a hatch.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("ObjectArray", typeof(System.Object))]
	public class GetLoopAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetLoopAt(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Calculates and fills the pattern of a hatch.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
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
	///Specifies or returns the gradient start color of a hatch.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	public class GradientColor1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GradientColor1);

		}
	}


	///<summary>
	///Specifies or returns the gradient start color of a hatch.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]
	public class Set_GradientColor1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GradientColor1 = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the gradient end color of a hatch.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	public class GradientColor2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GradientColor2);

		}
	}


	///<summary>
	///Specifies or returns the gradient end color of a hatch.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]
	public class Set_GradientColor2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GradientColor2 = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the gradient angle of a hatch.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	public class GradientAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GradientAngle);

		}
	}


	///<summary>
	///Specifies or returns the gradient angle of a hatch.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("GradientAngle", typeof(System.Object))]
	public class Set_GradientAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GradientAngle = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether the gradient is centered.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	public class GradientCentered : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GradientCentered);

		}
	}


	///<summary>
	///Specifies or returns whether the gradient is centered.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("fCentered", typeof(System.Object))]
	public class Set_GradientCentered : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GradientCentered = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the pattern name of the gradient.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	public class GradientName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GradientName);

		}
	}


	///<summary>
	///Specifies or returns the pattern name of the gradient.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]
	public class Set_GradientName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GradientName = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the hatch type.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	public class HatchObjectType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HatchObjectType);

		}
	}


	///<summary>
	///Specifies or returns the hatch type.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("hatchType", typeof(System.Object))]
	public class Set_HatchObjectType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HatchObjectType = inputs[1];
			return null;
		}
	}


	///<summary>
	///Not implemented. Returns the area of the hatch.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	public class Area : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Area);

		}
	}


	///<summary>
	///Specifies or returns the coordinates for the origin of the hatch pattern.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	public class Origin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Origin);

		}
	}


	///<summary>
	///Specifies or returns the coordinates for the origin of the hatch pattern.
	///</summary>
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("Origin", typeof(System.Object))]
	public class Set_Origin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Origin = inputs[1];
			return null;
		}
	}
}
