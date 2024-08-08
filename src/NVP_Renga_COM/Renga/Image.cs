using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Image 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
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

	[NVP_Manifest(
		ViewType = "Modifier")]
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


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Image", typeof(object))]

	///<summary>
	///
	///</summary>
	public class LoadFromData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LoadFromData();
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Image", typeof(object))]
	[NodeInput("path_", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class LoadFromFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LoadFromFile(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Image", typeof(object))]
	[NodeInput("path_", typeof(System.String))]
	[NodeInput("Renga.ImageFormat", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class SaveToFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SaveToFile(inputs[1].Value,((Renga.ImageFormat)inputs[2].Value));
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Image", typeof(object))]
	[NodeInput("Renga.ImageFormat", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class SaveToData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SaveToData(((Renga.ImageFormat)inputs[1].Value));
			return null;
		}
	}
}
