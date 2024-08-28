using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface for an additional Raster Image funtionality
///</summary>
namespace NVP_nanoCAD_COM._OdaX.OdaRasterImage 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaRasterImage_Constructor : INode 
	{
		public OdaX.IOdaRasterImage _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IOdaRasterImage;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaRasterImage_ConstructorCast : INode 
	{
		public OdaX.IOdaRasterImage _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IOdaRasterImage;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Returns true if this Raster Image is currently loaded", 
		ViewType = "Data")]
	[NodeInput("OdaRasterImage", typeof(object))]

	///<summary>
	///Returns true if this Raster Image is currently loaded
	///</summary>
	public class Loaded : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Loaded);

		}
	}
}
