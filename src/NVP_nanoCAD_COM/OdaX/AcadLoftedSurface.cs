using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a surface created by lofting through a set of two or more curves
///</summary>
namespace OdaX.AcadLoftedSurface 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadLoftedSurface_Constructor : INode 
	{
		public OdaX.IAcadLoftedSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadLoftedSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadLoftedSurface_ConstructorCast : INode 
	{
		public OdaX.IAcadLoftedSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadLoftedSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Returns the number of cross-sections used to create a lofted surface.", 
		ViewType = "Data")]
	[NodeInput("AcadLoftedSurface", typeof(object))]

	///<summary>
	///Returns the number of cross-sections used to create a lofted surface.
	///</summary>
	public class NumCrossSections : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumCrossSections);

		}
	}


	[NVP_Manifest(
		Text = "Returns the number of guide paths used to create a lofted surface.", 
		ViewType = "Data")]
	[NodeInput("AcadLoftedSurface", typeof(object))]

	///<summary>
	///Returns the number of guide paths used to create a lofted surface.
	///</summary>
	public class NumGuidePaths : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumGuidePaths);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns which curves are normal to the cross-sections.", 
		ViewType = "Data")]
	[NodeInput("AcadLoftedSurface", typeof(object))]

	///<summary>
	///Specifies or returns which curves are normal to the cross-sections.
	///</summary>
	public class SurfaceNormals : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SurfaceNormals);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns which curves are normal to the cross-sections.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLoftedSurface", typeof(object))]
	[NodeInput("OdaX.AcLoftedSurfaceNormalType", typeof(System.Object))]

	///<summary>
	///Specifies or returns which curves are normal to the cross-sections.
	///</summary>
	public class Set_SurfaceNormals : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SurfaceNormals = ((OdaX.AcLoftedSurfaceNormalType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the angle of the first cross-section surface.", 
		ViewType = "Data")]
	[NodeInput("AcadLoftedSurface", typeof(object))]

	///<summary>
	///Specifies or returns the angle of the first cross-section surface.
	///</summary>
	public class StartDraftAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartDraftAngle);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the angle of the first cross-section surface.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLoftedSurface", typeof(object))]
	[NodeInput("StartDraftAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the angle of the first cross-section surface.
	///</summary>
	public class Set_StartDraftAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartDraftAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the magnitude of the first cross-section surface.", 
		ViewType = "Data")]
	[NodeInput("AcadLoftedSurface", typeof(object))]

	///<summary>
	///Specifies or returns the magnitude of the first cross-section surface.
	///</summary>
	public class StartDraftMagnitude : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartDraftMagnitude);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the magnitude of the first cross-section surface.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLoftedSurface", typeof(object))]
	[NodeInput("startDraftMag", typeof(System.Double))]

	///<summary>
	///Specifies or returns the magnitude of the first cross-section surface.
	///</summary>
	public class Set_StartDraftMagnitude : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartDraftMagnitude = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the angle of the last cross-section surface.", 
		ViewType = "Data")]
	[NodeInput("AcadLoftedSurface", typeof(object))]

	///<summary>
	///Specifies or returns the angle of the last cross-section surface.
	///</summary>
	public class EndDraftAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndDraftAngle);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the angle of the last cross-section surface.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLoftedSurface", typeof(object))]
	[NodeInput("EndDraftAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the angle of the last cross-section surface.
	///</summary>
	public class Set_EndDraftAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndDraftAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the magnitude of the last cross-section surface.", 
		ViewType = "Data")]
	[NodeInput("AcadLoftedSurface", typeof(object))]

	///<summary>
	///Specifies or returns the magnitude of the last cross-section surface.
	///</summary>
	public class EndDraftMagnitude : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndDraftMagnitude);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the magnitude of the last cross-section surface.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLoftedSurface", typeof(object))]
	[NodeInput("endDraftMag", typeof(System.Double))]

	///<summary>
	///Specifies or returns the magnitude of the last cross-section surface.
	///</summary>
	public class Set_EndDraftMagnitude : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndDraftMagnitude = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specfies or returns whether the lofted surface is open or closed.", 
		ViewType = "Data")]
	[NodeInput("AcadLoftedSurface", typeof(object))]

	///<summary>
	///Specfies or returns whether the lofted surface is open or closed.
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
		Text = "Specfies or returns whether the lofted surface is open or closed.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLoftedSurface", typeof(object))]
	[NodeInput("bClosed", typeof(System.Object))]

	///<summary>
	///Specfies or returns whether the lofted surface is open or closed.
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
}
