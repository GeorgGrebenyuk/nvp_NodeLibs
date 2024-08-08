using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a user-defined coordinate system that determines the orientation of the X, Y, and Z axes in 3D space
///</summary>
namespace OdaX.AcadUCS 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadUCS_Constructor : INode 
	{
		public OdaX.IAcadUCS _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadUCS;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadUCS_ConstructorCast : INode 
	{
		public OdaX.IAcadUCS _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadUCS;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies the name of the object", 
		ViewType = "Data")]
	[NodeInput("AcadUCS", typeof(object))]

	///<summary>
	///Specifies the name of the object
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
		Text = "Specifies the name of the object", 
		ViewType = "Modifier")]
	[NodeInput("AcadUCS", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies the name of the object
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
		Text = "Specifies the origin of the UCS, block, layout, or raster image in WCS coordinates", 
		ViewType = "Data")]
	[NodeInput("AcadUCS", typeof(object))]

	///<summary>
	///Specifies the origin of the UCS, block, layout, or raster image in WCS coordinates
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
		Text = "Specifies the origin of the UCS, block, layout, or raster image in WCS coordinates", 
		ViewType = "Modifier")]
	[NodeInput("AcadUCS", typeof(object))]
	[NodeInput("Origin", typeof(System.Object))]

	///<summary>
	///Specifies the origin of the UCS, block, layout, or raster image in WCS coordinates
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


	[NVP_Manifest(
		Text = "Specifies the X direction of the given UCS", 
		ViewType = "Data")]
	[NodeInput("AcadUCS", typeof(object))]

	///<summary>
	///Specifies the X direction of the given UCS
	///</summary>
	public class XVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.XVector);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the X direction of the given UCS", 
		ViewType = "Modifier")]
	[NodeInput("AcadUCS", typeof(object))]
	[NodeInput("XVector", typeof(System.Object))]

	///<summary>
	///Specifies the X direction of the given UCS
	///</summary>
	public class Set_XVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.XVector = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the Y direction of the given UCS", 
		ViewType = "Data")]
	[NodeInput("AcadUCS", typeof(object))]

	///<summary>
	///Specifies the Y direction of the given UCS
	///</summary>
	public class YVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.YVector);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the Y direction of the given UCS", 
		ViewType = "Modifier")]
	[NodeInput("AcadUCS", typeof(object))]
	[NodeInput("YVector", typeof(System.Object))]

	///<summary>
	///Specifies the Y direction of the given UCS
	///</summary>
	public class Set_YVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.YVector = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Gets the transformation matrix consisting of UCS coordinate system data", 
		ViewType = "Data")]
	[NodeInput("AcadUCS", typeof(object))]

	///<summary>
	///Gets the transformation matrix consisting of UCS coordinate system data
	///</summary>
	public class GetUCSMatrix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetUCSMatrix);

		}
	}
}
