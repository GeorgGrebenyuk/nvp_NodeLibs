using NVP.API.Nodes;

namespace OdaX.AcadEntity 
{
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


		///<summary>
		///Specifies or returns the true color of an object.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		public class TrueColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TrueColor);

			}
		}


		///<summary>
		///Specifies or returns the true color of an object.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		[NodeInput("pColor", typeof(System.Object))]
		public class Set_TrueColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TrueColor = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the current layer of an object.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		public class Layer : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Layer);

			}
		}


		///<summary>
		///Specifies or returns the current layer of an object.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		[NodeInput("Layer", typeof(System.String))]
		public class Set_Layer : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Layer = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the current linetype of an object.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		public class Linetype : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Linetype);

			}
		}


		///<summary>
		///Specifies or returns the current linetype of an object.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		[NodeInput("Linetype", typeof(System.String))]
		public class Set_Linetype : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Linetype = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the linetype scale factor of an object.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		public class LinetypeScale : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LinetypeScale);

			}
		}


		///<summary>
		///Specifies or returns the linetype scale factor of an object.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		[NodeInput("ltScale", typeof(System.Object))]
		public class Set_LinetypeScale : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LinetypeScale = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the visibility of an object or the application.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		public class Visible : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Visible);

			}
		}


		///<summary>
		///Specifies or returns the visibility of an object or the application.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		[NodeInput("bVisible", typeof(System.Object))]
		public class Set_Visible : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Visible = inputs[1];
				return null;
			}
		}


		///<summary>
		///Not implemented. Creates an array of selected objects in a polar pattern.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		[NodeInput("NumberOfObjects", typeof(System.Int32))]
		[NodeInput("AngleToFill", typeof(System.Double))]
		[NodeInput("CenterPoint", typeof(System.Object))]
		public class ArrayPolar : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ArrayPolar(inputs[1],inputs[2],inputs[3]));

			}
		}


		///<summary>
		///Not implemented. Creates an array of selected objects in a rectangular pattern.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		[NodeInput("NumberOfRows", typeof(System.Int32))]
		[NodeInput("NumberOfColumns", typeof(System.Int32))]
		[NodeInput("NumberOfLevels", typeof(System.Int32))]
		[NodeInput("DistBetweenRows", typeof(System.Double))]
		[NodeInput("DistBetweenCols", typeof(System.Double))]
		[NodeInput("DistBetweenLevels", typeof(System.Double))]
		public class ArrayRectangular : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ArrayRectangular(inputs[1],inputs[2],inputs[3],inputs[4],inputs[5],inputs[6]));

			}
		}


		///<summary>
		///Not implemented. Highlights or removes highlight from an entity.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		[NodeInput("HighlightFlag", typeof(System.Object))]
		public class Highlight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Highlight(inputs[1]);
				return null;
			}
		}


		///<summary>
		///Copies a specified entity.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		public class Copy : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Copy);

			}
		}


		///<summary>
		///Moves an entity from one point to a second point.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		[NodeInput("FromPoint", typeof(System.Object))]
		[NodeInput("ToPoint", typeof(System.Object))]
		public class Move : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Move(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Rotates an entity around a point.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		[NodeInput("BasePoint", typeof(System.Object))]
		[NodeInput("RotationAngle", typeof(System.Double))]
		public class Rotate : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Rotate(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Rotates an entity around a line defined by two points, where the direction of the axis if from the first point to the second point.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		[NodeInput("Point1", typeof(System.Object))]
		[NodeInput("Point2", typeof(System.Object))]
		[NodeInput("RotationAngle", typeof(System.Double))]
		public class Rotate3D : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Rotate3D(inputs[1],inputs[2],inputs[3]);
				return null;
			}
		}


		///<summary>
		///Not implemented. Mirrors an object around a line defined by two points.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		[NodeInput("Point1", typeof(System.Object))]
		[NodeInput("Point2", typeof(System.Object))]
		public class Mirror : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Mirror(inputs[1],inputs[2]));

			}
		}


		///<summary>
		///Not implemented. Mirrors an object around a plane defined by three points.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		[NodeInput("Point1", typeof(System.Object))]
		[NodeInput("Point2", typeof(System.Object))]
		[NodeInput("point3", typeof(System.Object))]
		public class Mirror3D : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Mirror3D(inputs[1],inputs[2],inputs[3]));

			}
		}


		///<summary>
		///Scales an object with respect to a base point and scale factor.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		[NodeInput("BasePoint", typeof(System.Object))]
		[NodeInput("ScaleFactor", typeof(System.Double))]
		public class ScaleEntity : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ScaleEntity(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Performs the specified transformation on an entity.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		[NodeInput("TransformationMatrix", typeof(System.Object))]
		public class TransformBy : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TransformBy(inputs[1]);
				return null;
			}
		}


		///<summary>
		///Not implemented. Updates the display of an entity.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		public class Update : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Update();
				return null;
			}
		}


		///<summary>
		///Returns the minimum and maximum point of an entity's bounding box.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		[NodeInput("MinPoint", typeof(System.Object))]
		[NodeInput("MaxPoint", typeof(System.Object))]
		public class GetBoundingBox : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.GetBoundingBox(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///input) IntersectObject.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		[NodeInput("IntersectObject", typeof(System.Object))]
		[NodeInput("option", typeof(System.Object))]
		public class IntersectWith : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.IntersectWith(inputs[1],inputs[2]));

			}
		}


		///<summary>
		///Specifies or returns the plot style name of an object.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		public class PlotStyleName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PlotStyleName);

			}
		}


		///<summary>
		///Specifies or returns the plot style name of an object.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		[NodeInput("plotStyle", typeof(System.String))]
		public class Set_PlotStyleName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.PlotStyleName = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the lineweight of an object.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		public class Lineweight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Lineweight);

			}
		}


		///<summary>
		///Specifies or returns the lineweight of an object.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		[NodeInput("Lineweight", typeof(System.Object))]
		public class Set_Lineweight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Lineweight = inputs[1];
				return null;
			}
		}


		///<summary>
		///if one is specified).
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		public class Hyperlinks : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Hyperlinks);

			}
		}


		///<summary>
		///Specifies or returns the material of an object.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		public class Material : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Material);

			}
		}


		///<summary>
		///Specifies or returns the material of an object.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		[NodeInput("Material", typeof(System.String))]
		public class Set_Material : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Material = inputs[1];
				return null;
			}
		}


		///<summary>
		///Returns the class name of the object.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		public class EntityName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.EntityName);

			}
		}


		///<summary>
		///Returns the entity type of the object as an integer.
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		public class EntityType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.EntityType);

			}
		}


		///<summary>
		///Specifies the color for objects
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		public class color : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.color);

			}
		}


		///<summary>
		///Specifies the color for objects
		///</summary>
		[NodeInput("AcadEntity", typeof(object))]
		[NodeInput("color", typeof(System.Object))]
		public class Set_color : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.color = inputs[1];
				return null;
			}
		}
}
