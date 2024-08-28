using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///The standard interface for a basic TeighaX entity
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadEntity 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadEntity_Constructor : INode 
	{
		public OdaX.IAcadEntity _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadEntity;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadEntity_ConstructorCast : INode 
	{
		public OdaX.IAcadEntity _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadEntity;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the true color of an object.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///Specifies or returns the true color of an object.
	///</summary>
	public class TrueColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TrueColor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the true color of an object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the true color of an object.
	///</summary>
	public class Set_TrueColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TrueColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the current layer of an object.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///Specifies or returns the current layer of an object.
	///</summary>
	public class Layer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Layer);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the current layer of an object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("Layer", typeof(System.String))]

	///<summary>
	///Specifies or returns the current layer of an object.
	///</summary>
	public class Set_Layer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Layer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the current linetype of an object.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///Specifies or returns the current linetype of an object.
	///</summary>
	public class Linetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Linetype);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the current linetype of an object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]

	///<summary>
	///Specifies or returns the current linetype of an object.
	///</summary>
	public class Set_Linetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Linetype = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype scale factor of an object.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///Specifies or returns the linetype scale factor of an object.
	///</summary>
	public class LinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LinetypeScale);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype scale factor of an object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("ltScale", typeof(System.Object))]

	///<summary>
	///Specifies or returns the linetype scale factor of an object.
	///</summary>
	public class Set_LinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LinetypeScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the visibility of an object or the application.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///Specifies or returns the visibility of an object or the application.
	///</summary>
	public class Visible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Visible);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the visibility of an object or the application.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("bVisible", typeof(System.Object))]

	///<summary>
	///Specifies or returns the visibility of an object or the application.
	///</summary>
	public class Set_Visible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Visible = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Creates an array of selected objects in a polar pattern.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("NumberOfObjects", typeof(System.Int32))]
	[NodeInput("AngleToFill", typeof(System.Double))]
	[NodeInput("CenterPoint", typeof(System.Object))]

	///<summary>
	///Not implemented. Creates an array of selected objects in a polar pattern.
	///</summary>
	public class ArrayPolar : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrayPolar(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Creates an array of selected objects in a rectangular pattern.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("NumberOfRows", typeof(System.Int32))]
	[NodeInput("NumberOfColumns", typeof(System.Int32))]
	[NodeInput("NumberOfLevels", typeof(System.Int32))]
	[NodeInput("DistBetweenRows", typeof(System.Double))]
	[NodeInput("DistBetweenCols", typeof(System.Double))]
	[NodeInput("DistBetweenLevels", typeof(System.Double))]

	///<summary>
	///Not implemented. Creates an array of selected objects in a rectangular pattern.
	///</summary>
	public class ArrayRectangular : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrayRectangular(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value,inputs[6].Value));

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Highlights or removes highlight from an entity.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("HighlightFlag", typeof(System.Object))]

	///<summary>
	///Not implemented. Highlights or removes highlight from an entity.
	///</summary>
	public class Highlight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Highlight(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Copies a specified entity.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///Copies a specified entity.
	///</summary>
	public class Copy : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Copy);

		}
	}


	[NVP_Manifest(
		Text = "Moves an entity from one point to a second point.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("FromPoint", typeof(System.Object))]
	[NodeInput("ToPoint", typeof(System.Object))]

	///<summary>
	///Moves an entity from one point to a second point.
	///</summary>
	public class Move : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Move(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Rotates an entity around a point.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("BasePoint", typeof(System.Object))]
	[NodeInput("RotationAngle", typeof(System.Double))]

	///<summary>
	///Rotates an entity around a point.
	///</summary>
	public class Rotate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rotate(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Rotates an entity around a line defined by two points, where the direction of the axis if from the first point to the second point.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("Point1", typeof(System.Object))]
	[NodeInput("Point2", typeof(System.Object))]
	[NodeInput("RotationAngle", typeof(System.Double))]

	///<summary>
	///Rotates an entity around a line defined by two points, where the direction of the axis if from the first point to the second point.
	///</summary>
	public class Rotate3D : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rotate3D(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Mirrors an object around a line defined by two points.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("Point1", typeof(System.Object))]
	[NodeInput("Point2", typeof(System.Object))]

	///<summary>
	///Not implemented. Mirrors an object around a line defined by two points.
	///</summary>
	public class Mirror : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Mirror(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Mirrors an object around a plane defined by three points.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("Point1", typeof(System.Object))]
	[NodeInput("Point2", typeof(System.Object))]
	[NodeInput("point3", typeof(System.Object))]

	///<summary>
	///Not implemented. Mirrors an object around a plane defined by three points.
	///</summary>
	public class Mirror3D : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Mirror3D(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Text = "Scales an object with respect to a base point and scale factor.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("BasePoint", typeof(System.Object))]
	[NodeInput("ScaleFactor", typeof(System.Double))]

	///<summary>
	///Scales an object with respect to a base point and scale factor.
	///</summary>
	public class ScaleEntity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleEntity(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Performs the specified transformation on an entity.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("TransformationMatrix", typeof(System.Object))]

	///<summary>
	///Performs the specified transformation on an entity.
	///</summary>
	public class TransformBy : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TransformBy(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Updates the display of an entity.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///Not implemented. Updates the display of an entity.
	///</summary>
	public class Update : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Update();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the minimum and maximum point of an entity's bounding box.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("MinPoint", typeof(System.Object))]
	[NodeInput("MaxPoint", typeof(System.Object))]

	///<summary>
	///Returns the minimum and maximum point of an entity's bounding box.
	///</summary>
	public class GetBoundingBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetBoundingBox(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "input) IntersectObject.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("IntersectObject", typeof(System.Object))]
	[NodeInput("OdaX.AcExtendOption", typeof(System.Object))]

	///<summary>
	///input) IntersectObject.
	///</summary>
	public class IntersectWith : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectWith(inputs[1].Value,((OdaX.AcExtendOption)inputs[2].Value)));

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the plot style name of an object.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///Specifies or returns the plot style name of an object.
	///</summary>
	public class PlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotStyleName);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the plot style name of an object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("plotStyle", typeof(System.String))]

	///<summary>
	///Specifies or returns the plot style name of an object.
	///</summary>
	public class Set_PlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotStyleName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lineweight of an object.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///Specifies or returns the lineweight of an object.
	///</summary>
	public class Lineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Lineweight);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lineweight of an object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("Lineweight", typeof(System.Object))]

	///<summary>
	///Specifies or returns the lineweight of an object.
	///</summary>
	public class Set_Lineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Lineweight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "if one is specified).", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///if one is specified).
	///</summary>
	public class Hyperlinks : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Hyperlinks);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the material of an object.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///Specifies or returns the material of an object.
	///</summary>
	public class Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Material);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the material of an object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("Material", typeof(System.String))]

	///<summary>
	///Specifies or returns the material of an object.
	///</summary>
	public class Set_Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Material = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the class name of the object.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///Returns the class name of the object.
	///</summary>
	public class EntityName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EntityName);

		}
	}


	[NVP_Manifest(
		Text = "Returns the entity type of the object as an integer.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///Returns the entity type of the object as an integer.
	///</summary>
	public class EntityType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EntityType);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the color for objects", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///Specifies the color for objects
	///</summary>
	public class color : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.color);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the color for objects", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("color", typeof(System.Object))]

	///<summary>
	///Specifies the color for objects
	///</summary>
	public class Set_color : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.color = inputs[1].Value;
			return null;
		}
	}
}
