using NVP.API.Nodes;

namespace Renga.Image 
{
	[NodeInput("dynamic", typeof(object))]
	public class Image_Constructor : INode 
	{
		public Renga.IImage _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IImage;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class Image_ConstructorCast : INode 
	{
		public Renga.IImage _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IImage;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Image", typeof(object))]
	public class LoadFromData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LoadFromData();
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Image", typeof(object))]
	[NodeInput("path_", typeof(System.String))]
	public class LoadFromFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LoadFromFile(inputs[1]);
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Image", typeof(object))]
	[NodeInput("path_", typeof(System.String))]
	[NodeInput("format", typeof(System.Object))]
	public class SaveToFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SaveToFile(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Image", typeof(object))]
	[NodeInput("format", typeof(System.Object))]
	public class SaveToData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SaveToData(inputs[1]);
			return null;
		}
	}
}
