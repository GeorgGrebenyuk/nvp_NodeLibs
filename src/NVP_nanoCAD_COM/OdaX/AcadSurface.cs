using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of Surface entity
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadSurface 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSurface_Constructor : INode 
	{
		public OdaX.IAcadSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSurface_ConstructorCast : INode 
	{
		public OdaX.IAcadSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Returns the type of a surface.", 
		ViewType = "Data")]
	[NodeInput("AcadSurface", typeof(object))]

	///<summary>
	///Returns the type of a surface.
	///</summary>
	public class SurfaceType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SurfaceType);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of U isolines per surface that display.", 
		ViewType = "Data")]
	[NodeInput("AcadSurface", typeof(object))]

	///<summary>
	///Specifies or returns the number of U isolines per surface that display.
	///</summary>
	public class UIsolineDensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UIsolineDensity);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of U isolines per surface that display.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSurface", typeof(object))]
	[NodeInput("density", typeof(System.Object))]

	///<summary>
	///Specifies or returns the number of U isolines per surface that display.
	///</summary>
	public class Set_UIsolineDensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UIsolineDensity = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of V isolines per surface that display.", 
		ViewType = "Data")]
	[NodeInput("AcadSurface", typeof(object))]

	///<summary>
	///Specifies or returns the number of V isolines per surface that display.
	///</summary>
	public class VIsolineDensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VIsolineDensity);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of V isolines per surface that display.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSurface", typeof(object))]
	[NodeInput("density", typeof(System.Object))]

	///<summary>
	///Specifies or returns the number of V isolines per surface that display.
	///</summary>
	public class Set_VIsolineDensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VIsolineDensity = inputs[1].Value;
			return null;
		}
	}
}
