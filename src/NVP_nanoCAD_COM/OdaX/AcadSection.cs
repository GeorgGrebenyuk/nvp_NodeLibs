using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a section plane entity created at the intersection of a plane and a solid
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadSection 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
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

	[NVP_Manifest(
		ViewType = "Modifier")]
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


	[NVP_Manifest(
		Text = "Specifies or returns the name of a section.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Specifies or returns the name of a section.
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the name of a section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("pbstrName", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of a section.
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the type of a section.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Specifies or returns the type of a section.
	///</summary>
	public class State : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.State);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the type of a section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("OdaX.AcSectionState", typeof(System.Object))]

	///<summary>
	///Specifies or returns the type of a section.
	///</summary>
	public class Set_State : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.State = ((OdaX.AcSectionState)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the direction in which a section is viewed.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Specifies or returns the direction in which a section is viewed.
	///</summary>
	public class ViewingDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ViewingDirection);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the direction in which a section is viewed.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the direction in which a section is viewed.
	///</summary>
	public class Set_ViewingDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ViewingDirection = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the vertical direction for a section.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Specifies or returns the vertical direction for a section.
	///</summary>
	public class VerticalDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VerticalDirection);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the vertical direction for a section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the vertical direction for a section.
	///</summary>
	public class Set_VerticalDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VerticalDirection = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction.
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
		Text = "Specifies or returns whether live section is turned on for a section.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Specifies or returns whether live section is turned on for a section.
	///</summary>
	public class LiveSectionEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LiveSectionEnabled);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether live section is turned on for a section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether live section is turned on for a section.
	///</summary>
	public class Set_LiveSectionEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LiveSectionEnabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a section is transparent when shading is used.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Specifies or returns whether a section is transparent when shading is used.
	///</summary>
	public class IndicatorTransparency : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IndicatorTransparency);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a section is transparent when shading is used.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("pVal", typeof(System.Int32))]

	///<summary>
	///Specifies or returns whether a section is transparent when shading is used.
	///</summary>
	public class Set_IndicatorTransparency : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IndicatorTransparency = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of a section when shading is used.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Specifies or returns the color of a section when shading is used.
	///</summary>
	public class IndicatorFillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IndicatorFillColor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of a section when shading is used.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of a section when shading is used.
	///</summary>
	public class Set_IndicatorFillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IndicatorFillColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the elevation of a section relative to the z-axis of the object's coordinate system.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Specifies or returns the elevation of a section relative to the z-axis of the object's coordinate system.
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
		Text = "Specifies or returns the elevation of a section relative to the z-axis of the object's coordinate system.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Specifies or returns the elevation of a section relative to the z-axis of the object's coordinate system.
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
		Text = "Specifies or returns top extents relative to the section’s elevation.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Specifies or returns top extents relative to the section’s elevation.
	///</summary>
	public class TopHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TopHeight);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns top extents relative to the section’s elevation.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Specifies or returns top extents relative to the section’s elevation.
	///</summary>
	public class Set_TopHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TopHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns bottom extents relative to the section’s elevation.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Specifies or returns bottom extents relative to the section’s elevation.
	///</summary>
	public class BottomHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BottomHeight);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns bottom extents relative to the section’s elevation.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Specifies or returns bottom extents relative to the section’s elevation.
	///</summary>
	public class Set_BottomHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BottomHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the number of vertices in the section line.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Returns the number of vertices in the section line.
	///</summary>
	public class NumVertices : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumVertices);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the vertices in the section line.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Specifies or returns the vertices in the section line.
	///</summary>
	public class Vertices : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Vertices);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the vertices in the section line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the vertices in the section line.
	///</summary>
	public class Set_Vertices : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Vertices = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the coordinates of a single vertex in a section.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Specifies or returns the coordinates of a single vertex in a section.
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
		Text = "Specifies or returns the coordinates of a single vertex in a section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the coordinates of a single vertex in a section.
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
		Text = "Adds a new vertex to a section line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("nIndex", typeof(System.Int32))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Adds a new vertex to a section line.
	///</summary>
	public class AddVertex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddVertex(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Removes a vertex from a section line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("nIndex", typeof(System.Int32))]

	///<summary>
	///Removes a vertex from a section line.
	///</summary>
	public class RemoveVertex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RemoveVertex(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Determines whether a vertex is on a section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("varPtHit", typeof(System.Object))]
	[NodeInput("pHit", typeof(System.Object))]
	[NodeInput("pSegmentIndex", typeof(System.Int32))]
	[NodeInput("pPtOnSegment", typeof(System.Object))]
	[NodeInput("OdaX.AcSectionSubItem", typeof(System.Object))]

	///<summary>
	///Not implemented. Determines whether a vertex is on a section.
	///</summary>
	public class HitTest : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HitTest(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,((OdaX.AcSectionSubItem)inputs[5].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Creates a jog in a section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("varPt", typeof(System.Object))]

	///<summary>
	///Creates a jog in a section.
	///</summary>
	public class CreateJog : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CreateJog(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Gets the Section Settings object for a section.", 
		ViewType = "Data")]
	[NodeInput("AcadSection", typeof(object))]

	///<summary>
	///Gets the Section Settings object for a section.
	///</summary>
	public class Settings : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Settings);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Generates two- or three-dimensional geometry for a section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSection", typeof(object))]
	[NodeInput("pEntity", typeof(System.Object))]
	[NodeInput("pIntersectionBoundaryObjs", typeof(System.Object))]
	[NodeInput("pIntersectionFillObjs", typeof(System.Object))]
	[NodeInput("pBackgroudnObjs", typeof(System.Object))]
	[NodeInput("pForegroudObjs", typeof(System.Object))]
	[NodeInput("pCurveTangencyObjs", typeof(System.Object))]

	///<summary>
	///Not implemented. Generates two- or three-dimensional geometry for a section.
	///</summary>
	public class GenerateSectionGeometry : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GenerateSectionGeometry(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value,inputs[6].Value);
			return null;
		}
	}
}
