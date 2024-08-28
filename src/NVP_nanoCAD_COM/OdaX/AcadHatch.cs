using NVP.API.Nodes;
using System;
using System.Collections.Generic;
using System.Collections;

using NVP_Manifest_Creator;
using System.Linq;

///<summary>
///TeighaX Interface of an area fill consisting of a pattern of lines
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadHatch 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
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

	[NVP_Manifest(
		ViewType = "Modifier")]
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


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
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
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("Normal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
	///</summary>
	public class Set_Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Normal = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the number of loops in a hatch.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Returns the number of loops in a hatch.
	///</summary>
	public class NumberOfLoops : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumberOfLoops);

		}
	}


	[NVP_Manifest(
		Text = "Returns the pattern type of a hatch.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Returns the pattern type of a hatch.
	///</summary>
	public class PatternType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PatternType);

		}
	}


	[NVP_Manifest(
		Text = "Returns the pattern name of a hatch.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Returns the pattern name of a hatch.
	///</summary>
	public class PatternName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PatternName);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the pattern angle of a hatch.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns the pattern angle of a hatch.
	///</summary>
	public class PatternAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PatternAngle);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the pattern angle of a hatch.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("PatternAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the pattern angle of a hatch.
	///</summary>
	public class Set_PatternAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PatternAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the pattern scale of a hatch.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns the pattern scale of a hatch.
	///</summary>
	public class PatternScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PatternScale);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the pattern scale of a hatch.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("PatternScale", typeof(System.Object))]

	///<summary>
	///Specifies or returns the pattern scale of a hatch.
	///</summary>
	public class Set_PatternScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PatternScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the pattern spacing of a hatch.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns the pattern spacing of a hatch.
	///</summary>
	public class PatternSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PatternSpace);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the pattern spacing of a hatch.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("PatternSpace", typeof(System.Double))]

	///<summary>
	///Specifies or returns the pattern spacing of a hatch.
	///</summary>
	public class Set_PatternSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PatternSpace = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the ISO pen width of an ISO hatch pattern.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns the ISO pen width of an ISO hatch pattern.
	///</summary>
	public class ISOPenWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ISOPenWidth);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the ISO pen width of an ISO hatch pattern.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("OdaX.AcISOPenWidth", typeof(System.Object))]

	///<summary>
	///Specifies or returns the ISO pen width of an ISO hatch pattern.
	///</summary>
	public class Set_ISOPenWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ISOPenWidth = ((OdaX.AcISOPenWidth)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether cross-hatching is used to create a double pattern.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns whether cross-hatching is used to create a double pattern.
	///</summary>
	public class PatternDouble : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PatternDouble);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether cross-hatching is used to create a double pattern.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("bDouble", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether cross-hatching is used to create a double pattern.
	///</summary>
	public class Set_PatternDouble : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PatternDouble = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the elevation of the hatch relative to the z-axis of the object's coordinate system.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns the elevation of the hatch relative to the z-axis of the object's coordinate system.
	///</summary>
	public class Elevation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Elevation);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the elevation of the hatch relative to the z-axis of the object's coordinate system.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("Elevation", typeof(System.Double))]

	///<summary>
	///Specifies or returns the elevation of the hatch relative to the z-axis of the object's coordinate system.
	///</summary>
	public class Set_Elevation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Elevation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a hatch updates automatically when its boundary changes.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns whether a hatch updates automatically when its boundary changes.
	///</summary>
	public class AssociativeHatch : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AssociativeHatch);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a hatch updates automatically when its boundary changes.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("fAssoc", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a hatch updates automatically when its boundary changes.
	///</summary>
	public class Set_AssociativeHatch : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AssociativeHatch = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the hatch style.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns the hatch style.
	///</summary>
	public class HatchStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HatchStyle);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the hatch style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("OdaX.AcHatchStyle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the hatch style.
	///</summary>
	public class Set_HatchStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HatchStyle = ((OdaX.AcHatchStyle)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the pattern of a hatch.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("PatternType", typeof(System.Int32))]
	[NodeInput("PatternName", typeof(System.String))]

	///<summary>
	///Specifies the pattern of a hatch.
	///</summary>
	public class SetPattern : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetPattern(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Adds the outer loop (one entity) to a hatch.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///Adds the outer loop to a hatch for one entity
	///</summary>
	public class AppendOuterLoop_Single : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			dynamic _item = inputs[1].Value;
			object[] ents = new object[1] { _item._i };
			_input0._i.AppendOuterLoop(ents);
            return new NodeResult(null);
        }
	}

    [NVP_Manifest(
    Text = "Adds the outer loop (some entities) to a hatch.",
    ViewType = "Modifier")]
    [NodeInput("AcadHatch", typeof(object))]
    [NodeInput("Список AcadEntity", typeof(object))]

    ///<summary>
    ///Adds the outer loop to a hatch fro some entities
    ///</summary>
    public class AppendOuterLoop_Group : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
			IList _items_raw = (IList)inputs[1].Value;
			List<object> ents = new List<object>();
			foreach (dynamic item in _items_raw)
			{
                ents.Add(item._i);

            }
			
            _input0._i.AppendOuterLoop(ents.ToArray());
            return new NodeResult(null);
        }
    }


    [NVP_Manifest(
		Text = "Adds an inner loop to a hatch.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("ObjectArray", typeof(System.Object))]

	///<summary>
	///Adds an inner loop to a hatch.
	///</summary>
	public class AppendInnerLoop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AppendInnerLoop(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Adds a loop at a specified index of a hatch.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("OdaX.AcLoopType", typeof(System.Object))]
	[NodeInput("ObjectArray", typeof(System.Object))]

	///<summary>
	///Adds a loop at a specified index of a hatch.
	///</summary>
	public class InsertLoopAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertLoopAt(inputs[1].Value,((OdaX.AcLoopType)inputs[2].Value),inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns a loop at a specified index of a hatch.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("ObjectArray", typeof(System.Object))]

	///<summary>
	///Returns a loop at a specified index of a hatch.
	///</summary>
	public class GetLoopAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetLoopAt(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Calculates and fills the pattern of a hatch.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Calculates and fills the pattern of a hatch.
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
		Text = "Specifies or returns the gradient start color of a hatch.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns the gradient start color of a hatch.
	///</summary>
	public class GradientColor1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GradientColor1);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the gradient start color of a hatch.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the gradient start color of a hatch.
	///</summary>
	public class Set_GradientColor1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GradientColor1 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the gradient end color of a hatch.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns the gradient end color of a hatch.
	///</summary>
	public class GradientColor2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GradientColor2);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the gradient end color of a hatch.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the gradient end color of a hatch.
	///</summary>
	public class Set_GradientColor2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GradientColor2 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the gradient angle of a hatch.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns the gradient angle of a hatch.
	///</summary>
	public class GradientAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GradientAngle);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the gradient angle of a hatch.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("GradientAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the gradient angle of a hatch.
	///</summary>
	public class Set_GradientAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GradientAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the gradient is centered.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns whether the gradient is centered.
	///</summary>
	public class GradientCentered : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GradientCentered);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the gradient is centered.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("fCentered", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the gradient is centered.
	///</summary>
	public class Set_GradientCentered : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GradientCentered = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the pattern name of the gradient.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns the pattern name of the gradient.
	///</summary>
	public class GradientName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GradientName);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the pattern name of the gradient.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies or returns the pattern name of the gradient.
	///</summary>
	public class Set_GradientName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GradientName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the hatch type.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns the hatch type.
	///</summary>
	public class HatchObjectType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HatchObjectType);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the hatch type.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("OdaX.AcHatchObjectType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the hatch type.
	///</summary>
	public class Set_HatchObjectType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HatchObjectType = ((OdaX.AcHatchObjectType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Returns the area of the hatch.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Not implemented. Returns the area of the hatch.
	///</summary>
	public class Area : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Area);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the coordinates for the origin of the hatch pattern.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns the coordinates for the origin of the hatch pattern.
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
		Text = "Specifies or returns the coordinates for the origin of the hatch pattern.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("Origin", typeof(System.Object))]

	///<summary>
	///Specifies or returns the coordinates for the origin of the hatch pattern.
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
}
