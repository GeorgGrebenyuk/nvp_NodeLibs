using NVP.API.Nodes;

namespace OdaX.OdaRasterImage 
{
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


	///<summary>
	///Returns true if this Raster Image is currently loaded
	///</summary>
	[NodeInput("OdaRasterImage", typeof(object))]
	public class Loaded : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Loaded);

		}
	}
}
