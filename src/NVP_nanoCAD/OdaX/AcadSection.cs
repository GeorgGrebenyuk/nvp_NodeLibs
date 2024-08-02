using NVP.API.Nodes;

namespace OdaX.AcadSection 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadSection_Constructor : INode 
		{
		public OdaX.IAcadSection _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadSection;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadSection_ConstructorCast : INode 
		{
		public OdaX.IAcadSection _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadSection;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Specifies or returns the name of a section.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		public class Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Name);

			}
		}


		///<summary>
		///Specifies or returns the name of a section.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		[NodeInput("pbstrName", typeof(System.String))]
		public class Set_Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Name = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the type of a section.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		public class State : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.State);

			}
		}


		///<summary>
		///Specifies or returns the type of a section.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_State : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.State = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the direction in which a section is viewed.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		public class ViewingDirection : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ViewingDirection);

			}
		}


		///<summary>
		///Specifies or returns the direction in which a section is viewed.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_ViewingDirection : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ViewingDirection = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the vertical direction for a section.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		public class VerticalDirection : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.VerticalDirection);

			}
		}


		///<summary>
		///Specifies or returns the vertical direction for a section.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_VerticalDirection : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.VerticalDirection = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the x, y, and z coordinates of the normal direction.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		public class Normal : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Normal);

			}
		}


		///<summary>
		///Specifies or returns whether live section is turned on for a section.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		public class LiveSectionEnabled : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LiveSectionEnabled);

			}
		}


		///<summary>
		///Specifies or returns whether live section is turned on for a section.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_LiveSectionEnabled : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LiveSectionEnabled = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether a section is transparent when shading is used.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		public class IndicatorTransparency : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.IndicatorTransparency);

			}
		}


		///<summary>
		///Specifies or returns whether a section is transparent when shading is used.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		[NodeInput("pVal", typeof(System.Int32))]
		public class Set_IndicatorTransparency : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.IndicatorTransparency = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the color of a section when shading is used.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		public class IndicatorFillColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.IndicatorFillColor);

			}
		}


		///<summary>
		///Specifies or returns the color of a section when shading is used.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		[NodeInput("pColor", typeof(System.Object))]
		public class Set_IndicatorFillColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.IndicatorFillColor = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the elevation of a section relative to the z-axis of the object's coordinate system.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		public class Elevation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Elevation);

			}
		}


		///<summary>
		///Specifies or returns the elevation of a section relative to the z-axis of the object's coordinate system.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		[NodeInput("pVal", typeof(System.Double))]
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
		///Specifies or returns top extents relative to the section’s elevation.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		public class TopHeight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TopHeight);

			}
		}


		///<summary>
		///Specifies or returns top extents relative to the section’s elevation.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		[NodeInput("pVal", typeof(System.Double))]
		public class Set_TopHeight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TopHeight = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns bottom extents relative to the section’s elevation.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		public class BottomHeight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.BottomHeight);

			}
		}


		///<summary>
		///Specifies or returns bottom extents relative to the section’s elevation.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		[NodeInput("pVal", typeof(System.Double))]
		public class Set_BottomHeight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.BottomHeight = inputs[1];
				return null;
			}
		}


		///<summary>
		///Returns the number of vertices in the section line.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		public class NumVertices : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.NumVertices);

			}
		}


		///<summary>
		///Specifies or returns the vertices in the section line.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		public class Vertices : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Vertices);

			}
		}


		///<summary>
		///Specifies or returns the vertices in the section line.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_Vertices : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Vertices = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the coordinates of a single vertex in a section.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
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
		///Specifies or returns the coordinates of a single vertex in a section.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
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
		///Adds a new vertex to a section line.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		[NodeInput("nIndex", typeof(System.Int32))]
		[NodeInput("val", typeof(System.Object))]
		public class AddVertex : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AddVertex(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Removes a vertex from a section line.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		[NodeInput("nIndex", typeof(System.Int32))]
		public class RemoveVertex : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.RemoveVertex(inputs[1]);
				return null;
			}
		}


		///<summary>
		///Not implemented. Determines whether a vertex is on a section.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		[NodeInput("varPtHit", typeof(System.Object))]
		[NodeInput("pHit", typeof(System.Object))]
		[NodeInput("pSegmentIndex", typeof(System.Int32))]
		[NodeInput("pPtOnSegment", typeof(System.Object))]
		[NodeInput("pSubItem", typeof(System.Object))]
		public class HitTest : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.HitTest(inputs[1],inputs[2],inputs[3],inputs[4],inputs[5]);
				return null;
			}
		}


		///<summary>
		///Creates a jog in a section.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		[NodeInput("varPt", typeof(System.Object))]
		public class CreateJog : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.CreateJog(inputs[1]);
				return null;
			}
		}


		///<summary>
		///Gets the Section Settings object for a section.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		public class Settings : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Settings);

			}
		}


		///<summary>
		///Not implemented. Generates two- or three-dimensional geometry for a section.
		///</summary>
		[NodeInput("AcadSection", typeof(object))]
		[NodeInput("pEntity", typeof(System.Object))]
		[NodeInput("pIntersectionBoundaryObjs", typeof(System.Object))]
		[NodeInput("pIntersectionFillObjs", typeof(System.Object))]
		[NodeInput("pBackgroudnObjs", typeof(System.Object))]
		[NodeInput("pForegroudObjs", typeof(System.Object))]
		[NodeInput("pCurveTangencyObjs", typeof(System.Object))]
		public class GenerateSectionGeometry : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.GenerateSectionGeometry(inputs[1],inputs[2],inputs[3],inputs[4],inputs[5],inputs[6]);
				return null;
			}
		}
}
